namespace NotesApp
{
    partial class Home_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Page));
            this.PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btneditnotes = new Guna.UI2.WinForms.Guna2Button();
            this.btnshownotes = new Guna.UI2.WinForms.Guna2Button();
            this.btncreatenote = new Guna.UI2.WinForms.Guna2Button();
            this.home = new Guna.UI2.WinForms.Guna2Button();
            this.btnsupport = new Guna.UI2.WinForms.Guna2Button();
            this.btnmenu = new Guna.UI2.WinForms.Guna2Button();
            this.lbldate = new System.Windows.Forms.Label();
            this.timerlabel = new System.Windows.Forms.Timer(this.components);
            this.PanelForm = new Guna.UI2.WinForms.Guna2Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblformname = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.PanelMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMenu.Controls.Add(this.btneditnotes);
            this.PanelMenu.Controls.Add(this.btnshownotes);
            this.PanelMenu.Controls.Add(this.btncreatenote);
            this.PanelMenu.Controls.Add(this.home);
            this.PanelMenu.Controls.Add(this.btnsupport);
            this.PanelMenu.Controls.Add(this.btnmenu);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.PanelMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PanelMenu.ForeColor = System.Drawing.Color.Black;
            this.PanelMenu.Location = new System.Drawing.Point(20, 60);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 660);
            this.PanelMenu.TabIndex = 0;
            // 
            // btneditnotes
            // 
            this.btneditnotes.Animated = true;
            this.btneditnotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(132)))));
            this.btneditnotes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btneditnotes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btneditnotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btneditnotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btneditnotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btneditnotes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(158)))));
            this.btneditnotes.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btneditnotes.ForeColor = System.Drawing.Color.White;
            this.btneditnotes.Image = global::NotesApp.Properties.Resources.editnotes_white;
            this.btneditnotes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btneditnotes.ImageSize = new System.Drawing.Size(32, 32);
            this.btneditnotes.Location = new System.Drawing.Point(0, 180);
            this.btneditnotes.Name = "btneditnotes";
            this.btneditnotes.Size = new System.Drawing.Size(200, 45);
            this.btneditnotes.TabIndex = 15;
            this.btneditnotes.Text = "Edit Notes";
            this.btneditnotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btneditnotes.Click += new System.EventHandler(this.btneditnotes_Click);
            // 
            // btnshownotes
            // 
            this.btnshownotes.Animated = true;
            this.btnshownotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(132)))));
            this.btnshownotes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnshownotes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnshownotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnshownotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnshownotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnshownotes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(158)))));
            this.btnshownotes.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnshownotes.ForeColor = System.Drawing.Color.White;
            this.btnshownotes.Image = global::NotesApp.Properties.Resources.shownotes_white;
            this.btnshownotes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnshownotes.ImageSize = new System.Drawing.Size(32, 32);
            this.btnshownotes.Location = new System.Drawing.Point(0, 135);
            this.btnshownotes.Name = "btnshownotes";
            this.btnshownotes.Size = new System.Drawing.Size(200, 45);
            this.btnshownotes.TabIndex = 14;
            this.btnshownotes.Text = "Show Notes";
            this.btnshownotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnshownotes.Click += new System.EventHandler(this.btnshownotes_Click);
            // 
            // btncreatenote
            // 
            this.btncreatenote.Animated = true;
            this.btncreatenote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(132)))));
            this.btncreatenote.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncreatenote.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncreatenote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncreatenote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncreatenote.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncreatenote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(158)))));
            this.btncreatenote.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncreatenote.ForeColor = System.Drawing.Color.White;
            this.btncreatenote.Image = ((System.Drawing.Image)(resources.GetObject("btncreatenote.Image")));
            this.btncreatenote.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncreatenote.ImageSize = new System.Drawing.Size(30, 30);
            this.btncreatenote.Location = new System.Drawing.Point(0, 90);
            this.btncreatenote.Name = "btncreatenote";
            this.btncreatenote.Size = new System.Drawing.Size(200, 45);
            this.btncreatenote.TabIndex = 13;
            this.btncreatenote.Text = "Create Note";
            this.btncreatenote.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncreatenote.Click += new System.EventHandler(this.btncreatenote_Click);
            // 
            // home
            // 
            this.home.Animated = true;
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(132)))));
            this.home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.home.Dock = System.Windows.Forms.DockStyle.Top;
            this.home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(158)))));
            this.home.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Image = global::NotesApp.Properties.Resources.homee_white;
            this.home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.home.ImageSize = new System.Drawing.Size(32, 32);
            this.home.Location = new System.Drawing.Point(0, 45);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(200, 45);
            this.home.TabIndex = 10;
            this.home.Text = "Home";
            this.home.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // btnsupport
            // 
            this.btnsupport.Animated = true;
            this.btnsupport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(132)))));
            this.btnsupport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsupport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsupport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsupport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsupport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnsupport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(158)))));
            this.btnsupport.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsupport.ForeColor = System.Drawing.Color.White;
            this.btnsupport.Image = global::NotesApp.Properties.Resources.info_white;
            this.btnsupport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnsupport.ImageSize = new System.Drawing.Size(30, 30);
            this.btnsupport.Location = new System.Drawing.Point(0, 615);
            this.btnsupport.Name = "btnsupport";
            this.btnsupport.Size = new System.Drawing.Size(200, 45);
            this.btnsupport.TabIndex = 8;
            this.btnsupport.Text = "Support";
            this.btnsupport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnsupport.Click += new System.EventHandler(this.btnsupport_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.Animated = true;
            this.btnmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(132)))));
            this.btnmenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(158)))));
            this.btnmenu.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmenu.ForeColor = System.Drawing.Color.White;
            this.btnmenu.Image = global::NotesApp.Properties.Resources.Panelkücült_white;
            this.btnmenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnmenu.ImageSize = new System.Drawing.Size(29, 29);
            this.btnmenu.Location = new System.Drawing.Point(0, 0);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(200, 45);
            this.btnmenu.TabIndex = 4;
            this.btnmenu.Text = "Hide Menu";
            this.btnmenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnmenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lbldate
            // 
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(177)))));
            this.lbldate.Location = new System.Drawing.Point(930, 23);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(247, 35);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "01 Ocak 2026 ";
            this.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbldate.Click += new System.EventHandler(this.labeldate_Click);
            // 
            // timerlabel
            // 
            this.timerlabel.Enabled = true;
            this.timerlabel.Interval = 1000;
            this.timerlabel.Tick += new System.EventHandler(this.timerlabel_Tick);
            // 
            // PanelForm
            // 
            this.PanelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.PanelForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Location = new System.Drawing.Point(220, 60);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(960, 660);
            this.PanelForm.TabIndex = 1;
            this.PanelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelForm_Paint);
            // 
            // lblformname
            // 
            this.lblformname.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblformname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(177)))));
            this.lblformname.Location = new System.Drawing.Point(20, 17);
            this.lblformname.Name = "lblformname";
            this.lblformname.Size = new System.Drawing.Size(200, 35);
            this.lblformname.TabIndex = 4;
            this.lblformname.Text = "Welcome";
            this.lblformname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblformname.Click += new System.EventHandler(this.lblformname_Click);
            // 
            // lbltime
            // 
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(177)))));
            this.lbltime.Location = new System.Drawing.Point(809, 23);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(115, 35);
            this.lbltime.TabIndex = 5;
            this.lbltime.Text = "00:00:00";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.showNotesToolStripMenuItem,
            this.editNotesToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 92);
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Image = global::NotesApp.Properties.Resources.createnote_black;
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.CreateToolStripMenuItem.Text = "Create Note";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // showNotesToolStripMenuItem
            // 
            this.showNotesToolStripMenuItem.Image = global::NotesApp.Properties.Resources.shownotes_black;
            this.showNotesToolStripMenuItem.Name = "showNotesToolStripMenuItem";
            this.showNotesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.showNotesToolStripMenuItem.Text = "Show Notes";
            this.showNotesToolStripMenuItem.Click += new System.EventHandler(this.showNotesToolStripMenuItem_Click);
            // 
            // editNotesToolStripMenuItem
            // 
            this.editNotesToolStripMenuItem.Image = global::NotesApp.Properties.Resources.editnotes_black;
            this.editNotesToolStripMenuItem.Name = "editNotesToolStripMenuItem";
            this.editNotesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editNotesToolStripMenuItem.Text = "Edit Notes";
            this.editNotesToolStripMenuItem.Click += new System.EventHandler(this.editNotesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem1.Image")));
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 740);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblformname);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.lbldate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home_Page";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Home_Page_Load);
            this.PanelMenu.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelMenu;
        private Guna.UI2.WinForms.Guna2Panel PanelForm;
        private Guna.UI2.WinForms.Guna2Button btnmenu;
        private System.Windows.Forms.Label lbldate;
        private Guna.UI2.WinForms.Guna2Button btnsupport;
        private System.Windows.Forms.Timer timerlabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblformname;
        private Guna.UI2.WinForms.Guna2Button home;
        private Guna.UI2.WinForms.Guna2Button btncreatenote;
        private Guna.UI2.WinForms.Guna2Button btneditnotes;
        private Guna.UI2.WinForms.Guna2Button btnshownotes;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}