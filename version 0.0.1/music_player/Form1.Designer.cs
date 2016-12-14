namespace music_player
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wmplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.musicnameLbl = new System.Windows.Forms.Label();
            this.timeleftLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.start_pauseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.volumLbl = new System.Windows.Forms.Label();
            this.openvolumeBtn = new System.Windows.Forms.Button();
            this.mute_unmutePic = new System.Windows.Forms.PictureBox();
            this.time_Track = new System.Windows.Forms.TrackBar();
            this.volumeTrackbar = new System.Windows.Forms.TrackBar();
            this.exitplaylistBtn = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPlayListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showplaylistItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPlayListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.shuffleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playpauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muteunmuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.show_unshowtimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playlistBox = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.volume_visibleTImer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wmplayer)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mute_unmutePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_Track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackbar)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wmplayer
            // 
            this.wmplayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmplayer.Enabled = true;
            this.wmplayer.Location = new System.Drawing.Point(-15, -10);
            this.wmplayer.Name = "wmplayer";
            this.wmplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmplayer.OcxState")));
            this.wmplayer.Size = new System.Drawing.Size(352, 337);
            this.wmplayer.TabIndex = 0;
            this.wmplayer.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.wmplayer_MouseMoveEvent);
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.Color.Transparent;
            this.controlPanel.Controls.Add(this.musicnameLbl);
            this.controlPanel.Controls.Add(this.timeleftLbl);
            this.controlPanel.Controls.Add(this.timeLbl);
            this.controlPanel.Controls.Add(this.stopBtn);
            this.controlPanel.Controls.Add(this.prevBtn);
            this.controlPanel.Controls.Add(this.nextBtn);
            this.controlPanel.Controls.Add(this.start_pauseBtn);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.volumLbl);
            this.controlPanel.Controls.Add(this.openvolumeBtn);
            this.controlPanel.Controls.Add(this.mute_unmutePic);
            this.controlPanel.Controls.Add(this.time_Track);
            this.controlPanel.Controls.Add(this.volumeTrackbar);
            this.controlPanel.Location = new System.Drawing.Point(-8, 178);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(336, 140);
            this.controlPanel.TabIndex = 1;
            this.controlPanel.Visible = false;
            this.controlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // musicnameLbl
            // 
            this.musicnameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicnameLbl.BackColor = System.Drawing.Color.Transparent;
            this.musicnameLbl.Location = new System.Drawing.Point(13, 65);
            this.musicnameLbl.Name = "musicnameLbl";
            this.musicnameLbl.Size = new System.Drawing.Size(248, 23);
            this.musicnameLbl.TabIndex = 1;
            this.musicnameLbl.Text = "name music";
            this.musicnameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.musicnameLbl.Visible = false;
            this.musicnameLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // timeleftLbl
            // 
            this.timeleftLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeleftLbl.AutoSize = true;
            this.timeleftLbl.Location = new System.Drawing.Point(13, 36);
            this.timeleftLbl.Name = "timeleftLbl";
            this.timeleftLbl.Size = new System.Drawing.Size(34, 13);
            this.timeleftLbl.TabIndex = 13;
            this.timeleftLbl.Text = "00:00";
            this.timeleftLbl.Visible = false;
            // 
            // timeLbl
            // 
            this.timeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(290, 35);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(34, 13);
            this.timeLbl.TabIndex = 11;
            this.timeLbl.Text = "00:00";
            this.timeLbl.Visible = false;
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopBtn.Enabled = false;
            this.stopBtn.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.stopBtn.Location = new System.Drawing.Point(31, 98);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(45, 45);
            this.stopBtn.TabIndex = 9;
            this.stopBtn.Text = "g";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            this.stopBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // prevBtn
            // 
            this.prevBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prevBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.prevBtn.Enabled = false;
            this.prevBtn.Font = new System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.prevBtn.Location = new System.Drawing.Point(95, 96);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(45, 45);
            this.prevBtn.TabIndex = 8;
            this.prevBtn.Text = "7";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            this.prevBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.Enabled = false;
            this.nextBtn.Font = new System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.nextBtn.Location = new System.Drawing.Point(247, 96);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(45, 45);
            this.nextBtn.TabIndex = 7;
            this.nextBtn.Text = "8";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            this.nextBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // start_pauseBtn
            // 
            this.start_pauseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start_pauseBtn.Enabled = false;
            this.start_pauseBtn.Font = new System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.start_pauseBtn.Location = new System.Drawing.Point(171, 96);
            this.start_pauseBtn.Name = "start_pauseBtn";
            this.start_pauseBtn.Size = new System.Drawing.Size(45, 45);
            this.start_pauseBtn.TabIndex = 6;
            this.start_pauseBtn.Text = "4";
            this.start_pauseBtn.UseVisualStyleBackColor = true;
            this.start_pauseBtn.Click += new System.EventHandler(this.start_pauseBtn_Click);
            this.start_pauseBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(211, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "u";
            this.label2.Visible = false;
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // volumLbl
            // 
            this.volumLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumLbl.Location = new System.Drawing.Point(171, 56);
            this.volumLbl.Name = "volumLbl";
            this.volumLbl.Size = new System.Drawing.Size(34, 14);
            this.volumLbl.TabIndex = 4;
            this.volumLbl.Text = "100";
            this.volumLbl.Visible = false;
            this.volumLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // openvolumeBtn
            // 
            this.openvolumeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openvolumeBtn.BackColor = System.Drawing.Color.Transparent;
            this.openvolumeBtn.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.openvolumeBtn.Location = new System.Drawing.Point(293, 65);
            this.openvolumeBtn.Name = "openvolumeBtn";
            this.openvolumeBtn.Size = new System.Drawing.Size(15, 17);
            this.openvolumeBtn.TabIndex = 2;
            this.openvolumeBtn.Text = "p";
            this.openvolumeBtn.UseVisualStyleBackColor = false;
            this.openvolumeBtn.Click += new System.EventHandler(this.openvolumeBtn_Click);
            this.openvolumeBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // mute_unmutePic
            // 
            this.mute_unmutePic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mute_unmutePic.Image = ((System.Drawing.Image)(resources.GetObject("mute_unmutePic.Image")));
            this.mute_unmutePic.Location = new System.Drawing.Point(267, 62);
            this.mute_unmutePic.Name = "mute_unmutePic";
            this.mute_unmutePic.Size = new System.Drawing.Size(20, 20);
            this.mute_unmutePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mute_unmutePic.TabIndex = 1;
            this.mute_unmutePic.TabStop = false;
            this.mute_unmutePic.Click += new System.EventHandler(this.mute_unmutePic_Click);
            this.mute_unmutePic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // time_Track
            // 
            this.time_Track.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.time_Track.Location = new System.Drawing.Point(3, 4);
            this.time_Track.Maximum = 0;
            this.time_Track.Name = "time_Track";
            this.time_Track.Size = new System.Drawing.Size(333, 45);
            this.time_Track.TabIndex = 0;
            this.time_Track.Scroll += new System.EventHandler(this.time_Track_Scroll);
            this.time_Track.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // volumeTrackbar
            // 
            this.volumeTrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeTrackbar.Location = new System.Drawing.Point(232, 51);
            this.volumeTrackbar.Maximum = 100;
            this.volumeTrackbar.Name = "volumeTrackbar";
            this.volumeTrackbar.Size = new System.Drawing.Size(84, 45);
            this.volumeTrackbar.TabIndex = 3;
            this.volumeTrackbar.Visible = false;
            this.volumeTrackbar.Scroll += new System.EventHandler(this.volumeTrackbar_Scroll);
            this.volumeTrackbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.volumeTrackbar_MouseMove);
            // 
            // exitplaylistBtn
            // 
            this.exitplaylistBtn.Location = new System.Drawing.Point(218, 153);
            this.exitplaylistBtn.Name = "exitplaylistBtn";
            this.exitplaylistBtn.Size = new System.Drawing.Size(82, 23);
            this.exitplaylistBtn.TabIndex = 4;
            this.exitplaylistBtn.Text = "close play list";
            this.exitplaylistBtn.UseVisualStyleBackColor = true;
            this.exitplaylistBtn.Visible = false;
            this.exitplaylistBtn.Click += new System.EventHandler(this.exitplaylistBtn_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.CausesValidation = false;
            this.menuPanel.Controls.Add(this.menuStrip1);
            this.menuPanel.Location = new System.Drawing.Point(-5, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(333, 31);
            this.menuPanel.TabIndex = 2;
            this.menuPanel.Visible = false;
            this.menuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(144, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPlayListToolStripMenuItem,
            this.showplaylistItem,
            this.clearPlayListToolStripMenuItem,
            this.toolStripMenuItem1,
            this.shuffleToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.prevToolStripMenuItem,
            this.playpauseToolStripMenuItem,
            this.muteunmuteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "menu";
            this.menuToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // openPlayListToolStripMenuItem
            // 
            this.openPlayListToolStripMenuItem.Name = "openPlayListToolStripMenuItem";
            this.openPlayListToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.openPlayListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openPlayListToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.openPlayListToolStripMenuItem.Text = "open play list";
            this.openPlayListToolStripMenuItem.Click += new System.EventHandler(this.openPlayListToolStripMenuItem_Click);
            this.openPlayListToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // showplaylistItem
            // 
            this.showplaylistItem.Enabled = false;
            this.showplaylistItem.Name = "showplaylistItem";
            this.showplaylistItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.showplaylistItem.Size = new System.Drawing.Size(208, 22);
            this.showplaylistItem.Text = "show play list";
            this.showplaylistItem.Click += new System.EventHandler(this.showplaylistItem_Click);
            this.showplaylistItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // clearPlayListToolStripMenuItem
            // 
            this.clearPlayListToolStripMenuItem.Enabled = false;
            this.clearPlayListToolStripMenuItem.Name = "clearPlayListToolStripMenuItem";
            this.clearPlayListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.clearPlayListToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.clearPlayListToolStripMenuItem.Text = "clear play list";
            this.clearPlayListToolStripMenuItem.Click += new System.EventHandler(this.clearPlayListToolStripMenuItem_Click);
            this.clearPlayListToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 6);
            this.toolStripMenuItem1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // shuffleToolStripMenuItem
            // 
            this.shuffleToolStripMenuItem.Checked = true;
            this.shuffleToolStripMenuItem.CheckOnClick = true;
            this.shuffleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shuffleToolStripMenuItem.Name = "shuffleToolStripMenuItem";
            this.shuffleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.shuffleToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.shuffleToolStripMenuItem.Text = "shuffle";
            this.shuffleToolStripMenuItem.Click += new System.EventHandler(this.shuffleToolStripMenuItem_Click);
            this.shuffleToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Enabled = false;
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.nextToolStripMenuItem.Text = "next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextBtn_Click);
            this.nextToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // prevToolStripMenuItem
            // 
            this.prevToolStripMenuItem.Enabled = false;
            this.prevToolStripMenuItem.Name = "prevToolStripMenuItem";
            this.prevToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.prevToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.prevToolStripMenuItem.Text = "prev";
            this.prevToolStripMenuItem.Click += new System.EventHandler(this.prevBtn_Click);
            this.prevToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // playpauseToolStripMenuItem
            // 
            this.playpauseToolStripMenuItem.Enabled = false;
            this.playpauseToolStripMenuItem.Name = "playpauseToolStripMenuItem";
            this.playpauseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.playpauseToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.playpauseToolStripMenuItem.Text = "play/pause";
            this.playpauseToolStripMenuItem.Click += new System.EventHandler(this.start_pauseBtn_Click);
            this.playpauseToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // muteunmuteToolStripMenuItem
            // 
            this.muteunmuteToolStripMenuItem.Name = "muteunmuteToolStripMenuItem";
            this.muteunmuteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.muteunmuteToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.muteunmuteToolStripMenuItem.Text = "mute/unmute";
            this.muteunmuteToolStripMenuItem.Click += new System.EventHandler(this.mute_unmutePic_Click);
            this.muteunmuteToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(205, 6);
            this.toolStripMenuItem2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenuItem4.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItem4.Text = "فارسی";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.exitToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // show_unshowtimer
            // 
            this.show_unshowtimer.Interval = 2300;
            this.show_unshowtimer.Tick += new System.EventHandler(this.show_unshowtimer_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playlistBox
            // 
            this.playlistBox.FormattingEnabled = true;
            this.playlistBox.Location = new System.Drawing.Point(-8, 28);
            this.playlistBox.Name = "playlistBox";
            this.playlistBox.Size = new System.Drawing.Size(345, 173);
            this.playlistBox.TabIndex = 3;
            this.playlistBox.Visible = false;
            this.playlistBox.SelectedIndexChanged += new System.EventHandler(this.playlistBox_SelectedIndexChanged);
            // 
            // volume_visibleTImer
            // 
            this.volume_visibleTImer.Interval = 2300;
            this.volume_visibleTImer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 318);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.wmplayer);
            this.Controls.Add(this.playlistBox);
            this.Controls.Add(this.exitplaylistBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ahp music player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.wmplayer)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mute_unmutePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_Track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackbar)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmplayer;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.TrackBar time_Track;
        private System.Windows.Forms.PictureBox mute_unmutePic;
        private System.Windows.Forms.Button openvolumeBtn;
        private System.Windows.Forms.Button start_pauseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label volumLbl;
        private System.Windows.Forms.TrackBar volumeTrackbar;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label musicnameLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPlayListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearPlayListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shuffleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playpauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muteunmuteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer show_unshowtimer;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button exitplaylistBtn;
        private System.Windows.Forms.ListBox playlistBox;
        private System.Windows.Forms.ToolStripMenuItem showplaylistItem;
        private System.Windows.Forms.Label timeleftLbl;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer volume_visibleTImer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}

