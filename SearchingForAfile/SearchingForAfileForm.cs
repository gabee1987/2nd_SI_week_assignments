using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchingForAfile
{
    public partial class SearchingForAfileForm : Form
    {

        private StringBuilder stringBuilder;
        private bool change;
        private FileSystemWatcher watcher;
        private bool IsWatching;
        private FileInfo selectedFileInfo;
        private DirectoryInfo selectedDirectoryInfo;
        private DirectoryInfo archiveDirectoryInfo;


        public SearchingForAfileForm()
        {
            InitializeComponent();
            stringBuilder = new StringBuilder();
            change = false;
            IsWatching = false;
        }

        private void StartWatchButton_Click(object sender, EventArgs e)
        {
            // If watching is already on, stop it
            if (IsWatching)
            {
                IsWatching = false;
                watcher.EnableRaisingEvents = false;
                watcher.Dispose();
                StartWatchButton.ForeColor = Color.DarkGreen;
                StartWatchButton.Text = "Start Watching";
                LoadingPictureBox.Visible = false;
            }
            // Create FileSystemWatcher for selected file or directory
            else
            {
                // If there is no selected file or directory, show an alert
                if (string.IsNullOrWhiteSpace(FileToWatchTextBox.Text))
                {
                    MessageBox.Show("No file or directory added.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    IsWatching = true;
                    StartWatchButton.ForeColor = Color.Crimson;
                    StartWatchButton.Text = "Stop Watching";

                    watcher = new FileSystemWatcher();
                    if (WatchDirectoryRadioButton.Checked)
                    {
                        watcher.Filter = "*.*";
                        watcher.Path = FileToWatchTextBox.Text + "\\";
                        selectedDirectoryInfo = new DirectoryInfo(FileToWatchTextBox.Text + "\\");
                    }
                    else
                    {
                        watcher.Filter = FileToWatchTextBox.Text.Substring(FileToWatchTextBox.Text.LastIndexOf('\\') + 1);
                        watcher.Path = FileToWatchTextBox.Text.Substring(0, FileToWatchTextBox.Text.Length - watcher.Filter.Length);
                        selectedFileInfo = new FileInfo(watcher.Filter);
                        selectedDirectoryInfo = new DirectoryInfo(watcher.Path);
                    }

                    if (SubFoldersCheckBox.Checked)
                    {
                        watcher.IncludeSubdirectories = true;
                    }

                    watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                                        | NotifyFilters.FileName | NotifyFilters.DirectoryName;

                    if (ArchiveCheckBox.Checked)
                    {
                        watcher.Changed += new FileSystemEventHandler(OnChangedAndArchive);
                        watcher.Created += new FileSystemEventHandler(OnChangedAndArchive);
                        watcher.Deleted += new FileSystemEventHandler(OnChangedAndArchive);
                        watcher.Renamed += new RenamedEventHandler(OnRenamed);
                        watcher.EnableRaisingEvents = true;
                    }
                    else
                    {
                    watcher.Changed += new FileSystemEventHandler(OnChanged);
                    watcher.Created += new FileSystemEventHandler(OnChanged);
                    watcher.Deleted += new FileSystemEventHandler(OnChanged);
                    watcher.Renamed += new RenamedEventHandler(OnRenamed);
                    watcher.EnableRaisingEvents = true;
                    }
                    LoadingPictureBox.Visible = true;
                }
            }
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (!change)
            {
                stringBuilder.Remove(0, stringBuilder.Length);
                stringBuilder.Append(e.FullPath);
                stringBuilder.Append(" ");
                stringBuilder.Append(" < " + e.ChangeType.ToString() + " > ");
                stringBuilder.Append("  at " + DateTime.Now.ToString());
                change = true;
            }
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            if (!change)
            {
                stringBuilder.Remove(0, stringBuilder.Length);
                stringBuilder.Append(e.OldFullPath);
                stringBuilder.Append(" ");
                stringBuilder.Append(" < " + e.ChangeType.ToString() + " > ");
                stringBuilder.Append(" ");
                stringBuilder.Append("to ");
                stringBuilder.Append(e.Name);
                stringBuilder.Append("  at " + DateTime.Now.ToString());
                change = true;
                if (WatchFileRadioButton.Checked)
                {
                    watcher.Filter = e.Name;
                    watcher.Path = e.FullPath.Substring(0, e.FullPath.Length - watcher.Filter.Length);
                }
            }
        }

        private void OnChangedAndArchive(object source, FileSystemEventArgs e)
        {
            if (!change)
            {
                stringBuilder.Remove(0, stringBuilder.Length);
                stringBuilder.Append(e.FullPath);
                stringBuilder.Append(" ");
                stringBuilder.Append(" < " + e.ChangeType.ToString() + " > ");
                stringBuilder.Append(" and < Archived > ");
                stringBuilder.Append("  at " + DateTime.Now.ToString());
                ArchiveFile(selectedDirectoryInfo, selectedFileInfo);
                change = true;
            }
        }

        private void ArchiveFile(DirectoryInfo dirToArchive, FileInfo fileToArchive)
        {
            archiveDirectoryInfo = new DirectoryInfo(dirToArchive + "\\Archives");
            Directory.CreateDirectory(archiveDirectoryInfo.ToString());
            string fullPath = dirToArchive.ToString() + fileToArchive.ToString();
            FileInfo fullpathInfo = new FileInfo(fullPath);
            FileStream input = fullpathInfo.OpenRead();
            FileStream output = File.Create(
                                            archiveDirectoryInfo.FullName +
                                            @"\" +
                                            Path.GetFileNameWithoutExtension(fileToArchive.ToString()) +
                                            "_archive" +
                                            DateTime.Now.ToString("_yyyy-MM-dd-hh-mm-ss") +
                                            fileToArchive.Extension +
                                            ".gz"
                                            );
            GZipStream Compressor = new GZipStream(output, CompressionMode.Compress);
            int byteInfo = input.ReadByte();
            while (byteInfo != -1)
            {
                Compressor.WriteByte((byte)byteInfo);

                byteInfo = input.ReadByte();
            }
            Compressor.Close();
            input.Close();
            output.Close();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (WatchDirectoryRadioButton.Checked)
            {
                DialogResult resultDialog = OpenDirectoryDialog.ShowDialog();
                if (resultDialog.ToString() == "OK")
                {
                    FileToWatchTextBox.Text = OpenDirectoryDialog.SelectedPath;
                }
            }
            else
            {
                DialogResult resDialog = OpenFileDialog.ShowDialog();
                if (resDialog.ToString() == "OK")
                {
                    FileToWatchTextBox.Text = OpenFileDialog.FileName;
                }
            }
        }

        private void SaveToLogButton_Click(object sender, EventArgs e)
        {
            DialogResult resDialog = SaveFileDialog.ShowDialog();
            if (resDialog.ToString() == "OK")
            {
                FileInfo fileInfo = new FileInfo(SaveFileDialog.FileName);
                StreamWriter streamWriter = fileInfo.CreateText();
                foreach (string sItem in ListNotification.Items)
                {
                    streamWriter.WriteLine(sItem);
                }
                streamWriter.Close();
            }
        }

        private void WatchFileRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (WatchFileRadioButton.Checked == true)
            {
                SubFoldersCheckBox.Enabled = false;
                SubFoldersCheckBox.Checked = false;
                ArchiveCheckBox.Enabled = true;
            }
        }

        private void WatchDirectoryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (WatchDirectoryRadioButton.Checked == true)
            {
                SubFoldersCheckBox.Enabled = true;
                ArchiveCheckBox.Enabled = false;
            }
        }

        private void WatcherRefresh_Tick(object sender, EventArgs e)
        {
            if (change)
            {
                ListNotification.BeginUpdate();
                ListNotification.Items.Add(stringBuilder.ToString());
                ListNotification.EndUpdate();
                change = false;
            }
        }
    }
}
