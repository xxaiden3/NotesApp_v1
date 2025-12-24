using NotesApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class ShowNotes : Form
    {
        public ShowNotes()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            dgvnotes.AutoGenerateColumns = false;
            dgvnotes.DataSource = DatabaseHelper.GetNotes();
        }
        private void ShowNotes_Load(object sender, EventArgs e)
        {
            LoadGrid();
            dgvnotes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        int noteId;


        private void dgvnotes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

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
                e.CellStyle.Font = dgvnotes.Font;
                e.CellStyle.ForeColor = dgvnotes.ForeColor;
            }
        }
    }
}
