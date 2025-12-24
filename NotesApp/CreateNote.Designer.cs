namespace NotesApp
{
    partial class CreateNote
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblfont = new System.Windows.Forms.Label();
            this.lblbosluk = new System.Windows.Forms.Label();
            this.lblcolor = new System.Windows.Forms.Label();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.FontIB = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.redo = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.undo = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CleanIB = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ColorIB = new FontAwesome.Sharp.IconButton();
            this.SaveIB = new FontAwesome.Sharp.IconButton();
            this.txtcontent = new System.Windows.Forms.RichTextBox();
            this.txttitle = new System.Windows.Forms.MaskedTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtcontent);
            this.panel1.Controls.Add(this.txttitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 621);
            this.panel1.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblfont);
            this.panel6.Controls.Add(this.lblbosluk);
            this.panel6.Controls.Add(this.lblcolor);
            this.panel6.Controls.Add(this.lblCharCount);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 548);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(984, 25);
            this.panel6.TabIndex = 27;
            // 
            // lblfont
            // 
            this.lblfont.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblfont.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
            this.lblfont.Location = new System.Drawing.Point(734, 0);
            this.lblfont.Name = "lblfont";
            this.lblfont.Size = new System.Drawing.Size(120, 25);
            this.lblfont.TabIndex = 38;
            this.lblfont.Text = "Font Name";
            this.lblfont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblbosluk
            // 
            this.lblbosluk.AutoSize = true;
            this.lblbosluk.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblbosluk.Location = new System.Drawing.Point(854, 0);
            this.lblbosluk.Name = "lblbosluk";
            this.lblbosluk.Size = new System.Drawing.Size(10, 13);
            this.lblbosluk.TabIndex = 3;
            this.lblbosluk.Text = " ";
            // 
            // lblcolor
            // 
            this.lblcolor.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblcolor.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcolor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
            this.lblcolor.Location = new System.Drawing.Point(864, 0);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(120, 25);
            this.lblcolor.TabIndex = 2;
            this.lblcolor.Text = "Black";
            this.lblcolor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCharCount
            // 
            this.lblCharCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCharCount.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCharCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
            this.lblCharCount.Location = new System.Drawing.Point(0, 0);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(370, 25);
            this.lblCharCount.TabIndex = 0;
            this.lblCharCount.Text = "0 Characters | 0 / 2500 | 0 Words | 0 Line";
            this.lblCharCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.panel5.Controls.Add(this.FontIB);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.redo);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.undo);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.CleanIB);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.ColorIB);
            this.panel5.Controls.Add(this.SaveIB);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 573);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(984, 48);
            this.panel5.TabIndex = 26;
            // 
            // FontIB
            // 
            this.FontIB.BackColor = System.Drawing.Color.White;
            this.FontIB.Dock = System.Windows.Forms.DockStyle.Right;
            this.FontIB.FlatAppearance.BorderSize = 0;
            this.FontIB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FontIB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FontIB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.FontIB.IconChar = FontAwesome.Sharp.IconChar.Font;
            this.FontIB.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.FontIB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FontIB.IconSize = 38;
            this.FontIB.Location = new System.Drawing.Point(734, 0);
            this.FontIB.Name = "FontIB";
            this.FontIB.Size = new System.Drawing.Size(120, 48);
            this.FontIB.TabIndex = 36;
            this.FontIB.Text = "Change Font";
            this.FontIB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FontIB.UseVisualStyleBackColor = false;
            this.FontIB.Click += new System.EventHandler(this.FontIB_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(854, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 48);
            this.panel2.TabIndex = 35;
            // 
            // redo
            // 
            this.redo.BackColor = System.Drawing.Color.White;
            this.redo.Dock = System.Windows.Forms.DockStyle.Left;
            this.redo.FlatAppearance.BorderSize = 0;
            this.redo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.redo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.redo.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.redo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.redo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.redo.IconSize = 38;
            this.redo.Location = new System.Drawing.Point(180, 0);
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(50, 48);
            this.redo.TabIndex = 33;
            this.redo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.redo.UseVisualStyleBackColor = false;
            this.redo.Click += new System.EventHandler(this.redo_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(170, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 48);
            this.panel7.TabIndex = 32;
            // 
            // undo
            // 
            this.undo.BackColor = System.Drawing.Color.White;
            this.undo.Dock = System.Windows.Forms.DockStyle.Left;
            this.undo.FlatAppearance.BorderSize = 0;
            this.undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.undo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.undo.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.undo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.undo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.undo.IconSize = 38;
            this.undo.Location = new System.Drawing.Point(120, 0);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(50, 48);
            this.undo.TabIndex = 31;
            this.undo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.undo.UseVisualStyleBackColor = false;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(110, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 48);
            this.panel4.TabIndex = 30;
            // 
            // CleanIB
            // 
            this.CleanIB.BackColor = System.Drawing.Color.White;
            this.CleanIB.Dock = System.Windows.Forms.DockStyle.Left;
            this.CleanIB.FlatAppearance.BorderSize = 0;
            this.CleanIB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleanIB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CleanIB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.CleanIB.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.CleanIB.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.CleanIB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CleanIB.IconSize = 38;
            this.CleanIB.Location = new System.Drawing.Point(60, 0);
            this.CleanIB.Name = "CleanIB";
            this.CleanIB.Size = new System.Drawing.Size(50, 48);
            this.CleanIB.TabIndex = 29;
            this.CleanIB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CleanIB.UseVisualStyleBackColor = false;
            this.CleanIB.Click += new System.EventHandler(this.RefreshIB_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(50, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 48);
            this.panel3.TabIndex = 28;
            // 
            // ColorIB
            // 
            this.ColorIB.BackColor = System.Drawing.Color.White;
            this.ColorIB.Dock = System.Windows.Forms.DockStyle.Right;
            this.ColorIB.FlatAppearance.BorderSize = 0;
            this.ColorIB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorIB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ColorIB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.ColorIB.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.ColorIB.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.ColorIB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ColorIB.IconSize = 38;
            this.ColorIB.Location = new System.Drawing.Point(864, 0);
            this.ColorIB.Name = "ColorIB";
            this.ColorIB.Size = new System.Drawing.Size(120, 48);
            this.ColorIB.TabIndex = 28;
            this.ColorIB.Text = "Change Color";
            this.ColorIB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ColorIB.UseVisualStyleBackColor = false;
            this.ColorIB.Click += new System.EventHandler(this.ColorIB_Click);
            // 
            // SaveIB
            // 
            this.SaveIB.BackColor = System.Drawing.Color.White;
            this.SaveIB.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveIB.FlatAppearance.BorderSize = 0;
            this.SaveIB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveIB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveIB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.SaveIB.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.SaveIB.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.SaveIB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SaveIB.IconSize = 38;
            this.SaveIB.Location = new System.Drawing.Point(0, 0);
            this.SaveIB.Name = "SaveIB";
            this.SaveIB.Size = new System.Drawing.Size(50, 48);
            this.SaveIB.TabIndex = 6;
            this.SaveIB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveIB.UseVisualStyleBackColor = false;
            this.SaveIB.Click += new System.EventHandler(this.SaveIB_Click);
            // 
            // txtcontent
            // 
            this.txtcontent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtcontent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontent.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtcontent.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcontent.ForeColor = System.Drawing.Color.Black;
            this.txtcontent.Location = new System.Drawing.Point(0, 19);
            this.txtcontent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcontent.Name = "txtcontent";
            this.txtcontent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtcontent.Size = new System.Drawing.Size(984, 528);
            this.txtcontent.TabIndex = 4;
            this.txtcontent.Text = "Note";
            this.txtcontent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtcontent_MouseClick);
            this.txtcontent.TextChanged += new System.EventHandler(this.txtcontent_TextChanged);
            // 
            // txttitle
            // 
            this.txttitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.txttitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txttitle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttitle.ForeColor = System.Drawing.Color.Black;
            this.txttitle.Location = new System.Drawing.Point(0, 0);
            this.txttitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(984, 19);
            this.txttitle.TabIndex = 3;
            this.txttitle.Text = "Title";
            this.txttitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttitle_MouseClick);
            this.txttitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttitle_KeyDown);
            this.txttitle.Leave += new System.EventHandler(this.txttitle_Leave);
            // 
            // CreateNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 621);
            this.Controls.Add(this.panel1);
            this.Name = "CreateNote";
            this.Text = "CreateNote";
            this.Load += new System.EventHandler(this.CreateNote_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton undo;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton CleanIB;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton ColorIB;
        private FontAwesome.Sharp.IconButton SaveIB;
        public System.Windows.Forms.RichTextBox txtcontent;
        public System.Windows.Forms.MaskedTextBox txttitle;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private FontAwesome.Sharp.IconButton redo;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton FontIB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Label lblbosluk;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblfont;
    }
}