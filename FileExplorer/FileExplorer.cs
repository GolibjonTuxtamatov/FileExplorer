using System.Diagnostics;

namespace FileExplorer
{
    public partial class FileExplorer : Form
    {
        private Stack<string> directoryHistory = new Stack<string>();
        private bool isCutOperation = false;

        public FileExplorer()
        {
            InitializeComponent();
        }

        private void FileExplorer_Load(object sender, EventArgs e)
        {
            listView.Clear();
            treeView.Nodes.Clear();
            string[] drives = Environment.GetLogicalDrives();

            foreach (string drive in drives)
            {
                DriveInfo di = new DriveInfo(drive);

                TreeNode node = new TreeNode(drive.Substring(0, 1));
                node.Tag = drive;

                if (di.IsReady == true)
                    node.Nodes.Add("...");
                this.treeView.ImageIndex = 15;
                this.treeView.Nodes.Add(node);
            }

            foreach (string drive in drives)
            {
                DriveInfo di = new DriveInfo(drive);
                ListViewItem item = new ListViewItem(drive);
                item.Tag = drive;
                item.SubItems.Add("Drive");
                item.SubItems.Add(di.TotalSize.ToString() + " bytes");
                item.SubItems.Add(Directory.GetCreationTime(drive).ToString());
                item.SubItems.Add(Directory.GetLastWriteTime(drive).ToString());
                item.ImageIndex = 15;
                listView.Items.Add(item);
            }
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    treeViewRefresh(e.Node);
                }
            }
        }

        private void listView_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem selected_item = listView.SelectedItems[0];
            FileAttributes attr = File.GetAttributes(selected_item.Tag.ToString());
            if (attr.HasFlag(FileAttributes.Directory))
            {
                listViewRefresh(selected_item.Tag.ToString());
            }
            else
            {
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo(selected_item.Tag.ToString())
                {
                    UseShellExecute = true
                };
                p.Start();
            }
        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selected_item = e.Node;
            listViewRefresh(selected_item.Tag.ToString());
        }

        private void TsUp_Click(object sender, EventArgs e)
        {
            if (directoryHistory.Count > 1)
            {
                directoryHistory.Pop();
                string previousDirectory = directoryHistory.Peek();

                listViewRefresh(previousDirectory);
            }
            else if(directoryHistory.Count == 1)
            {
                FileExplorer_Load(this,EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("No previous directory in history");
            }
        }

        private void TsPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                string filePath = Clipboard.GetText(TextDataFormat.UnicodeText);

                // Check if the file exists at the retrieved path
                if (File.Exists(filePath) && isCutOperation)
                {
                    // Perform actions with the filePath (e.g., paste or move the file)
                    // For example, you might move the file to a specific destination:
                    // string destinationPath = "YourDestinationPath";
                    // File.Move(filePath, destinationPath);
                    var fileInfo = new FileInfo(filePath);
                    string destinationPaht = directoryHistory.Peek() + "\\" + fileInfo.Name;
                    string extension = Path.GetExtension(filePath);

                    if (!string.IsNullOrEmpty(extension))
                    {
                        File.Move(filePath, destinationPaht);
                    }
                    else
                    {
                        MessageBox.Show("There is no this operation yet.");
                    }

                    isCutOperation = false;
                    string path = directoryHistory.Peek();
                    listViewRefresh(path);

                    // Display a message or perform further actions as needed
                    MessageBox.Show($"File pasted: {filePath}");
                }
                if(File.Exists(filePath) && !isCutOperation)
                {
                    // Perform actions with the filePath (e.g., paste or move the file)
                    // For example, you might move the file to a specific destination:
                    // string destinationPath = "YourDestinationPath";
                    // File.Move(filePath, destinationPath);
                    var fileInfo = new FileInfo(filePath);
                    string destinationPaht = directoryHistory.Peek() + "\\" + fileInfo.Name;
                    string extension = Path.GetExtension(filePath);

                    if (!string.IsNullOrEmpty(extension))
                    {
                        File.Copy(filePath,destinationPaht);
                    }
                    else
                    {
                        MessageBox.Show("There is no this operation yet.");
                    }

                    isCutOperation = false;
                    string path = directoryHistory.Peek();
                    listViewRefresh(path);

                    // Display a message or perform further actions as needed
                    MessageBox.Show($"File copied: {filePath}");
                }
                else
                {
                    MessageBox.Show("The file doesn't exist at the pasted path.");
                }
            }
            else
            {
                MessageBox.Show("No file path found in the clipboard.");
            }
        }

        private void TsCopy_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                string filePath = listView.SelectedItems[0].Tag.ToString();
                Clipboard.SetText(filePath, TextDataFormat.UnicodeText);
                isCutOperation = false;
            }
            else
            {
                MessageBox.Show("Please select a file to copy.");
            }
        }

        private void TsCut_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                string filePath = listView.SelectedItems[0].Tag.ToString();
                Clipboard.SetText(filePath,TextDataFormat.UnicodeText);
                isCutOperation = true;
            }
            else
            {
                MessageBox.Show("Please select a file to cut.");
            }
        }

        private void TsRefresh_Click(object sender, EventArgs e)
        {
            string path = directoryHistory.Peek();
            listViewRefresh(path);
        }

        private void TsDelete_Click(object sender, EventArgs e)
        {
            string path = directoryHistory.Peek();
            string filePath = listView.SelectedItems[0].Tag.ToString();
            var fileInfo = new FileInfo(filePath);
            string fileName = fileInfo.Name;

            var button = 
                MessageBox.Show($"Are you sure delete {fileName}?","Delete", MessageBoxButtons.YesNoCancel);

            if (button.HasFlag(DialogResult.Yes))
            {
                string extension = Path.GetExtension(filePath);

                if(!string.IsNullOrEmpty(extension))
                {
                    File.Delete(filePath);
                }
                else
                {
                    Directory.Delete(filePath,true);
                }

                listViewRefresh(path);
            }
            else
            {
                listViewRefresh(path);
            }
        }

        private void listViewRefresh(string path)
        {
            listView.Items.Clear();
            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                DirectoryInfo di = new DirectoryInfo(dir);
                if (!di.Attributes.HasFlag(FileAttributes.Hidden))
                {
                    ListViewItem item = new ListViewItem(Path.GetFileName(dir));
                    item.Tag = dir;
                    item.SubItems.Add("Folder");
                    item.SubItems.Add("");
                    item.SubItems.Add(Directory.GetCreationTime(dir).ToString());
                    item.SubItems.Add(Directory.GetLastWriteTime(dir).ToString());
                    item.ImageIndex = 14;
                    listView.Items.Add(item);
                }
            }
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                if (!fi.Attributes.HasFlag(FileAttributes.Hidden))
                {
                    string fileExtention = Path.GetExtension(file);
                    int indexImage = ChooseExtention(fileExtention);
                    ListViewItem item = new ListViewItem(Path.GetFileName(file));
                    item.Tag = file;
                    item.SubItems.Add(Path.GetExtension(file));
                    item.SubItems.Add(file.Length.ToString());
                    item.SubItems.Add(Directory.GetCreationTime(file).ToString());
                    item.SubItems.Add(Directory.GetLastWriteTime(file).ToString());
                    item.ImageIndex = indexImage;
                    listView.Items.Add(item);
                }
            }
            if (!directoryHistory.Contains(path))
            {
                directoryHistory.Push(path);
            }
        }

        private int ChooseExtention(string extention)
        {
            int index = 3;
            switch (extention)
            {
                case ".link":
                    index = 1;
                    break;

                case ".jpeg":
                    index = 2;
                    break;

                case ".jpg":
                    index = 2;
                    break;

                case ".unknown":
                    index = 3;
                    break;

                case ".mp3":
                    index = 4;
                    break;

                case ".xlsx":
                    index = 5;
                    break;

                case ".word":
                    index = 6;
                    break;

                case ".pdf":
                    index = 7;
                    break;

                case ".mp4":
                    index = 8;
                    break;

                case ".wav":
                    index = 9;
                    break;

                case ".gif":
                    index = 10;
                    break;

                case ".txt":
                    index = 11;
                    break;

                case ".pptl":
                    index = 12;
                    break;

                case ".svg":
                    index = 13;
                    break;
            }

            return index;
        }

        private void treeViewRefresh(TreeNode this_node)
        {
            this_node.Nodes.Clear();

            string[] dirs = Directory.GetDirectories(this_node.Tag.ToString());

            foreach (string dir in dirs)
            {
                DirectoryInfo di = new DirectoryInfo(dir);
                if (!di.Attributes.HasFlag(FileAttributes.Hidden))
                {
                    TreeNode node = new TreeNode(di.Name, 14, 14);
                    try
                    {
                        node.Tag = dir;
                        if (di.GetDirectories().Count() > 0)
                            node.Nodes.Add(null, "...", 14, 14);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        node.ImageIndex = 14;
                        node.SelectedImageIndex = 14;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "DirectoryLister",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this_node.Nodes.Add(node);
                    }
                }
            }
        }

    }
}