
namespace alhkam
{
    partial class Main
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
            this.pn_topbar = new System.Windows.Forms.Panel();
            this.pn_navbar = new System.Windows.Forms.Panel();
            this.pn_cont = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pn_infonav = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_topbar.SuspendLayout();
            this.pn_navbar.SuspendLayout();
            this.pn_cont.SuspendLayout();
            this.pn_infonav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_topbar
            // 
            this.pn_topbar.BackColor = System.Drawing.Color.Gray;
            this.pn_topbar.Controls.Add(this.label1);
            this.pn_topbar.Controls.Add(this.iconButton2);
            this.pn_topbar.Controls.Add(this.iconButton1);
            this.pn_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_topbar.Location = new System.Drawing.Point(0, 0);
            this.pn_topbar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pn_topbar.Name = "pn_topbar";
            this.pn_topbar.Size = new System.Drawing.Size(1022, 57);
            this.pn_topbar.TabIndex = 0;
            // 
            // pn_navbar
            // 
            this.pn_navbar.BackColor = System.Drawing.Color.Gray;
            this.pn_navbar.Controls.Add(this.pn_infonav);
            this.pn_navbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_navbar.Location = new System.Drawing.Point(1022, 0);
            this.pn_navbar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pn_navbar.Name = "pn_navbar";
            this.pn_navbar.Size = new System.Drawing.Size(215, 562);
            this.pn_navbar.TabIndex = 1;
            // 
            // pn_cont
            // 
            this.pn_cont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_cont.Controls.Add(this.pn_topbar);
            this.pn_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cont.Location = new System.Drawing.Point(0, 0);
            this.pn_cont.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pn_cont.Name = "pn_cont";
            this.pn_cont.Size = new System.Drawing.Size(1022, 562);
            this.pn_cont.TabIndex = 2;
            this.pn_cont.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_cont_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("LBC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(475, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "الرئيسة";
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.Location = new System.Drawing.Point(74, 10);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(54, 35);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.Text = " ";
            this.iconButton2.UseMnemonic = false;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 29;
            this.iconButton1.Location = new System.Drawing.Point(8, 10);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(54, 35);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = " ";
            this.iconButton1.UseMnemonic = false;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // pn_infonav
            // 
            this.pn_infonav.Controls.Add(this.label2);
            this.pn_infonav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_infonav.Location = new System.Drawing.Point(0, 0);
            this.pn_infonav.Name = "pn_infonav";
            this.pn_infonav.Size = new System.Drawing.Size(215, 140);
            this.pn_infonav.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("LBC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "شركة الحكم التجارية";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 562);
            this.Controls.Add(this.pn_cont);
            this.Controls.Add(this.pn_navbar);
            this.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alhkam Trading";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pn_topbar.ResumeLayout(false);
            this.pn_topbar.PerformLayout();
            this.pn_navbar.ResumeLayout(false);
            this.pn_cont.ResumeLayout(false);
            this.pn_infonav.ResumeLayout(false);
            this.pn_infonav.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_topbar;
        private System.Windows.Forms.Panel pn_navbar;
        private System.Windows.Forms.Panel pn_cont;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel pn_infonav;
        private System.Windows.Forms.Label label2;
    }
}

