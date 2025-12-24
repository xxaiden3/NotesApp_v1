using NotesApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class CreateNote : Form
    {
        public CreateNote()
        {
            InitializeComponent();
        }
        int karakterSayisi;
        private void SaveIB_Click(object sender, EventArgs e)
        {
            if (karakterSayisi > 2500)
            {
                MessageBox.Show("Max used characters");
            }
            else
            {
                DatabaseHelper.AddNote(
                   txttitle.Text,
                   txtcontent.Text,
                   txtcontent.Font.Name,
                   txtcontent.Font.Size,
                   txtcontent.Font.Bold,
                   txtcontent.ForeColor.ToArgb());
            }

        }

        private void CreateNote_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(SaveIB, "Save");
            toolTip1.SetToolTip(CleanIB, "Clean");
            toolTip1.SetToolTip(undo, "Undo");
            toolTip1.SetToolTip(redo, "Redo");
            toolTip1.SetToolTip(FontIB, "Change Font");
            toolTip1.SetToolTip(ColorIB, "Change Color");
            txttitle.Focus();
            txttitle.Text = "";
            lblfont.Text = txtcontent.Font.Name;
            Color c = txtcontent.ForeColor;

            if (c.IsNamedColor || c.IsKnownColor)
            {
                lblcolor.Text = c.Name;
            }
            else
            {
                lblcolor.Text = $"#{c.R:X2}{c.G:X2}{c.B:X2}";
            }
        }

        private void ColorIB_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = txtcontent.ForeColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtcontent.ForeColor = colorDialog1.Color;

                Color c = txtcontent.ForeColor;
                if (c.IsNamedColor || c.IsKnownColor)
                {
                    lblcolor.Text = c.Name;
                }
                else
                {
                    lblcolor.Text = $"#{c.R:X2}{c.G:X2}{c.B:X2}";
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FontIB_Click_1(object sender, EventArgs e)
        {
            fontDialog1.Font = txtcontent.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtcontent.Font = fontDialog1.Font;
            }
            lblfont.Text = txtcontent.Font.Name;
        }

        private void txtcontent_TextChanged(object sender, EventArgs e)
        {
            string text = txtcontent.Text;

            int wordCount = text
                .Split(new char[] { ' ', '\n', '\r', '\t' },
                       StringSplitOptions.RemoveEmptyEntries)
                .Length;
            int lineCount = txtcontent.Lines.Length;
            karakterSayisi = txtcontent.Text.Length;
            int max = 2500;
            int current = txtcontent.Text.Length;
            lblCharCount.Text = karakterSayisi + " characters \t\t" + "| " + current + " / " + max + " | " + wordCount.ToString() + " words" + " | " + lineCount.ToString() + " Line";

            if (current >= max)
                lblCharCount.ForeColor = Color.Red;
            else
                lblCharCount.ForeColor = Color.Black;


        }

        private void RefreshIB_Click(object sender, EventArgs e)
        {
            DialogResult tus = MessageBox.Show("Do u want to clean?", "Clean Text", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (tus == DialogResult.OK)
            {
                txttitle.Text = "Title";
                txtcontent.Text = "Note";
            }
        }

        private void undo_Click(object sender, EventArgs e)
        {
            txtcontent.Undo();
            txtcontent.Focus();
        }

        private void redo_Click(object sender, EventArgs e)
        {
            txtcontent.Redo();
            txtcontent.Focus();

        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {

        }

        private void txttitle_MouseClick(object sender, MouseEventArgs e)
        {
            txttitle.Text = "";
        }

        private void txttitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtcontent.Focus();
                if (txtcontent.Text == "Note")
                {
                    txtcontent.Text = "";
                }
            }
        }

        private void txttitle_Leave(object sender, EventArgs e)
        {
            if (txttitle.Text == "")
            {
                txttitle.Text = "Title";
            }
        }

        private void txtcontent_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtcontent.Text == "Note")
            {
                txtcontent.Text = "";
            }
        }

        private void txtcontent_Leave(object sender, EventArgs e)
        {

        }
    }
}
