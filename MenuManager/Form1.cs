using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuManager
{
    public partial class Form1 : Form
    {
        private List<string> fileList = new List<string>();

        private List<String> iterFiles(String filePath, List<String> filePaths)
        {
            if (filePath.EndsWith(@"\程序"))
            {
                return filePaths;
            }

            string[] fileSystemEntries = Directory.GetFileSystemEntries(filePath);
            foreach (string fileSystemEntry in fileSystemEntries)
            {
                if (Directory.Exists(fileSystemEntry))
                {
                    iterFiles(fileSystemEntry, filePaths);
                }
                else
                {
                    filePaths.Add(fileSystemEntry);
                }
            }

            return filePaths;
        }

        public Form1()
        {
            InitializeComponent();
            const int colunmLength = 3;
            ColumnHeader columnHeader = new ColumnHeader();
            columnHeader.Text = "开始菜单";
            columnHeader.Width = startMenuListView.Size.Width / colunmLength;
            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "路径";
            columnHeader2.Width = startMenuListView.Size.Width / colunmLength;
            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader3.Text = "指向";
            columnHeader3.Width = startMenuListView.Size.Width / colunmLength;
            startMenuListView.Columns.Add(columnHeader);
            startMenuListView.Columns.Add(columnHeader2);
            startMenuListView.Columns.Add(columnHeader3);
            calcList();
        }

        private void calcList()
        {
            iterFiles(@"c:\ProgramData\Microsoft\Windows\Start Menu\", fileList);
            iterFiles(
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    @"Microsoft\Windows\Start Menu\Programs"), fileList);
            reRender(fileList);
        }

        public static string GetLnkTarget(string lnkPath)
        {
            try
            {
                /*if (!lnkPath.EndsWith(".lnk"))
                {
                    return null;
                }*/

                var shl = new Shell32.Shell(); // Move this to class scope
                lnkPath = System.IO.Path.GetFullPath(lnkPath);
                var dir = shl.NameSpace(System.IO.Path.GetDirectoryName(lnkPath));
                var itm = dir.Items().Item(System.IO.Path.GetFileName(lnkPath));
                var lnk = (Shell32.ShellLinkObject) itm.GetLink;
                return lnk.Target.Path;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private void reRender(IEnumerable<string> fileList)
        {
            startMenuListView.BeginUpdate();
            startMenuListView.Items.Clear();
            startMenuListView.SmallImageList = null;
            ImageList imageList = new ImageList();
            int i = 0;
            foreach (string s in fileList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = Path.GetFileName(s);
                ListViewItem.ListViewSubItem subItemLnkPath = new ListViewItem.ListViewSubItem();
                subItemLnkPath.Text = s;
                ListViewItem.ListViewSubItem subItemRealPath = new ListViewItem.ListViewSubItem();
                if (File.Exists(s))
                {
                    subItemRealPath.Text = GetLnkTarget(s);
                }
                Icon fileIcon;
                if (Directory.Exists(s))
                {
                    fileIcon = SystemIcon.GetFolderIcon(true);
                }
                else
                {
                    fileIcon = SystemIcon.GetFileIcon(s, true);
                }

                imageList.Images.Add(fileIcon);
                listViewItem.SubItems.Add(subItemLnkPath);
                listViewItem.SubItems.Add(subItemRealPath);
                listViewItem.ImageIndex = i;
                startMenuListView.Items.Add(listViewItem);
                i++;
            }

            startMenuListView.SmallImageList = imageList;
            startMenuListView.EndUpdate();
        }

        private void listMenu_Popup(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void startMenuListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (startMenuListView.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void startMenuFilterInput_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void startMenuFilterInput_TextChanged(object sender, EventArgs e)
        {
            reRender(fileList.Where(f => f.ToLower().Contains(startMenuFilterInput.Text.ToLower().Trim())));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //open folder 
            string path = startMenuListView.SelectedItems[0].SubItems[1].Text;
            String dir = Path.GetDirectoryName(path);
            System.Diagnostics.Process.Start("explorer.exe", dir); 
        }
    }
}