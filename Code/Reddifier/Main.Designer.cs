namespace Reddifier
{
    partial class Main
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
            this.lb_subred = new System.Windows.Forms.Label();
            this.dg_posts = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tlb_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlb_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.tb_subred = new System.Windows.Forms.TextBox();
            this.lb_freq = new System.Windows.Forms.Label();
            this.tb_freq = new System.Windows.Forms.TextBox();
            this.lb_separator = new System.Windows.Forms.Label();
            this.btn_toggle = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAsReadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_minimize = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_sound = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dg_posts)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_subred
            // 
            this.lb_subred.AutoSize = true;
            this.lb_subred.Location = new System.Drawing.Point(9, 82);
            this.lb_subred.Name = "lb_subred";
            this.lb_subred.Size = new System.Drawing.Size(55, 13);
            this.lb_subred.TabIndex = 0;
            this.lb_subred.Text = "Subreddit:";
            // 
            // dg_posts
            // 
            this.dg_posts.AllowUserToAddRows = false;
            this.dg_posts.AllowUserToDeleteRows = false;
            this.dg_posts.AllowUserToResizeRows = false;
            this.dg_posts.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dg_posts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_posts.Location = new System.Drawing.Point(12, 105);
            this.dg_posts.MultiSelect = false;
            this.dg_posts.Name = "dg_posts";
            this.dg_posts.ReadOnly = true;
            this.dg_posts.RowHeadersVisible = false;
            this.dg_posts.Size = new System.Drawing.Size(460, 431);
            this.dg_posts.TabIndex = 1;
            this.dg_posts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_posts_CellClick);
            this.dg_posts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_posts_CellDoubleClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlb_status,
            this.tlb_time});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(484, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tlb_status
            // 
            this.tlb_status.Name = "tlb_status";
            this.tlb_status.Size = new System.Drawing.Size(89, 17);
            this.tlb_status.Text = "Status: Stopped";
            // 
            // tlb_time
            // 
            this.tlb_time.Name = "tlb_time";
            this.tlb_time.Size = new System.Drawing.Size(380, 17);
            this.tlb_time.Spring = true;
            this.tlb_time.Text = "Last updated: N/A";
            this.tlb_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_subred
            // 
            this.tb_subred.Location = new System.Drawing.Point(70, 79);
            this.tb_subred.Name = "tb_subred";
            this.tb_subred.Size = new System.Drawing.Size(197, 20);
            this.tb_subred.TabIndex = 3;
            this.tb_subred.TextChanged += new System.EventHandler(this.tb_subred_TextChanged);
            // 
            // lb_freq
            // 
            this.lb_freq.AutoSize = true;
            this.lb_freq.Location = new System.Drawing.Point(288, 82);
            this.lb_freq.Name = "lb_freq";
            this.lb_freq.Size = new System.Drawing.Size(74, 13);
            this.lb_freq.TabIndex = 4;
            this.lb_freq.Text = "Frequency (s):";
            // 
            // tb_freq
            // 
            this.tb_freq.Location = new System.Drawing.Point(368, 79);
            this.tb_freq.MaxLength = 4;
            this.tb_freq.Name = "tb_freq";
            this.tb_freq.Size = new System.Drawing.Size(104, 20);
            this.tb_freq.TabIndex = 5;
            this.tb_freq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_freq.TextChanged += new System.EventHandler(this.tb_freq_TextChanged);
            this.tb_freq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_freq_KeyPress);
            // 
            // lb_separator
            // 
            this.lb_separator.AutoSize = true;
            this.lb_separator.Location = new System.Drawing.Point(273, 82);
            this.lb_separator.Name = "lb_separator";
            this.lb_separator.Size = new System.Drawing.Size(9, 13);
            this.lb_separator.TabIndex = 6;
            this.lb_separator.Text = "|";
            // 
            // btn_toggle
            // 
            this.btn_toggle.Location = new System.Drawing.Point(12, 27);
            this.btn_toggle.Name = "btn_toggle";
            this.btn_toggle.Size = new System.Drawing.Size(460, 43);
            this.btn_toggle.TabIndex = 7;
            this.btn_toggle.Text = "Start";
            this.btn_toggle.UseVisualStyleBackColor = true;
            this.btn_toggle.Click += new System.EventHandler(this.btn_toggle_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(484, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markAsReadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // markAsReadToolStripMenuItem
            // 
            this.markAsReadToolStripMenuItem.Name = "markAsReadToolStripMenuItem";
            this.markAsReadToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.markAsReadToolStripMenuItem.Text = "Mark as Read";
            this.markAsReadToolStripMenuItem.Click += new System.EventHandler(this.markAsReadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_minimize,
            this.mi_sound});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // mi_minimize
            // 
            this.mi_minimize.Checked = true;
            this.mi_minimize.CheckOnClick = true;
            this.mi_minimize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_minimize.Name = "mi_minimize";
            this.mi_minimize.Size = new System.Drawing.Size(160, 22);
            this.mi_minimize.Text = "Minimize to tray";
            this.mi_minimize.Click += new System.EventHandler(this.mi_minimize_Click);
            // 
            // mi_sound
            // 
            this.mi_sound.Checked = true;
            this.mi_sound.CheckOnClick = true;
            this.mi_sound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_sound.Name = "mi_sound";
            this.mi_sound.Size = new System.Drawing.Size(160, 22);
            this.mi_sound.Text = "Sound notifier";
            this.mi_sound.Click += new System.EventHandler(this.mi_sound_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.btn_toggle);
            this.Controls.Add(this.lb_separator);
            this.Controls.Add(this.tb_freq);
            this.Controls.Add(this.lb_freq);
            this.Controls.Add(this.tb_subred);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.dg_posts);
            this.Controls.Add(this.lb_subred);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reddifier";
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dg_posts)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_subred;
        private System.Windows.Forms.DataGridView dg_posts;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tlb_status;
        private System.Windows.Forms.ToolStripStatusLabel tlb_time;
        private System.Windows.Forms.TextBox tb_subred;
        private System.Windows.Forms.Label lb_freq;
        private System.Windows.Forms.TextBox tb_freq;
        private System.Windows.Forms.Label lb_separator;
        private System.Windows.Forms.Button btn_toggle;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_minimize;
        private System.Windows.Forms.ToolStripMenuItem mi_sound;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.ToolStripMenuItem markAsReadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}