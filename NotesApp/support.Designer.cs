namespace NotesApp
{
    partial class support
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
            this.github_ib = new FontAwesome.Sharp.IconButton();
            this.lblinfo = new System.Windows.Forms.Label();
            this.gmail_ib = new FontAwesome.Sharp.IconButton();
            this.linkedin_ib = new FontAwesome.Sharp.IconButton();
            this.closeform_ib = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // github_ib
            // 
            this.github_ib.BackColor = System.Drawing.Color.White;
            this.github_ib.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.github_ib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.github_ib.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.github_ib.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(177)))));
            this.github_ib.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.github_ib.IconSize = 35;
            this.github_ib.Location = new System.Drawing.Point(23, 91);
            this.github_ib.Name = "github_ib";
            this.github_ib.Size = new System.Drawing.Size(75, 70);
            this.github_ib.TabIndex = 13;
            this.github_ib.UseVisualStyleBackColor = false;
            this.github_ib.Click += new System.EventHandler(this.github_ib_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(177)))));
            this.lblinfo.Location = new System.Drawing.Point(23, 21);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(555, 67);
            this.lblinfo.TabIndex = 14;
            this.lblinfo.Text = "For suggestions and feedback, you can contact us";
            // 
            // gmail_ib
            // 
            this.gmail_ib.BackColor = System.Drawing.Color.White;
            this.gmail_ib.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.gmail_ib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gmail_ib.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.gmail_ib.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(177)))));
            this.gmail_ib.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.gmail_ib.IconSize = 35;
            this.gmail_ib.Location = new System.Drawing.Point(104, 91);
            this.gmail_ib.Name = "gmail_ib";
            this.gmail_ib.Size = new System.Drawing.Size(75, 70);
            this.gmail_ib.TabIndex = 15;
            this.gmail_ib.UseVisualStyleBackColor = false;
            this.gmail_ib.Click += new System.EventHandler(this.gmail_ib_Click);
            // 
            // linkedin_ib
            // 
            this.linkedin_ib.BackColor = System.Drawing.Color.White;
            this.linkedin_ib.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.linkedin_ib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkedin_ib.IconChar = FontAwesome.Sharp.IconChar.Linkedin;
            this.linkedin_ib.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(177)))));
            this.linkedin_ib.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.linkedin_ib.IconSize = 35;
            this.linkedin_ib.Location = new System.Drawing.Point(185, 91);
            this.linkedin_ib.Name = "linkedin_ib";
            this.linkedin_ib.Size = new System.Drawing.Size(75, 70);
            this.linkedin_ib.TabIndex = 16;
            this.linkedin_ib.UseVisualStyleBackColor = false;
            this.linkedin_ib.Click += new System.EventHandler(this.linkedin_ib_Click);
            // 
            // closeform_ib
            // 
            this.closeform_ib.BackColor = System.Drawing.Color.White;
            this.closeform_ib.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.closeform_ib.FlatAppearance.BorderSize = 0;
            this.closeform_ib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeform_ib.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.closeform_ib.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(177)))));
            this.closeform_ib.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeform_ib.IconSize = 20;
            this.closeform_ib.Location = new System.Drawing.Point(602, 10);
            this.closeform_ib.Name = "closeform_ib";
            this.closeform_ib.Size = new System.Drawing.Size(32, 28);
            this.closeform_ib.TabIndex = 17;
            this.closeform_ib.UseVisualStyleBackColor = false;
            this.closeform_ib.Click += new System.EventHandler(this.closeform_ib_Click);
            // 
            // support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 178);
            this.ControlBox = false;
            this.Controls.Add(this.closeform_ib);
            this.Controls.Add(this.linkedin_ib);
            this.Controls.Add(this.gmail_ib);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.github_ib);
            this.Name = "support";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.support_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton github_ib;
        private System.Windows.Forms.Label lblinfo;
        private FontAwesome.Sharp.IconButton gmail_ib;
        private FontAwesome.Sharp.IconButton linkedin_ib;
        private FontAwesome.Sharp.IconButton closeform_ib;
    }
}