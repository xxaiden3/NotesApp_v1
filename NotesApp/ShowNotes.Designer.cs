namespace NotesApp
{
    partial class ShowNotes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvnotes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fontname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fontsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcontent = new System.Windows.Forms.RichTextBox();
            this.txttitle = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnotes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvnotes
            // 
            this.dgvnotes.AllowUserToAddRows = false;
            this.dgvnotes.AllowUserToDeleteRows = false;
            this.dgvnotes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvnotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvnotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dgvtitle,
            this.dgvnote,
            this.fontname,
            this.fontsize,
            this.bold,
            this.txtcolor,
            this.dgvdate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvnotes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvnotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvnotes.Location = new System.Drawing.Point(0, 0);
            this.dgvnotes.Margin = new System.Windows.Forms.Padding(5);
            this.dgvnotes.Name = "dgvnotes";
            this.dgvnotes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvnotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvnotes.RowHeadersVisible = false;
            this.dgvnotes.RowTemplate.Height = 30;
            this.dgvnotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvnotes.Size = new System.Drawing.Size(800, 450);
            this.dgvnotes.TabIndex = 22;
            this.dgvnotes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvnotes_CellFormatting);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // dgvtitle
            // 
            this.dgvtitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvtitle.DataPropertyName = "Title";
            this.dgvtitle.HeaderText = "Title";
            this.dgvtitle.Name = "dgvtitle";
            this.dgvtitle.ReadOnly = true;
            this.dgvtitle.Width = 72;
            // 
            // dgvnote
            // 
            this.dgvnote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvnote.DataPropertyName = "Content";
            this.dgvnote.HeaderText = "Note";
            this.dgvnote.Name = "dgvnote";
            this.dgvnote.ReadOnly = true;
            // 
            // fontname
            // 
            this.fontname.DataPropertyName = "FontName";
            this.fontname.HeaderText = "Font Name";
            this.fontname.Name = "fontname";
            this.fontname.ReadOnly = true;
            this.fontname.Visible = false;
            // 
            // fontsize
            // 
            this.fontsize.DataPropertyName = "FontSize";
            this.fontsize.HeaderText = "Font Size";
            this.fontsize.Name = "fontsize";
            this.fontsize.ReadOnly = true;
            this.fontsize.Visible = false;
            // 
            // bold
            // 
            this.bold.DataPropertyName = "IsBold";
            this.bold.HeaderText = "Bold";
            this.bold.Name = "bold";
            this.bold.ReadOnly = true;
            this.bold.Visible = false;
            // 
            // txtcolor
            // 
            this.txtcolor.DataPropertyName = "TextColor";
            this.txtcolor.HeaderText = "Text Color";
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.ReadOnly = true;
            this.txtcolor.Visible = false;
            // 
            // dgvdate
            // 
            this.dgvdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvdate.DataPropertyName = "CreatedDate";
            this.dgvdate.HeaderText = "Create Date";
            this.dgvdate.Name = "dgvdate";
            this.dgvdate.ReadOnly = true;
            this.dgvdate.Width = 81;
            // 
            // txtcontent
            // 
            this.txtcontent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtcontent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontent.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcontent.ForeColor = System.Drawing.Color.Black;
            this.txtcontent.Location = new System.Drawing.Point(557, 290);
            this.txtcontent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcontent.Name = "txtcontent";
            this.txtcontent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtcontent.Size = new System.Drawing.Size(230, 146);
            this.txtcontent.TabIndex = 24;
            this.txtcontent.Text = "Note";
            this.txtcontent.Visible = false;
            // 
            // txttitle
            // 
            this.txttitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.txttitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttitle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttitle.ForeColor = System.Drawing.Color.Black;
            this.txttitle.Location = new System.Drawing.Point(557, 271);
            this.txttitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(230, 19);
            this.txttitle.TabIndex = 23;
            this.txttitle.Text = "Title";
            this.txttitle.Visible = false;
            // 
            // ShowNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcontent);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.dgvnotes);
            this.Name = "ShowNotes";
            this.Text = "Show Notes";
            this.Load += new System.EventHandler(this.ShowNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvnotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnote;
        private System.Windows.Forms.DataGridViewTextBoxColumn fontname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fontsize;
        private System.Windows.Forms.DataGridViewTextBoxColumn bold;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdate;
        public System.Windows.Forms.RichTextBox txtcontent;
        public System.Windows.Forms.MaskedTextBox txttitle;
    }
}