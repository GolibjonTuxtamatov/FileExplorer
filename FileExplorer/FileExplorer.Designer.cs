namespace FileExplorer
{
    partial class FileExplorer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileExplorer));
            MenuScripts = new MenuStrip();
            MScrFile = new ToolStripMenuItem();
            MScrRename_File = new ToolStripMenuItem();
            MScrDelete_File = new ToolStripMenuItem();
            MScr_Seperator_FIle = new ToolStripSeparator();
            MScrExit_File = new ToolStripMenuItem();
            MScrEdit = new ToolStripMenuItem();
            MScrCopy_Edit = new ToolStripMenuItem();
            MScrCut_Edit = new ToolStripMenuItem();
            MScrPaste_Edit = new ToolStripMenuItem();
            MScrViews = new ToolStripMenuItem();
            MScrLargeIC_Views = new ToolStripMenuItem();
            MScrSmallIC_Views = new ToolStripMenuItem();
            MScrList_Views = new ToolStripMenuItem();
            MScrDetails_Views = new ToolStripMenuItem();
            MScrHelp = new ToolStripMenuItem();
            MScrAbout_Help = new ToolStripMenuItem();
            ToolStrip = new ToolStrip();
            TsUp = new ToolStripButton();
            TsRefresh = new ToolStripButton();
            TsCopy = new ToolStripButton();
            TsCut = new ToolStripButton();
            TsPaste = new ToolStripButton();
            TsDelete = new ToolStripButton();
            TsViews = new ToolStripDropDownButton();
            TsLargeIcon_Views = new ToolStripMenuItem();
            TsSmallIcon_Views = new ToolStripMenuItem();
            TsList_Views = new ToolStripMenuItem();
            TsDetails_Views = new ToolStripMenuItem();
            SplitContainer = new SplitContainer();
            treeView = new TreeView();
            imageList = new ImageList(components);
            SplitterTreeView = new Splitter();
            listView = new ListView();
            CHeaderName = new ColumnHeader();
            CHeaderType = new ColumnHeader();
            CHeaderSize = new ColumnHeader();
            CHeaderCreatedDate = new ColumnHeader();
            CHeaderModifiedDate = new ColumnHeader();
            SpliterListView = new Splitter();
            MenuScripts.SuspendLayout();
            ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer).BeginInit();
            SplitContainer.Panel1.SuspendLayout();
            SplitContainer.Panel2.SuspendLayout();
            SplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // MenuScripts
            // 
            MenuScripts.ImageScalingSize = new Size(20, 20);
            MenuScripts.Items.AddRange(new ToolStripItem[] { MScrFile, MScrEdit, MScrViews, MScrHelp });
            MenuScripts.Location = new Point(0, 0);
            MenuScripts.Name = "MenuScripts";
            MenuScripts.Size = new Size(1259, 28);
            MenuScripts.TabIndex = 0;
            MenuScripts.Text = "MenuScript";
            // 
            // MScrFile
            // 
            MScrFile.DropDownItems.AddRange(new ToolStripItem[] { MScrRename_File, MScrDelete_File, MScr_Seperator_FIle, MScrExit_File });
            MScrFile.Name = "MScrFile";
            MScrFile.Size = new Size(46, 24);
            MScrFile.Text = "File";
            // 
            // MScrRename_File
            // 
            MScrRename_File.Name = "MScrRename_File";
            MScrRename_File.ShortcutKeys = Keys.F2;
            MScrRename_File.Size = new Size(172, 26);
            MScrRename_File.Text = "Rename";
            // 
            // MScrDelete_File
            // 
            MScrDelete_File.Name = "MScrDelete_File";
            MScrDelete_File.ShortcutKeys = Keys.Delete;
            MScrDelete_File.Size = new Size(172, 26);
            MScrDelete_File.Text = "Delete";
            // 
            // MScr_Seperator_FIle
            // 
            MScr_Seperator_FIle.Name = "MScr_Seperator_FIle";
            MScr_Seperator_FIle.Size = new Size(169, 6);
            // 
            // MScrExit_File
            // 
            MScrExit_File.Name = "MScrExit_File";
            MScrExit_File.ShortcutKeys = Keys.Control | Keys.W;
            MScrExit_File.Size = new Size(172, 26);
            MScrExit_File.Text = "Exit";
            // 
            // MScrEdit
            // 
            MScrEdit.DropDownItems.AddRange(new ToolStripItem[] { MScrCopy_Edit, MScrCut_Edit, MScrPaste_Edit });
            MScrEdit.Name = "MScrEdit";
            MScrEdit.Size = new Size(49, 24);
            MScrEdit.Text = "Edit";
            // 
            // MScrCopy_Edit
            // 
            MScrCopy_Edit.Name = "MScrCopy_Edit";
            MScrCopy_Edit.Size = new Size(177, 26);
            MScrCopy_Edit.Text = "Copy";
            // 
            // MScrCut_Edit
            // 
            MScrCut_Edit.Name = "MScrCut_Edit";
            MScrCut_Edit.ShortcutKeys = Keys.Control | Keys.X;
            MScrCut_Edit.Size = new Size(177, 26);
            MScrCut_Edit.Text = "Cut";
            // 
            // MScrPaste_Edit
            // 
            MScrPaste_Edit.Name = "MScrPaste_Edit";
            MScrPaste_Edit.ShortcutKeys = Keys.Control | Keys.V;
            MScrPaste_Edit.Size = new Size(177, 26);
            MScrPaste_Edit.Text = "Paste";
            // 
            // MScrViews
            // 
            MScrViews.DropDownItems.AddRange(new ToolStripItem[] { MScrLargeIC_Views, MScrSmallIC_Views, MScrList_Views, MScrDetails_Views });
            MScrViews.Name = "MScrViews";
            MScrViews.Size = new Size(61, 24);
            MScrViews.Text = "Views";
            // 
            // MScrLargeIC_Views
            // 
            MScrLargeIC_Views.Name = "MScrLargeIC_Views";
            MScrLargeIC_Views.Size = new Size(161, 26);
            MScrLargeIC_Views.Text = "Large icon";
            // 
            // MScrSmallIC_Views
            // 
            MScrSmallIC_Views.Name = "MScrSmallIC_Views";
            MScrSmallIC_Views.Size = new Size(161, 26);
            MScrSmallIC_Views.Text = "Small icon";
            // 
            // MScrList_Views
            // 
            MScrList_Views.Name = "MScrList_Views";
            MScrList_Views.Size = new Size(161, 26);
            MScrList_Views.Text = "List";
            // 
            // MScrDetails_Views
            // 
            MScrDetails_Views.Name = "MScrDetails_Views";
            MScrDetails_Views.Size = new Size(161, 26);
            MScrDetails_Views.Text = "Details";
            // 
            // MScrHelp
            // 
            MScrHelp.DropDownItems.AddRange(new ToolStripItem[] { MScrAbout_Help });
            MScrHelp.Name = "MScrHelp";
            MScrHelp.Size = new Size(55, 24);
            MScrHelp.Text = "Help";
            // 
            // MScrAbout_Help
            // 
            MScrAbout_Help.Name = "MScrAbout_Help";
            MScrAbout_Help.Size = new Size(133, 26);
            MScrAbout_Help.Text = "About";
            // 
            // ToolStrip
            // 
            ToolStrip.ImageScalingSize = new Size(20, 20);
            ToolStrip.Items.AddRange(new ToolStripItem[] { TsUp, TsRefresh, TsCopy, TsCut, TsPaste, TsDelete, TsViews });
            ToolStrip.Location = new Point(0, 28);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Size = new Size(1259, 27);
            ToolStrip.TabIndex = 1;
            ToolStrip.Text = "ToolStrip";
            // 
            // TsUp
            // 
            TsUp.Image = (Image)resources.GetObject("TsUp.Image");
            TsUp.ImageTransparentColor = Color.Magenta;
            TsUp.Name = "TsUp";
            TsUp.Size = new Size(52, 24);
            TsUp.Text = "Up";
            TsUp.Click += TsUp_Click;
            // 
            // TsRefresh
            // 
            TsRefresh.Image = (Image)resources.GetObject("TsRefresh.Image");
            TsRefresh.ImageTransparentColor = Color.Magenta;
            TsRefresh.Name = "TsRefresh";
            TsRefresh.Size = new Size(82, 24);
            TsRefresh.Text = "Refresh";
            TsRefresh.Click += TsRefresh_Click;
            // 
            // TsCopy
            // 
            TsCopy.Image = (Image)resources.GetObject("TsCopy.Image");
            TsCopy.ImageTransparentColor = Color.Magenta;
            TsCopy.Name = "TsCopy";
            TsCopy.Size = new Size(67, 24);
            TsCopy.Text = "Copy";
            TsCopy.Click += TsCopy_Click;
            // 
            // TsCut
            // 
            TsCut.Image = (Image)resources.GetObject("TsCut.Image");
            TsCut.ImageTransparentColor = Color.Magenta;
            TsCut.Name = "TsCut";
            TsCut.Size = new Size(55, 24);
            TsCut.Text = "Cut";
            TsCut.Click += TsCut_Click;
            // 
            // TsPaste
            // 
            TsPaste.Image = (Image)resources.GetObject("TsPaste.Image");
            TsPaste.ImageTransparentColor = Color.Magenta;
            TsPaste.Name = "TsPaste";
            TsPaste.Size = new Size(67, 24);
            TsPaste.Text = "Paste";
            TsPaste.Click += TsPaste_Click;
            // 
            // TsDelete
            // 
            TsDelete.Image = (Image)resources.GetObject("TsDelete.Image");
            TsDelete.ImageTransparentColor = Color.Magenta;
            TsDelete.Name = "TsDelete";
            TsDelete.Size = new Size(77, 24);
            TsDelete.Text = "Delete";
            TsDelete.Click += TsDelete_Click;
            // 
            // TsViews
            // 
            TsViews.DropDownItems.AddRange(new ToolStripItem[] { TsLargeIcon_Views, TsSmallIcon_Views, TsList_Views, TsDetails_Views });
            TsViews.Image = (Image)resources.GetObject("TsViews.Image");
            TsViews.ImageTransparentColor = Color.Magenta;
            TsViews.Name = "TsViews";
            TsViews.Size = new Size(81, 24);
            TsViews.Text = "Views";
            // 
            // TsLargeIcon_Views
            // 
            TsLargeIcon_Views.Name = "TsLargeIcon_Views";
            TsLargeIcon_Views.Size = new Size(161, 26);
            TsLargeIcon_Views.Text = "Large icon";
            // 
            // TsSmallIcon_Views
            // 
            TsSmallIcon_Views.Name = "TsSmallIcon_Views";
            TsSmallIcon_Views.Size = new Size(161, 26);
            TsSmallIcon_Views.Text = "Small icon";
            // 
            // TsList_Views
            // 
            TsList_Views.Name = "TsList_Views";
            TsList_Views.Size = new Size(161, 26);
            TsList_Views.Text = "List";
            // 
            // TsDetails_Views
            // 
            TsDetails_Views.Name = "TsDetails_Views";
            TsDetails_Views.Size = new Size(161, 26);
            TsDetails_Views.Text = "Details";
            // 
            // SplitContainer
            // 
            SplitContainer.BorderStyle = BorderStyle.FixedSingle;
            SplitContainer.Dock = DockStyle.Fill;
            SplitContainer.Location = new Point(0, 55);
            SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            SplitContainer.Panel1.Controls.Add(treeView);
            SplitContainer.Panel1.Controls.Add(SplitterTreeView);
            // 
            // SplitContainer.Panel2
            // 
            SplitContainer.Panel2.Controls.Add(listView);
            SplitContainer.Panel2.Controls.Add(SpliterListView);
            SplitContainer.Size = new Size(1259, 582);
            SplitContainer.SplitterDistance = 418;
            SplitContainer.TabIndex = 2;
            // 
            // treeView
            // 
            treeView.BorderStyle = BorderStyle.None;
            treeView.Dock = DockStyle.Fill;
            treeView.ImageIndex = 0;
            treeView.ImageList = imageList;
            treeView.Location = new Point(4, 0);
            treeView.Name = "treeView";
            treeView.SelectedImageIndex = 15;
            treeView.Size = new Size(412, 580);
            treeView.TabIndex = 1;
            treeView.BeforeExpand += treeView_BeforeExpand;
            treeView.NodeMouseDoubleClick += treeView_NodeMouseDoubleClick;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "folder_icon.png");
            imageList.Images.SetKeyName(1, "link.png");
            imageList.Images.SetKeyName(2, "jpeg.png");
            imageList.Images.SetKeyName(3, "unknown.png");
            imageList.Images.SetKeyName(4, "mp3.png");
            imageList.Images.SetKeyName(5, "xlsx.png");
            imageList.Images.SetKeyName(6, "word.png");
            imageList.Images.SetKeyName(7, "pdf.png");
            imageList.Images.SetKeyName(8, "mp4.png");
            imageList.Images.SetKeyName(9, "wav.png");
            imageList.Images.SetKeyName(10, "gif.png");
            imageList.Images.SetKeyName(11, "txt.png");
            imageList.Images.SetKeyName(12, "pptl.png");
            imageList.Images.SetKeyName(13, "svg.png");
            imageList.Images.SetKeyName(14, "folder.png");
            imageList.Images.SetKeyName(15, "harddisk.png");
            // 
            // SplitterTreeView
            // 
            SplitterTreeView.Location = new Point(0, 0);
            SplitterTreeView.Name = "SplitterTreeView";
            SplitterTreeView.Size = new Size(4, 580);
            SplitterTreeView.TabIndex = 0;
            SplitterTreeView.TabStop = false;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { CHeaderName, CHeaderType, CHeaderSize, CHeaderCreatedDate, CHeaderModifiedDate });
            listView.Dock = DockStyle.Fill;
            listView.LargeImageList = imageList;
            listView.Location = new Point(4, 0);
            listView.Name = "listView";
            listView.Size = new Size(831, 580);
            listView.SmallImageList = imageList;
            listView.TabIndex = 1;
            listView.UseCompatibleStateImageBehavior = false;
            listView.ItemActivate += listView_ItemActivate;
            // 
            // CHeaderName
            // 
            CHeaderName.Text = "Name";
            CHeaderName.Width = 150;
            // 
            // CHeaderType
            // 
            CHeaderType.Text = "Type";
            // 
            // CHeaderSize
            // 
            CHeaderSize.Text = "Size";
            // 
            // CHeaderCreatedDate
            // 
            CHeaderCreatedDate.Text = "Created Date";
            CHeaderCreatedDate.Width = 120;
            // 
            // CHeaderModifiedDate
            // 
            CHeaderModifiedDate.Text = "Modified Date";
            CHeaderModifiedDate.Width = 120;
            // 
            // SpliterListView
            // 
            SpliterListView.Location = new Point(0, 0);
            SpliterListView.Name = "SpliterListView";
            SpliterListView.Size = new Size(4, 580);
            SpliterListView.TabIndex = 0;
            SpliterListView.TabStop = false;
            // 
            // FileExplorer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 637);
            Controls.Add(SplitContainer);
            Controls.Add(ToolStrip);
            Controls.Add(MenuScripts);
            MainMenuStrip = MenuScripts;
            Name = "FileExplorer";
            Text = "FileExplorer";
            Load += FileExplorer_Load;
            MenuScripts.ResumeLayout(false);
            MenuScripts.PerformLayout();
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            SplitContainer.Panel1.ResumeLayout(false);
            SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer).EndInit();
            SplitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuScripts;
        private ToolStripMenuItem MScrFile;
        private ToolStripMenuItem MScrEdit;
        private ToolStripMenuItem MScrViews;
        private ToolStripMenuItem MScrHelp;
        private ToolStripMenuItem MScrRename_File;
        private ToolStripMenuItem MScrDelete_File;
        private ToolStripMenuItem MScrCopy_Edit;
        private ToolStripMenuItem MScrCut_Edit;
        private ToolStripMenuItem MScrPaste_Edit;
        private ToolStripMenuItem MScrLargeIC_Views;
        private ToolStripSeparator MScr_Seperator_FIle;
        private ToolStripMenuItem MScrExit_File;
        private ToolStripMenuItem MScrSmallIC_Views;
        private ToolStripMenuItem MScrList_Views;
        private ToolStripMenuItem MScrDetails_Views;
        private ToolStripMenuItem MScrAbout_Help;
        private ToolStrip ToolStrip;
        private ToolStripButton TsUp;
        private ToolStripButton TsRefresh;
        private ToolStripButton TsCopy;
        private ToolStripButton TsCut;
        private ToolStripButton TsPaste;
        private ToolStripButton TsDelete;
        private ToolStripDropDownButton TsViews;
        private ToolStripMenuItem TsLargeIcon_Views;
        private ToolStripMenuItem TsSmallIcon_Views;
        private ToolStripMenuItem TsList_Views;
        private ToolStripMenuItem TsDetails_Views;
        private SplitContainer SplitContainer;
        private Splitter SpliterListView;
        private Splitter SplitterTreeView;
        private TreeView treeView;
        private ListView listView;
        private ColumnHeader CHeaderName;
        private ColumnHeader CHeaderType;
        private ColumnHeader CHeaderSize;
        private ColumnHeader CHeaderCreatedDate;
        private ColumnHeader CHeaderModifiedDate;
        private ImageList imageList;
    }
}