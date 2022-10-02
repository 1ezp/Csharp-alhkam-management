
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
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.btn_min = new FontAwesome.Sharp.IconButton();
            this.btn_close = new FontAwesome.Sharp.IconButton();
            this.pn_navbar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.pn_infonav = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_cont = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pn_topbar.SuspendLayout();
            this.pn_navbar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pn_infonav.SuspendLayout();
            this.pn_cont.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_topbar
            // 
            this.pn_topbar.BackColor = System.Drawing.Color.Gray;
            this.pn_topbar.Controls.Add(this.iconButton1);
            this.pn_topbar.Controls.Add(this.lb_titlepage);
            this.pn_topbar.Controls.Add(this.btn_min);
            this.pn_topbar.Controls.Add(this.btn_close);
            this.pn_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_topbar.Location = new System.Drawing.Point(0, 0);
            this.pn_topbar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pn_topbar.Name = "pn_topbar";
            this.pn_topbar.Size = new System.Drawing.Size(1027, 57);
            this.pn_topbar.TabIndex = 0;
            this.pn_topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_topbar_MouseDown);
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_titlepage.AutoSize = true;
            this.lb_titlepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_titlepage.Font = new System.Drawing.Font("LBC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titlepage.ForeColor = System.Drawing.SystemColors.Info;
            this.lb_titlepage.Location = new System.Drawing.Point(477, 12);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(74, 28);
            this.lb_titlepage.TabIndex = 6;
            this.lb_titlepage.Text = "الرئيسة";
            // 
            // btn_min
            // 
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btn_min.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_min.IconColor = System.Drawing.Color.Black;
            this.btn_min.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_min.IconSize = 35;
            this.btn_min.Location = new System.Drawing.Point(96, 12);
            this.btn_min.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(36, 28);
            this.btn_min.TabIndex = 5;
            this.btn_min.Text = " ";
            this.btn_min.UseMnemonic = false;
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btn_close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_close.IconSize = 29;
            this.btn_close.Location = new System.Drawing.Point(8, 12);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(36, 28);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = " ";
            this.btn_close.UseMnemonic = false;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pn_navbar
            // 
            this.pn_navbar.BackColor = System.Drawing.Color.Gray;
            this.pn_navbar.Controls.Add(this.flowLayoutPanel1);
            this.pn_navbar.Controls.Add(this.pn_infonav);
            this.pn_navbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_navbar.Location = new System.Drawing.Point(1027, 0);
            this.pn_navbar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pn_navbar.Name = "pn_navbar";
            this.pn_navbar.Size = new System.Drawing.Size(210, 562);
            this.pn_navbar.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.iconButton3);
            this.flowLayoutPanel1.Controls.Add(this.iconButton4);
            this.flowLayoutPanel1.Controls.Add(this.iconButton5);
            this.flowLayoutPanel1.Controls.Add(this.iconButton6);
            this.flowLayoutPanel1.Controls.Add(this.iconButton8);
            this.flowLayoutPanel1.Controls.Add(this.iconButton7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 140);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 422);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton3.Font = new System.Drawing.Font("LBC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.OldLace;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton3.IconColor = System.Drawing.Color.Orange;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(4, 3);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iconButton3.Size = new System.Drawing.Size(207, 51);
            this.iconButton3.TabIndex = 6;
            this.iconButton3.Text = " الرئيسة";
            this.iconButton3.UseMnemonic = false;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton4.Font = new System.Drawing.Font("LBC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.OldLace;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButton4.IconColor = System.Drawing.Color.Orange;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 35;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(4, 60);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iconButton4.Size = new System.Drawing.Size(207, 51);
            this.iconButton4.TabIndex = 7;
            this.iconButton4.Text = "العملاء";
            this.iconButton4.UseMnemonic = false;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton5.Font = new System.Drawing.Font("LBC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.OldLace;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            this.iconButton5.IconColor = System.Drawing.Color.Orange;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 35;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(4, 117);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iconButton5.Size = new System.Drawing.Size(207, 51);
            this.iconButton5.TabIndex = 8;
            this.iconButton5.Text = "الأصناف";
            this.iconButton5.UseMnemonic = false;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton6
            // 
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton6.Font = new System.Drawing.Font("LBC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.ForeColor = System.Drawing.Color.OldLace;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.iconButton6.IconColor = System.Drawing.Color.Orange;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 35;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(4, 174);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iconButton6.Size = new System.Drawing.Size(207, 51);
            this.iconButton6.TabIndex = 9;
            this.iconButton6.Text = "المبيعات";
            this.iconButton6.UseMnemonic = false;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // iconButton8
            // 
            this.iconButton8.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton8.Font = new System.Drawing.Font("LBC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton8.ForeColor = System.Drawing.Color.OldLace;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButton8.IconColor = System.Drawing.Color.Orange;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 35;
            this.iconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.Location = new System.Drawing.Point(4, 231);
            this.iconButton8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iconButton8.Size = new System.Drawing.Size(207, 51);
            this.iconButton8.TabIndex = 11;
            this.iconButton8.Text = "المشتريات";
            this.iconButton8.UseMnemonic = false;
            this.iconButton8.UseVisualStyleBackColor = true;
            // 
            // iconButton7
            // 
            this.iconButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton7.Font = new System.Drawing.Font("LBC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.Color.OldLace;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconButton7.IconColor = System.Drawing.Color.Orange;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 35;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(4, 288);
            this.iconButton7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iconButton7.Size = new System.Drawing.Size(207, 51);
            this.iconButton7.TabIndex = 10;
            this.iconButton7.Text = "التقارير";
            this.iconButton7.UseMnemonic = false;
            this.iconButton7.UseVisualStyleBackColor = true;
            // 
            // pn_infonav
            // 
            this.pn_infonav.Controls.Add(this.label2);
            this.pn_infonav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_infonav.Location = new System.Drawing.Point(0, 0);
            this.pn_infonav.Name = "pn_infonav";
            this.pn_infonav.Size = new System.Drawing.Size(210, 140);
            this.pn_infonav.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("LBC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "شركة الحكم التجارية";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pn_cont
            // 
            this.pn_cont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_cont.Controls.Add(this.pn_topbar);
            this.pn_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cont.Location = new System.Drawing.Point(0, 0);
            this.pn_cont.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pn_cont.Name = "pn_cont";
            this.pn_cont.Size = new System.Drawing.Size(1027, 562);
            this.pn_cont.TabIndex = 2;
            this.pn_cont.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_cont_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(52, 3);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(36, 37);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = " ";
            this.iconButton1.UseMnemonic = false;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alhkam Trading";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pn_topbar.ResumeLayout(false);
            this.pn_topbar.PerformLayout();
            this.pn_navbar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pn_infonav.ResumeLayout(false);
            this.pn_infonav.PerformLayout();
            this.pn_cont.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_topbar;
        private System.Windows.Forms.Panel pn_navbar;
        private System.Windows.Forms.Panel pn_cont;
        private System.Windows.Forms.Label lb_titlepage;
        private FontAwesome.Sharp.IconButton btn_min;
        private FontAwesome.Sharp.IconButton btn_close;
        private System.Windows.Forms.Panel pn_infonav;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

