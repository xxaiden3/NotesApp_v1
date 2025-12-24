using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class support : MetroFramework.Forms.MetroForm
    {
        public support()
        {
            InitializeComponent();
        }

        private void support_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.SizeGripStyle = SizeGripStyle.Hide;

        }

        private void github_ib_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(
        new ProcessStartInfo
        {
            FileName = "https://github.com/xxaiden3",
            UseShellExecute = true
        });
        }

        private void linkedin_ib_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(
                new ProcessStartInfo
                { FileName = "https://www.linkedin.com/in/yasinucan/\r\n", UseShellExecute = true });
        }

        private void gmail_ib_Click(object sender, EventArgs e)
        {
            string mail = "yasinucan06@gmail.com";
            string subject = Uri.EscapeDataString("Notes App Support");
            string body = Uri.EscapeDataString("Hi,\n\nI need help about app.");

            string mailto = $"mailto:{mail}?subject={subject}&body={body}";

            System.Diagnostics.Process.Start(
                new ProcessStartInfo
                {
                    FileName = mailto,
                    UseShellExecute = true
                });
        }

        private void closeform_ib_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
