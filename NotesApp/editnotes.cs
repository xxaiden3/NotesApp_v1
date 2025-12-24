using NotesApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class editnotes : Form
    {
        public editnotes()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            dgvnotes.AutoGenerateColumns = false;
            dgvnotes.DataSource = DatabaseHelper.GetNotes();
        }
        private void editnotes_Load(object sender, EventArgs e)
        {

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
            LoadGrid();
            toolTip1.SetToolTip(editib, "Edit");
            toolTip1.SetToolTip(deleteib, "Delete");
            toolTip1.SetToolTip(copyib, "Copy");


        }

        private void editib_Click(object sender, EventArgs e)
        {
            PanelMenu.Visible = false;
            panel1.Visible = true;
            var note = DatabaseHelper.GetNoteById(noteId);
            if (note == null) return;
            txttitle.Text = note["Title"].ToString();
            txtcontent.Text = note["Content"].ToString();
        }
        int noteId;
        private void dgvnotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Test");
            //PanelMenu.Visible = false;
            //panel1.Visible = true;
            if (e.RowIndex < 0) return;
            noteId = Convert.ToInt32(
                dgvnotes.Rows[e.RowIndex].Cells["Id"].Value);
            //var note = DatabaseHelper.GetNoteById(noteId);
            //if (note == null) return;
            //txttitle.Text = note["Title"].ToString();
            //txtcontent.Text = note["Content"].ToString();
        }

        private void dgvnotes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PanelMenu.Visible = false;
            panel1.Visible = true;
            if (e.RowIndex < 0) return;
            noteId = Convert.ToInt32(
                dgvnotes.Rows[e.RowIndex].Cells["Id"].Value);
            var note = DatabaseHelper.GetNoteById(noteId);
            if (note == null) return;
            txttitle.Text = note["Title"].ToString();
            txtcontent.Text = note["Content"].ToString();

            DataGridViewRow row = dgvnotes.CurrentRow;


            string content = row.Cells["dgvnote"].Value.ToString();
            string fontName = row.Cells["FontName"].Value.ToString();
            float fontSize = Convert.ToSingle(row.Cells["FontSize"].Value);
            bool isBold = Convert.ToInt32(row.Cells["bold"].Value) == 1;
            int colorArgb = Convert.ToInt32(row.Cells["txtcolor"].Value);
        }
        private void dgvnotes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvnotes.CurrentRow == null)
                return;

            DataGridViewRow row = dgvnotes.CurrentRow;

            string content = row.Cells["dgvnote"].Value.ToString();
            string fontName = row.Cells["FontName"].Value.ToString();
            float fontSize = Convert.ToSingle(row.Cells["FontSize"].Value);
            bool isBold = Convert.ToInt32(row.Cells["bold"].Value) == 1;
            int colorArgb = Convert.ToInt32(row.Cells["txtcolor"].Value);

            FontStyle style = isBold ? FontStyle.Bold : FontStyle.Regular;

            txtcontent.Text = content;
            txtcontent.Font = new Font(fontName, fontSize, style);
            txtcontent.ForeColor = Color.FromArgb(colorArgb);
            lblfont.Text = fontName;
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

        private void FontIB_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = txtcontent.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtcontent.Font = fontDialog1.Font;
            }
            lblfont.Text = txtcontent.Font.Name;
        }

        int karakterSayisi;

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

        private void SaveIB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful" , "" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            DatabaseHelper.UpdateNote(
            noteId,
            txttitle.Text,
            txtcontent.Text,
            txtcontent.Font.Name,
            txtcontent.Font.Size,
            txtcontent.Font.Bold,
            txtcontent.ForeColor.ToArgb()
            );
        }

        private void deleteib_Click(object sender, EventArgs e)
        {
            DatabaseHelper.DeleteNote(
                noteId
                );
            LoadGrid();


        }

        private void copyib_Click(object sender, EventArgs e)
        {
            if (dgvnotes.SelectedRows.Count > 0)
            {
                string title = dgvnotes.SelectedRows[0].Cells["dgvtitle"].Value.ToString();
                string note = dgvnotes.SelectedRows[0].Cells["dgvnote"].Value.ToString();

                //string text = $"Title: {title}\n \n{note}";
                string text = "Title:" + title + "\n\nNote:" + note;
                Clipboard.SetText(text);

                MessageBox.Show("Note copied!", "Success");
            }
            else
            {
                MessageBox.Show("Select a note first!");
            }
        }

        private void CleanIB_Click(object sender, EventArgs e)
        {
            txttitle.Text = "";
            txtcontent.Text = "Notes";
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvnotes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // 🔴 SADECE NOT SÜTUNU
            if (dgvnotes.Columns[e.ColumnIndex].Name != "dgvnote")
                return;

            DataGridViewRow row = dgvnotes.Rows[e.RowIndex];

            string fontName = row.Cells["FontName"].Value?.ToString();
            float fontSize = Convert.ToSingle(row.Cells["FontSize"].Value);
            bool isBold = Convert.ToInt32(row.Cells["bold"].Value) == 1;
            int colorArgb = Convert.ToInt32(row.Cells["txtcolor"].Value);

            FontStyle style = isBold ? FontStyle.Bold : FontStyle.Regular;

            try
            {
                e.CellStyle.Font = new Font(fontName, fontSize, style);
                e.CellStyle.ForeColor = Color.FromArgb(colorArgb);
            }
            catch
            {
                // font yoksa default
                e.CellStyle.Font = dgvnotes.Font;
                e.CellStyle.ForeColor = dgvnotes.ForeColor;
            }
        }
    }
}
