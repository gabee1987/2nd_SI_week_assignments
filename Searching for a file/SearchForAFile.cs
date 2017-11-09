using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Searching_for_a_file
{
    public partial class SearchForAFile : Form
    {
        private StringBuilder m_Sb;
        private bool m_bDirty;
        private FileSystemWatcher m_Watcher;
        private bool m_bIsWatching;

        public SearchingForAfile()
        {
            InitializeComponent();
            m_Sb = new StringBuilder();
            m_bDirty = false;
            m_bIsWatching = false;
        }
    }
}
