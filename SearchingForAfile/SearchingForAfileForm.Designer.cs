namespace SearchingForAfile
{
    partial class SearchingForAfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchingForAfileForm));
            this.SelectModeGroupBox = new System.Windows.Forms.GroupBox();
            this.SubFoldersCheckBox = new System.Windows.Forms.CheckBox();
            this.WatchDirectoryRadioButton = new System.Windows.Forms.RadioButton();
            this.WatchFileRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.FileToWatchTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.StartWatchButton = new System.Windows.Forms.Button();
            this.ChangeNotificationLabel = new System.Windows.Forms.Label();
            this.ListNotification = new System.Windows.Forms.ListBox();
            this.SaveToLogButton = new System.Windows.Forms.Button();
            this.OpenDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.WatcherRefresh = new System.Windows.Forms.Timer(this.components);
            this.ArchiveCheckBox = new System.Windows.Forms.CheckBox();
            this.LoadingPictureBox = new System.Windows.Forms.PictureBox();
            this.SelectModeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectModeGroupBox
            // 
            this.SelectModeGroupBox.Controls.Add(this.SubFoldersCheckBox);
            this.SelectModeGroupBox.Controls.Add(this.WatchDirectoryRadioButton);
            this.SelectModeGroupBox.Controls.Add(this.WatchFileRadioButton);
            this.SelectModeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SelectModeGroupBox.Name = "SelectModeGroupBox";
            this.SelectModeGroupBox.Size = new System.Drawing.Size(365, 68);
            this.SelectModeGroupBox.TabIndex = 0;
            this.SelectModeGroupBox.TabStop = false;
            this.SelectModeGroupBox.Text = "Watch Mode";
            // 
            // SubFoldersCheckBox
            // 
            this.SubFoldersCheckBox.AutoSize = true;
            this.SubFoldersCheckBox.Location = new System.Drawing.Point(245, 45);
            this.SubFoldersCheckBox.Name = "SubFoldersCheckBox";
            this.SubFoldersCheckBox.Size = new System.Drawing.Size(114, 17);
            this.SubFoldersCheckBox.TabIndex = 1;
            this.SubFoldersCheckBox.Text = "Include Subfolders";
            this.SubFoldersCheckBox.UseVisualStyleBackColor = true;
            // 
            // WatchDirectoryRadioButton
            // 
            this.WatchDirectoryRadioButton.AutoSize = true;
            this.WatchDirectoryRadioButton.Location = new System.Drawing.Point(6, 45);
            this.WatchDirectoryRadioButton.Name = "WatchDirectoryRadioButton";
            this.WatchDirectoryRadioButton.Size = new System.Drawing.Size(102, 17);
            this.WatchDirectoryRadioButton.TabIndex = 1;
            this.WatchDirectoryRadioButton.TabStop = true;
            this.WatchDirectoryRadioButton.Text = "Watch Directory";
            this.WatchDirectoryRadioButton.UseVisualStyleBackColor = true;
            this.WatchDirectoryRadioButton.CheckedChanged += new System.EventHandler(this.WatchDirectoryRadioButton_CheckedChanged);
            // 
            // WatchFileRadioButton
            // 
            this.WatchFileRadioButton.AutoSize = true;
            this.WatchFileRadioButton.Location = new System.Drawing.Point(6, 19);
            this.WatchFileRadioButton.Name = "WatchFileRadioButton";
            this.WatchFileRadioButton.Size = new System.Drawing.Size(76, 17);
            this.WatchFileRadioButton.TabIndex = 1;
            this.WatchFileRadioButton.TabStop = true;
            this.WatchFileRadioButton.Text = "Watch File";
            this.WatchFileRadioButton.UseVisualStyleBackColor = true;
            this.WatchFileRadioButton.CheckedChanged += new System.EventHandler(this.WatchFileRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select File/Directory";
            // 
            // FileToWatchTextBox
            // 
            this.FileToWatchTextBox.Location = new System.Drawing.Point(395, 31);
            this.FileToWatchTextBox.Name = "FileToWatchTextBox";
            this.FileToWatchTextBox.Size = new System.Drawing.Size(440, 20);
            this.FileToWatchTextBox.TabIndex = 2;
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BrowseButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BrowseButton.Location = new System.Drawing.Point(760, 57);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // StartWatchButton
            // 
            this.StartWatchButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StartWatchButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StartWatchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartWatchButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartWatchButton.Location = new System.Drawing.Point(12, 86);
            this.StartWatchButton.Name = "StartWatchButton";
            this.StartWatchButton.Size = new System.Drawing.Size(130, 30);
            this.StartWatchButton.TabIndex = 4;
            this.StartWatchButton.Text = "Start Watching";
            this.StartWatchButton.UseVisualStyleBackColor = false;
            this.StartWatchButton.Click += new System.EventHandler(this.StartWatchButton_Click);
            // 
            // ChangeNotificationLabel
            // 
            this.ChangeNotificationLabel.AutoSize = true;
            this.ChangeNotificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeNotificationLabel.Location = new System.Drawing.Point(15, 133);
            this.ChangeNotificationLabel.Name = "ChangeNotificationLabel";
            this.ChangeNotificationLabel.Size = new System.Drawing.Size(125, 13);
            this.ChangeNotificationLabel.TabIndex = 5;
            this.ChangeNotificationLabel.Text = "Change Notifications";
            // 
            // ListNotification
            // 
            this.ListNotification.FormattingEnabled = true;
            this.ListNotification.HorizontalScrollbar = true;
            this.ListNotification.Location = new System.Drawing.Point(12, 161);
            this.ListNotification.Name = "ListNotification";
            this.ListNotification.Size = new System.Drawing.Size(823, 251);
            this.ListNotification.TabIndex = 6;
            // 
            // SaveToLogButton
            // 
            this.SaveToLogButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SaveToLogButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaveToLogButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveToLogButton.Location = new System.Drawing.Point(719, 426);
            this.SaveToLogButton.Name = "SaveToLogButton";
            this.SaveToLogButton.Size = new System.Drawing.Size(116, 23);
            this.SaveToLogButton.TabIndex = 7;
            this.SaveToLogButton.Text = "Save Log to File";
            this.SaveToLogButton.UseVisualStyleBackColor = false;
            this.SaveToLogButton.Click += new System.EventHandler(this.SaveToLogButton_Click);
            // 
            // OpenDirectoryDialog
            // 
            this.OpenDirectoryDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "log";
            this.SaveFileDialog.Filter = "LogFiles|*.log";
            // 
            // WatcherRefresh
            // 
            this.WatcherRefresh.Enabled = true;
            this.WatcherRefresh.Tick += new System.EventHandler(this.WatcherRefresh_Tick);
            // 
            // ArchiveCheckBox
            // 
            this.ArchiveCheckBox.AutoSize = true;
            this.ArchiveCheckBox.Location = new System.Drawing.Point(148, 99);
            this.ArchiveCheckBox.Name = "ArchiveCheckBox";
            this.ArchiveCheckBox.Size = new System.Drawing.Size(136, 17);
            this.ArchiveCheckBox.TabIndex = 8;
            this.ArchiveCheckBox.Text = "Archive File on Change";
            this.ArchiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoadingPictureBox
            // 
            this.LoadingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LoadingPictureBox.Image")));
            this.LoadingPictureBox.Location = new System.Drawing.Point(12, 149);
            this.LoadingPictureBox.Name = "LoadingPictureBox";
            this.LoadingPictureBox.Size = new System.Drawing.Size(823, 12);
            this.LoadingPictureBox.TabIndex = 9;
            this.LoadingPictureBox.TabStop = false;
            this.LoadingPictureBox.Visible = false;
            // 
            // SearchingForAfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 465);
            this.Controls.Add(this.LoadingPictureBox);
            this.Controls.Add(this.ArchiveCheckBox);
            this.Controls.Add(this.SaveToLogButton);
            this.Controls.Add(this.ListNotification);
            this.Controls.Add(this.ChangeNotificationLabel);
            this.Controls.Add(this.StartWatchButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.FileToWatchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectModeGroupBox);
            this.Name = "SearchingForAfileForm";
            this.Text = "SearchingForAfile";
            this.SelectModeGroupBox.ResumeLayout(false);
            this.SelectModeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SelectModeGroupBox;
        private System.Windows.Forms.CheckBox SubFoldersCheckBox;
        private System.Windows.Forms.RadioButton WatchDirectoryRadioButton;
        private System.Windows.Forms.RadioButton WatchFileRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileToWatchTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button StartWatchButton;
        private System.Windows.Forms.Label ChangeNotificationLabel;
        private System.Windows.Forms.ListBox ListNotification;
        private System.Windows.Forms.Button SaveToLogButton;
        private System.Windows.Forms.FolderBrowserDialog OpenDirectoryDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Timer EditNotify;
        private System.Windows.Forms.Timer WatcherRefresh;
        private System.Windows.Forms.CheckBox ArchiveCheckBox;
        private System.Windows.Forms.PictureBox LoadingPictureBox;
    }
}

