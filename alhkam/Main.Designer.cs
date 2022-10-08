
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.btn_min = new FontAwesome.Sharp.IconButton();
            this.btn_close = new FontAwesome.Sharp.IconButton();
            this.pn_navbar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_home = new FontAwesome.Sharp.IconButton();
            this.btn_agents = new FontAwesome.Sharp.IconButton();
            this.btn_cat = new FontAwesome.Sharp.IconButton();
            this.btn_sale = new FontAwesome.Sharp.IconButton();
            this.btn_buy = new FontAwesome.Sharp.IconButton();
            this.btn_reports = new FontAwesome.Sharp.IconButton();
            this.pn_infonav = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_cont = new System.Windows.Forms.Panel();
            this.pn_topbar.SuspendLayout();
            this.pn_navbar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pn_infonav.SuspendLayout();
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
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButton1.IconColor = System.Drawing.Color.Orange;
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
            this.btn_min.IconColor = System.Drawing.Color.Orange;
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
            this.flowLayoutPanel1.Controls.Add(this.btn_home);
            this.flowLayoutPanel1.Controls.Add(this.btn_agents);
            this.flowLayoutPanel1.Controls.Add(this.btn_cat);
            this.flowLayoutPanel1.Controls.Add(this.btn_sale);
            this.flowLayoutPanel1.Controls.Add(this.btn_buy);
            this.flowLayoutPanel1.Controls.Add(this.btn_reports);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 140);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 422);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_home
            // 
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_home.Font = new System.Drawing.Font("LBC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.OldLace;
            this.btn_home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_home.IconColor = System.Drawing.Color.Orange;
            this.btn_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_home.IconSize = 35;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(4, 3);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_home.Size = new System.Drawing.Size(207, 51);
            this.btn_home.TabIndex = 6;
            this.btn_home.Text = " الرئيسة";
            this.btn_home.UseMnemonic = false;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_agents
            // 
            this.btn_agents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_agents.FlatAppearance.BorderSize = 0;
            this.btn_agents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agents.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_agents.Font = new System.Drawing.Font("LBC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agents.ForeColor = System.Drawing.Color.OldLace;
            this.btn_agents.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btn_agents.IconColor = System.Drawing.Color.Orange;
            this.btn_agents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_agents.IconSize = 35;
            this.btn_agents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agents.Location = new System.Drawing.Point(4, 60);
            this.btn_agents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_agents.Name = "btn_agents";
            this.btn_agents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_agents.Size = new System.Drawing.Size(207, 51);
            this.btn_agents.TabIndex = 7;
            this.btn_agents.Text = "العملاء";
            this.btn_agents.UseMnemonic = false;
            this.btn_agents.UseVisualStyleBackColor = true;
            this.btn_agents.Click += new System.EventHandler(this.btn_agents_Click);
            // 
            // btn_cat
            // 
            this.btn_cat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cat.FlatAppearance.BorderSize = 0;
            this.btn_cat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_cat.Font = new System.Drawing.Font("LBC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat.ForeColor = System.Drawing.Color.OldLace;
            this.btn_cat.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            this.btn_cat.IconColor = System.Drawing.Color.Orange;
            this.btn_cat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cat.IconSize = 35;
            this.btn_cat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cat.Location = new System.Drawing.Point(4, 117);
            this.btn_cat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_cat.Name = "btn_cat";
            this.btn_cat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_cat.Size = new System.Drawing.Size(207, 51);
            this.btn_cat.TabIndex = 8;
            this.btn_cat.Text = "الأصناف";
            this.btn_cat.UseMnemonic = false;
            this.btn_cat.UseVisualStyleBackColor = true;
            this.btn_cat.Click += new System.EventHandler(this.btn_cat_Click);
            // 
            // btn_sale
            // 
            this.btn_sale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sale.FlatAppearance.BorderSize = 0;
            this.btn_sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sale.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_sale.Font = new System.Drawing.Font("LBC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sale.ForeColor = System.Drawing.Color.OldLace;
            this.btn_sale.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btn_sale.IconColor = System.Drawing.Color.Orange;
            this.btn_sale.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_sale.IconSize = 35;
            this.btn_sale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sale.Location = new System.Drawing.Point(4, 174);
            this.btn_sale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_sale.Name = "btn_sale";
            this.btn_sale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_sale.Size = new System.Drawing.Size(207, 51);
            this.btn_sale.TabIndex = 9;
            this.btn_sale.Text = "المبيعات";
            this.btn_sale.UseMnemonic = false;
            this.btn_sale.UseVisualStyleBackColor = true;
            // 
            // btn_buy
            // 
            this.btn_buy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_buy.FlatAppearance.BorderSize = 0;
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_buy.Font = new System.Drawing.Font("LBC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy.ForeColor = System.Drawing.Color.OldLace;
            this.btn_buy.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btn_buy.IconColor = System.Drawing.Color.Orange;
            this.btn_buy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_buy.IconSize = 35;
            this.btn_buy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buy.Location = new System.Drawing.Point(4, 231);
            this.btn_buy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_buy.Size = new System.Drawing.Size(207, 51);
            this.btn_buy.TabIndex = 11;
            this.btn_buy.Text = "المشتريات";
            this.btn_buy.UseMnemonic = false;
            this.btn_buy.UseVisualStyleBackColor = true;
            // 
            // btn_reports
            // 
            this.btn_reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reports.FlatAppearance.BorderSize = 0;
            this.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reports.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_reports.Font = new System.Drawing.Font("LBC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.ForeColor = System.Drawing.Color.OldLace;
            this.btn_reports.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btn_reports.IconColor = System.Drawing.Color.Orange;
            this.btn_reports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_reports.IconSize = 35;
            this.btn_reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reports.Location = new System.Drawing.Point(4, 288);
            this.btn_reports.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_reports.Size = new System.Drawing.Size(207, 51);
            this.btn_reports.TabIndex = 10;
            this.btn_reports.Text = "التقارير";
            this.btn_reports.UseMnemonic = false;
            this.btn_reports.UseVisualStyleBackColor = true;
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
            this.pn_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cont.Location = new System.Drawing.Point(0, 57);
            this.pn_cont.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pn_cont.Name = "pn_cont";
            this.pn_cont.Size = new System.Drawing.Size(1027, 505);
            this.pn_cont.TabIndex = 2;
            this.pn_cont.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_cont_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 562);
            this.Controls.Add(this.pn_cont);
            this.Controls.Add(this.pn_topbar);
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
        private FontAwesome.Sharp.IconButton btn_home;
        private FontAwesome.Sharp.IconButton btn_agents;
        private FontAwesome.Sharp.IconButton btn_cat;
        private FontAwesome.Sharp.IconButton btn_sale;
        private FontAwesome.Sharp.IconButton btn_reports;
        private FontAwesome.Sharp.IconButton btn_buy;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

