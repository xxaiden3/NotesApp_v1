using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class Home_Page : MetroFramework.Forms.MetroForm  //Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }
        bool menuOpen = true;

        DateTime now = DateTime.Now;

        private void Home_Page_Load(object sender, EventArgs e)
        {
            timerlabel.Start();

            //lbldate.Text = now.ToString("HH:mm - dddd");
            toolTip1.SetToolTip(btnmenu, "Hide Menu");
            toolTip1.SetToolTip(home, "Home Panel");
            toolTip1.SetToolTip(btncreatenote, "Create Note");
            toolTip1.SetToolTip(btnshownotes, "Show Notes");
            toolTip1.SetToolTip(btneditnotes, "Edit Notes");
            toolTip1.SetToolTip(btnsupport, "Support");
        }

        void LoadForm(Form frm)
        {
            PanelForm.Controls.Clear();
            //this.Text = title;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.AutoScaleMode = AutoScaleMode.None;

            PanelForm.Controls.Add(frm);
            frm.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (menuOpen)
            {

                menuOpen = false;
                PanelMenu.Width = 60;
                //btnmenu
                btnmenu.Image = Properties.Resources.Panelbüyüt_white;
                toolTip1.SetToolTip(btnmenu, "Open Menu");
                btnmenu.Text = "";
                btnmenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
                //home
                home.Text = "";
                home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
                //create note btncreatenote
                btncreatenote.Text = "";
                btncreatenote.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;

                //btnshownotes
                btnshownotes.Text = "";
                btnshownotes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;

                //btneditnotes
                btneditnotes.Text = "";
                btneditnotes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;

                //btnsupport
                btnsupport.Text = "";
                btnsupport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            }
            else
            {
                //lbldate.Text = now.ToString("HH:mm - dddd");//now.ToShortTimeString()
                menuOpen = true;
                PanelMenu.Width = 200;
                //btnmenu
                btnmenu.Image = Properties.Resources.Panelkücült_white;
                toolTip1.SetToolTip(btnmenu, "Hide Menu");
                btnmenu.Text = "Hide Menu";
                btnmenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                //home
                home.Text = "Home";
                home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                //create note btncreatenote
                btncreatenote.Text = "Create Note";
                btncreatenote.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;

                //btnshownotes
                btnshownotes.Text = "Show Notes";
                btnshownotes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;

                //btneditnotes
                btneditnotes.Text = "Edit Notes";
                btneditnotes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;

                //btnsupport
                btnsupport.Text = "Support";
                btnsupport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            }
        }

        private void PanelForm_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = PanelForm.ClientRectangle;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(3, 74, 166),   // Başlangıç rengi //034aa6
                Color.FromArgb(254, 236, 232),  // Bitiş rengi //feece8
                LinearGradientMode.Horizontal     // Horizontal / Vertical
            ))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = PanelForm.ClientRectangle;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(3, 74, 166),   // Başlangıç rengi //034aa6
                Color.FromArgb(9, 55, 133),
                //Color.FromArgb(254, 236, 232),white  // Bitiş rengi //feece8
                LinearGradientMode.Horizontal     // Horizontal / Vertical
            ))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            PanelForm.Controls.Clear();
            lblformname.Text = "Home";
        }
        private void btncreatenote_Click(object sender, EventArgs e)
        {
            LoadForm(new CreateNote());
            lblformname.Text = "Create Note";
        }

        private void btnshownotes_Click(object sender, EventArgs e)
        {
            LoadForm(new ShowNotes());
            lblformname.Text = "Show Notes";

        }

        private void btneditnotes_Click(object sender, EventArgs e)
        {
            LoadForm(new editnotes());
            lblformname.Text = "Edit Notes";
        }

        private void timerlabel_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString();
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void labeldate_Click(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new CreateNote());
            lblformname.Text = "Create Note";
        }

        private void showNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new ShowNotes());
            lblformname.Text = "Show Notes";
        }

        private void editNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new editnotes());
            lblformname.Text = "Edit Notes";
        }

        private void lblformname_Click(object sender, EventArgs e)
        {

        }

        private void btnsupport_Click(object sender, EventArgs e)
        {
            support sup = new support();
            sup.ShowDialog();
        }
    }
}

