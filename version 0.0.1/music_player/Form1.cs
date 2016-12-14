using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace music_player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] p;
        public static string lang = "";
        private void tracktime(int timer,int max)
        {
            time_Track.Maximum = max;
            time_Track.Value = timer;
            musicnameLbl.Text = wmplayer.currentMedia.name;
            musicnameLbl.Visible = true;
            timeLbl.Text = wmplayer.currentMedia.durationString;
            timeleftLbl.Text = wmplayer.Ctlcontrols.currentPositionString;
        }

        private void pan(bool v = true)
        {
                controlPanel.Visible = v;
                menuPanel.Visible = v;
                if(v==false)
                    show_unshowtimer.Enabled = false;
        }

        private void volumvis(bool v = true)
        {
            volumeTrackbar.Visible = v;
            volume_visibleTImer.Enabled = v;
            if (v==false)
            {
                volumLbl.Visible = false;
                label2.Visible = false;
                volumeTrackbar.SendToBack();
                mute_unmutePic.Visible = true;
                openvolumeBtn.Visible = true;
            }
            else
            {
                volumeTrackbar.BringToFront();
                mute_unmutePic.Visible = false;
                openvolumeBtn.Visible = false;
            }
        }

        private void showplaylist(bool v = true)
        {
            playlistBox.Visible = v;
            exitplaylistBtn.Visible = v;
            if (v==true)
            {
                playlistBox.BringToFront();
                exitplaylistBtn.BringToFront();
            }
            else
            {
                playlistBox.SendToBack();
                exitplaylistBtn.SendToBack();
            }
        }

        private void enable_disablebtn(bool v=true)
        {
            showplaylistItem.Enabled = v;
            clearPlayListToolStripMenuItem.Enabled = v;
            playpauseToolStripMenuItem.Enabled = v;
            start_pauseBtn.Enabled = v;
            stopBtn.Enabled = v;  
            if (wmplayer.currentPlaylist.count > 1)
            {
                nextBtn.Enabled = true;
                prevBtn.Enabled = true;
                nextToolStripMenuItem.Enabled = true;
                prevToolStripMenuItem.Enabled = true;
            }
            else
            {
                nextBtn.Enabled = false;
                prevBtn.Enabled = false;
                nextToolStripMenuItem.Enabled = false;
                prevToolStripMenuItem.Enabled = false;
            }
        }

        private void additem(string filename)
        {
            wmplayer.currentPlaylist.appendItem(wmplayer.newMedia(filename));
            play();
            playlistBox.Items.Add(filename);
            enable_disablebtn(); 
        }

        private void play()
        {
            wmplayer.Ctlcontrols.play();
            tracktime((int)wmplayer.Ctlcontrols.currentPosition, (int)wmplayer.currentMedia.duration);
            timer1.Enabled = true;
            timeLbl.Text = wmplayer.currentMedia.durationString;
            timeleftLbl.Text = wmplayer.Ctlcontrols.currentPositionString;
            start_pauseBtn.Text = ";";
            timeLbl.Visible = true;
            timeleftLbl.Visible = true;
        }

        private void farsi()
        {
            menuToolStripMenuItem.Text = "منو";
            openPlayListToolStripMenuItem.Text = "انتخاب اهنگ";
            showplaylistItem.Text = "لیست پخش";
            clearPlayListToolStripMenuItem.Text = "پاک کردن لیست پخش";
            shuffleToolStripMenuItem.Text = "پخش تصادفی";
            nextToolStripMenuItem.Text = "بعدی";
            prevToolStripMenuItem.Text = "قبلی";
            playpauseToolStripMenuItem.Text = "شروع/توقف";
            muteunmuteToolStripMenuItem.Text = "قطع/وصل صدا";
            toolStripMenuItem4.Text = "english";
            exitToolStripMenuItem.Text = "خروج";
            exitplaylistBtn.Text = "خارج شدن از لیست";
            this.Text = "پخش کننده موسیقی ای اچ پی";
            lang = "fa";
        }

        private void english()
        {
            menuToolStripMenuItem.Text = "menu";
            openPlayListToolStripMenuItem.Text = "open playlist";
            showplaylistItem.Text = "show playlist";
            clearPlayListToolStripMenuItem.Text = "clear playlist";
            shuffleToolStripMenuItem.Text = "shuffle";
            nextToolStripMenuItem.Text = "next";
            prevToolStripMenuItem.Text = "prev";
            playpauseToolStripMenuItem.Text = "play/pause";
            muteunmuteToolStripMenuItem.Text = "mute/unmute";
            toolStripMenuItem4.Text = "فارسی";
            exitToolStripMenuItem.Text = "exit";
            exitplaylistBtn.Text = "exit from list";
            lang = "en";
        }

        private void shuffle()
        {
            if (shuffleToolStripMenuItem.Checked)
            {
                wmplayer.settings.setMode("shuffle", true);
                shuffleToolStripMenuItem.Checked = true;
            }
            else
            {
                wmplayer.settings.setMode("shuffle", false);
                shuffleToolStripMenuItem.Checked = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //set language
            try
            {
                var l= Registry.GetValue(@"HKEY_CURRENT_USER\ahpmpskin\lang", "langform","");
                if (l.ToString()=="farsi") 
                    farsi();
                else if (l.ToString()=="english")

                    english();
            }
            catch
            {
              english();
            }
            wmplayer.uiMode = "none";
            GraphicsPath mypath = new GraphicsPath();
            mypath.AddEllipse(6, 6, 32, 32);
            Region mybuttonregion = new Region(mypath);
            start_pauseBtn.Region = mybuttonregion;
            nextBtn.Region = mybuttonregion;
            prevBtn.Region = mybuttonregion;
            stopBtn.Region = mybuttonregion;
            volumeTrackbar.Value = wmplayer.settings.volume;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            shuffle();
            controlPanel.BackColor=Color.Transparent;
            menuPanel.BackColor = Color.Transparent;
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (wmplayer.currentPlaylist.count>1)
            {
                wmplayer.Ctlcontrols.previous();
                tracktime(0,(int)wmplayer.currentMedia.duration);
            }
            else
            {
                MessageBox.Show("play list is empty", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openPlayListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "MP3 Files|*.mp3";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                p = openFileDialog1.FileNames;
                foreach (string filename in openFileDialog1.FileNames)
                {
                    additem(filename);
                }
            }
        }

        private void show_unshowtimer_Tick(object sender, EventArgs e)
        {
            if (controlPanel.Visible == true)
            {
                pan(false);
            }
        }
        private void start_pauseBtn_Click(object sender, EventArgs e)
        {
            if (start_pauseBtn.Text==";")
            {
                wmplayer.Ctlcontrols.pause();
                start_pauseBtn.Text = "4";
                timer1.Enabled = false;
            }
            else if (start_pauseBtn.Text=="4")
            {
                if (wmplayer.currentPlaylist.count != 0)
                {
                    play();
                    timer1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("please enter a media", "alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            wmplayer.Ctlcontrols.stop();
            start_pauseBtn.Text = "4";
            timer1.Enabled = false;
            timeleftLbl.Text = "00:00";
        }

        private void wmplayer_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        {
            pan();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (wmplayer.currentPlaylist.count>1)
            {
                wmplayer.Ctlcontrols.next();
                tracktime(0,(int)wmplayer.currentMedia.duration);
            }
            else
            {
                MessageBox.Show("play list is empty", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mute_unmutePic_Click(object sender, EventArgs e)
        {
            if (wmplayer.settings.volume != 0)
            {
                wmplayer.settings.volume = 0;
                mute_unmutePic.Image = Properties.Resources.mute;
            }
            else if (wmplayer.settings.volume == 0)
            {
                wmplayer.settings.volume = volumeTrackbar.Value;
                mute_unmutePic.Image = Properties.Resources.unmute;
            }
        }

        private void openvolumeBtn_Click(object sender, EventArgs e)
        {
            volumvis();
        }

        private void volumeTrackbar_Scroll(object sender, EventArgs e)
        {
            wmplayer.settings.volume = volumeTrackbar.Value;
            volumLbl.Text = volumeTrackbar.Value.ToString();
            pan();
            volumvis();
            volumLbl.Visible = true;
            label2.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                tracktime((int)wmplayer.Ctlcontrols.currentPosition,(int)wmplayer.currentMedia.duration); 
            }
            catch{}
             
        }

        private void time_Track_Scroll(object sender, EventArgs e)
        {
            wmplayer.Ctlcontrols.currentPosition = time_Track.Value;
        }

        private void showplaylistItem_Click(object sender, EventArgs e)
        {
            showplaylist();
        }

        private void exitplaylistBtn_Click(object sender, EventArgs e)
        {
            showplaylist(false);
        }

        private void clearPlayListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmplayer.currentPlaylist.clear();
            playlistBox.Items.Clear();
            enable_disablebtn(false);
            start_pauseBtn.Text = "4";
        }

        private void playlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            wmplayer.URL = p[playlistBox.SelectedIndex];
            play();
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                var fnames = Directory.GetFiles(path);
                p = fnames;
                foreach (string filename in fnames)
                {
                    additem(filename);
                }
            }
        }

        private void shuffleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shuffle();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void controlPanel_MouseMove(object sender, MouseEventArgs e)
        {
            pan();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (volumeTrackbar.Visible == true)
            {
                volumvis(false);
            }
        }

        private void volumeTrackbar_MouseMove(object sender, MouseEventArgs e)
        {
            pan();
            volumvis();
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            show_unshowtimer.Enabled = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem4.Text == "english")
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\ahpmpskin\lang","langform","english");
                english();
            }
            else
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\ahpmpskin\lang", "langform", "farsi");
                farsi();
            }
        }
    }
}
