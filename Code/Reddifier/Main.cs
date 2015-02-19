using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Media;

namespace Reddifier
{
    public partial class Main : Form
    {
        private String subred = String.Empty;
        private int frequency = 0;
        private int timeLeft = 0;
        private bool useSound = true,
            toTray = true;
        private Status status = Status.Stopped;
        private BindingList<RedPost> list = new BindingList<RedPost>();
        private BindingSource source = new BindingSource();
        private List<RedPost> queue = new List<RedPost>();
        private NotifyIcon tray = new NotifyIcon();
        private SoundPlayer player;


        public Main()
        {
            InitializeComponent();
            initialise();
        }

        private void initialise()
        {
            source.DataSource = null;
            source.DataSource = list;
            dg_posts.DataSource = source;

            dg_posts.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg_posts.Columns[0].HeaderText = "Posts";
            dg_posts.Columns[1].Visible = false;
            dg_posts.Columns[2].Visible = false;

            this.Icon = Properties.Resources.GreenIcon;
            tray.Icon = Properties.Resources.GreenIcon;

            tray.Text = "Reddifier";
            tray.MouseDoubleClick += tray_MouseDoubleClick;

            player = new SoundPlayer(Properties.Resources.beep);
            
        }


        private void tb_subred_TextChanged(object sender, EventArgs e)
        {
            subred = tb_subred.Text;
        }

        private void tb_freq_TextChanged(object sender, EventArgs e)
        {
            String freq = tb_freq.Text;
            if(freq.Length > 0)
                frequency = Convert.ToInt32(freq);
        }

        private void tb_freq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mi_minimize_Click(object sender, EventArgs e)
        {
            toTray = !toTray;
        }

        private void mi_sound_Click(object sender, EventArgs e)
        {
            useSound = !useSound;
        }

        private void btn_toggle_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_freq.Text) || String.IsNullOrWhiteSpace(tb_subred.Text))
                return;

            if (status == Status.Stopped)
            {
                list.Clear();
                this.Icon = Properties.Resources.RedIcon;
                tray.Icon = Properties.Resources.RedIcon;
                btn_toggle.Text = "Stop";
                btn_toggle.ForeColor = Color.Red;
                tb_subred.Enabled = false;
                tb_freq.Enabled = false;
                status = Status.Running;
                timeLeft = 0;
                timer.Start();
            }
            else
            {
                this.Icon = Properties.Resources.GreenIcon;
                tray.Icon = Properties.Resources.GreenIcon;
                btn_toggle.Text = "Start";
                btn_toggle.ForeColor = Color.Black;
                tlb_status.Text = "Status: Stopped";
                tb_subred.Enabled = true;
                tb_freq.Enabled = true;
                status = Status.Stopped;
                timer.Stop();
            }
        }

        private enum Status
        {
            Stopped,
            Running, 
            Updating
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            tlb_status.Text = "Status: Updating in " + timeLeft + " seconds";

            if (timeLeft <= 0)
            {
                if (status == Status.Updating)
                    return;

                tlb_status.Text = "Status: Updating now";
                worker.RunWorkerAsync();
                timeLeft = frequency;
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Console.WriteLine("Updating!");
                tlb_time.Text = "Last updated: " + DateTime.Now.ToString("HH:mm:ss");
                status = Status.Updating;

                JToken token = Network.downloadPosts(subred);
                for (int i = 0; i < 25; i++)
                {
                    JToken child = token[i]["data"];
                    RedPost post = new RedPost
                    {
                        Text = (String)child["title"],
                        Link = "http://" + "www.reddit.com" + (String)child["permalink"],
                        Id = (String)child["id"]
                    };

                    if (list.Contains(post) == false)
                    {
                        queue.Add(post);
                        //Console.WriteLine(post.Text);
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            status = Status.Running;


            if (queue.Count > 0)
            {
                Console.WriteLine("Adding " + queue.Count + " posts!");
                showOnTop();
                

                int before = dg_posts.RowCount;

                queue.Reverse();
                foreach (RedPost post in queue)
                    list.Add(post);
                queue.Clear();

                dg_posts.FirstDisplayedScrollingRowIndex = dg_posts.RowCount - 1;

                if (useSound)
                    player.Play();

                if (before != 0) {
                    int after = dg_posts.RowCount - 1;

                    for (int i = before; i <= after; i++)
                    {
                        dg_posts.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;
                    }
                }
            }


        }

        private void showOnTop()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                Console.WriteLine("Normalizing!");
            }
            this.TopMost = true;
            this.Show();
            this.Focus();
            this.TopMost = false;
        }

        private void dg_posts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dg_posts.SelectedCells[0].RowIndex;
            RedPost post = list[selected];

            ProcessStartInfo info = new ProcessStartInfo(post.Link);
            Process.Start(info);
        }

        private void dg_posts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dg_posts.SelectedCells[0].RowIndex;
            dg_posts.Rows[selected].DefaultCellStyle.BackColor = Color.White;
        }

        private void markAsReadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dg_posts.RowCount; i++)
                dg_posts.Rows[i].DefaultCellStyle.BackColor = Color.White;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized && toTray)
            {
                Console.WriteLine("Hiding!");
                this.ShowInTaskbar = false;
                tray.Visible = true;
            }
        }

        void tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Caught double click!");
            tray.Visible = false;
            this.ShowInTaskbar = true;
            showOnTop();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }


    }
}
