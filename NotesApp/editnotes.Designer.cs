namespace NotesApp
{
    partial class editnotes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.copyib = new FontAwesome.Sharp.IconButton();
            this.deleteib = new FontAwesome.Sharp.IconButton();
            this.editib = new FontAwesome.Sharp.IconButton();
            this.dgvnotes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fontname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fontsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnotes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.copyib);
            this.PanelMenu.Controls.Add(this.deleteib);
            this.PanelMenu.Controls.Add(this.editib);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.PanelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.PanelMenu.Location = new System.Drawing.Point(926, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(74, 660);
            this.PanelMenu.TabIndex = 1;
            // 
            // copyib
            // 
            this.copyib.BackColor = System.Drawing.Color.White;
            this.copyib.Dock = System.Windows.Forms.DockStyle.Top;
            this.copyib.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.copyib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyib.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.copyib.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.copyib.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.copyib.IconSize = 35;
            this.copyib.Location = new System.Drawing.Point(0, 90);
            this.copyib.Name = "copyib";
            this.copyib.Size = new System.Drawing.Size(74, 45);
            this.copyib.TabIndex = 12;
            this.copyib.UseVisualStyleBackColor = false;
            this.copyib.Click += new System.EventHandler(this.copyib_Click);
            // 
            // deleteib
            // 
            this.deleteib.BackColor = System.Drawing.Color.White;
            this.deleteib.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteib.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.deleteib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteib.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.deleteib.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.deleteib.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteib.IconSize = 35;
            this.deleteib.Location = new System.Drawing.Point(0, 45);
            this.deleteib.Name = "deleteib";
            this.deleteib.Size = new System.Drawing.Size(74, 45);
            this.deleteib.TabIndex = 10;
            this.deleteib.UseVisualStyleBackColor = false;
            this.deleteib.Click += new System.EventHandler(this.deleteib_Click);
            // 
            // editib
            // 
            this.editib.BackColor = System.Drawing.Color.White;
            this.editib.Dock = System.Windows.Forms.DockStyle.Top;
            this.editib.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.editib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editib.IconChar = FontAwesome.Sharp.IconChar.Highlighter;
            this.editib.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.editib.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editib.IconSize = 35;
            this.editib.Location = new System.Drawing.Point(0, 0);
            this.editib.Name = "editib";
            this.editib.Size = new System.Drawing.Size(74, 45);
            this.editib.TabIndex = 8;
            this.editib.UseVisualStyleBackColor = false;
            this.editib.Click += new System.EventHandler(this.editib_Click);
            // 
            // dgvnotes
            // 
            this.dgvnotes.AllowUserToAddRows = false;
            this.dgvnotes.AllowUserToDeleteRows = false;
            this.dgvnotes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvnotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvnotes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvnotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvnotes.Location = new System.Drawing.Point(0, 0);
            this.dgvnotes.Margin = new System.Windows.Forms.Padding(5);
            this.dgvnotes.Name = "dgvnotes";
            this.dgvnotes.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvnotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvnotes.RowHeadersVisible = false;
            this.dgvnotes.RowTemplate.Height = 30;
            this.dgvnotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvnotes.Size = new System.Drawing.Size(926, 660);
            this.dgvnotes.TabIndex = 16;
            this.dgvnotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnotes_CellClick);
            this.dgvnotes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvnotes_CellFormatting);
            this.dgvnotes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvnotes_CellMouseDoubleClick);
            this.dgvnotes.SelectionChanged += new System.EventHandler(this.dgvnotes_SelectionChanged);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtcontent);
            this.panel1.Controls.Add(this.txttitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 660);
            this.panel1.TabIndex = 19;
            this.panel1.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblfont);
            this.panel6.Controls.Add(this.lblbosluk);
            this.panel6.Controls.Add(this.lblcolor);
            this.panel6.Controls.Add(this.lblCharCount);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 587);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(926, 25);
            this.panel6.TabIndex = 29;
            // 
            // lblfont
            // 
            this.lblfont.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblfont.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfont.Location = new System.Drawing.Point(676, 0);
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
            this.lblbosluk.Location = new System.Drawing.Point(796, 0);
            this.lblbosluk.Name = "lblbosluk";
            this.lblbosluk.Size = new System.Drawing.Size(10, 13);
            this.lblbosluk.TabIndex = 3;
            this.lblbosluk.Text = " ";
            // 
            // lblcolor
            // 
            this.lblcolor.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblcolor.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcolor.Location = new System.Drawing.Point(806, 0);
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
            this.panel5.Location = new System.Drawing.Point(0, 612);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(926, 48);
            this.panel5.TabIndex = 28;
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
            this.FontIB.Location = new System.Drawing.Point(676, 0);
            this.FontIB.Name = "FontIB";
            this.FontIB.Size = new System.Drawing.Size(120, 48);
            this.FontIB.TabIndex = 36;
            this.FontIB.Text = "Change Font";
            this.FontIB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FontIB.UseVisualStyleBackColor = false;
            this.FontIB.Click += new System.EventHandler(this.FontIB_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(796, 0);
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
            this.redo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
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
            this.undo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
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
            this.CleanIB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
            this.CleanIB.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.CleanIB.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.CleanIB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CleanIB.IconSize = 38;
            this.CleanIB.Location = new System.Drawing.Point(60, 0);
            this.CleanIB.Name = "CleanIB";
            this.CleanIB.Size = new System.Drawing.Size(50, 48);
            this.CleanIB.TabIndex = 29;
            this.CleanIB.Text = " ";
            this.CleanIB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CleanIB.UseVisualStyleBackColor = false;
            this.CleanIB.Click += new System.EventHandler(this.CleanIB_Click);
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
            this.ColorIB.Location = new System.Drawing.Point(806, 0);
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
            this.SaveIB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
            this.SaveIB.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.SaveIB.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.SaveIB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SaveIB.IconSize = 38;
            this.SaveIB.Location = new System.Drawing.Point(0, 0);
            this.SaveIB.Name = "SaveIB";
            this.SaveIB.Size = new System.Drawing.Size(50, 48);
            this.SaveIB.TabIndex = 6;
            this.SaveIB.Text = " ";
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
            this.txtcontent.Size = new System.Drawing.Size(926, 567);
            this.txtcontent.TabIndex = 19;
            this.txtcontent.Text = "Note";
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
            this.txttitle.Size = new System.Drawing.Size(926, 19);
            this.txttitle.TabIndex = 17;
            this.txttitle.Text = "Title";
            // 
            // editnotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvnotes);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editnotes";
            this.Text = "editnotes";
            this.Load += new System.EventHandler(this.editnotes_Load);
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnotes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelMenu;
        private FontAwesome.Sharp.IconButton editib;
        private FontAwesome.Sharp.IconButton copyib;
        private FontAwesome.Sharp.IconButton deleteib;
        private System.Windows.Forms.DataGridView dgvnotes;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RichTextBox txtcontent;
        public System.Windows.Forms.MaskedTextBox txttitle;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblfont;
        private System.Windows.Forms.Label lblbosluk;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton FontIB;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton redo;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton undo;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton CleanIB;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton ColorIB;
        private FontAwesome.Sharp.IconButton SaveIB;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnote;
        private System.Windows.Forms.DataGridViewTextBoxColumn fontname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fontsize;
        private System.Windows.Forms.DataGridViewTextBoxColumn bold;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdate;
    }
}