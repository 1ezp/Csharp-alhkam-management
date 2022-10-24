
namespace alhkam.PL
{
    partial class FRM_SUPP_ADD
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
            this.btn_add = new FontAwesome.Sharp.IconButton();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.btn_close = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btn_add.FlatAppearance.BorderSize = 2;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("LBC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_add.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_add.IconColor = System.Drawing.Color.Black;
            this.btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add.Location = new System.Drawing.Point(152, 383);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(153, 48);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "إضافة";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // edt_name
            // 
            this.edt_name.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.edt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edt_name.Font = new System.Drawing.Font("LBC", 20.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.ForeColor = System.Drawing.Color.White;
            this.edt_name.Location = new System.Drawing.Point(33, 131);
            this.edt_name.Name = "edt_name";
            this.edt_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.edt_name.Size = new System.Drawing.Size(294, 35);
            this.edt_name.TabIndex = 2;
            this.edt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_titlepage.AutoSize = true;
            this.lb_titlepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_titlepage.Font = new System.Drawing.Font("LBC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titlepage.ForeColor = System.Drawing.SystemColors.Info;
            this.lb_titlepage.Location = new System.Drawing.Point(339, 129);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(131, 35);
            this.lb_titlepage.TabIndex = 7;
            this.lb_titlepage.Text = "اسم المورد";
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btn_close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_close.IconSize = 29;
            this.btn_close.Location = new System.Drawing.Point(13, 12);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(29, 23);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = " ";
            this.btn_close.UseMnemonic = false;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("LBC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(342, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "رقم الهاتف";
            // 
            // edt_phone
            // 
            this.edt_phone.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.edt_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edt_phone.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_phone.ForeColor = System.Drawing.Color.White;
            this.edt_phone.Location = new System.Drawing.Point(32, 186);
            this.edt_phone.Name = "edt_phone";
            this.edt_phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.edt_phone.Size = new System.Drawing.Size(294, 37);
            this.edt_phone.TabIndex = 9;
            this.edt_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("LBC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(400, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "ايميل";
            // 
            // edt_mail
            // 
            this.edt_mail.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.edt_mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edt_mail.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_mail.ForeColor = System.Drawing.Color.White;
            this.edt_mail.Location = new System.Drawing.Point(32, 243);
            this.edt_mail.Name = "edt_mail";
            this.edt_mail.Size = new System.Drawing.Size(294, 37);
            this.edt_mail.TabIndex = 9;
            this.edt_mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("LBC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(138, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "اضافة مورد جديد";
            // 
            // edt_address
            // 
            this.edt_address.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.edt_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edt_address.Font = new System.Drawing.Font("LBC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_address.ForeColor = System.Drawing.Color.White;
            this.edt_address.Location = new System.Drawing.Point(32, 300);
            this.edt_address.Name = "edt_address";
            this.edt_address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.edt_address.Size = new System.Drawing.Size(294, 41);
            this.edt_address.TabIndex = 9;
            this.edt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("LBC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(381, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "العنوان";
            // 
            // FRM_SUPP_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(482, 456);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edt_address);
            this.Controls.Add(this.edt_mail);
            this.Controls.Add(this.edt_phone);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_titlepage);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_SUPP_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_CAT_ADD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_titlepage;
        private FontAwesome.Sharp.IconButton btn_close;
        public FontAwesome.Sharp.IconButton btn_add;
        public System.Windows.Forms.TextBox edt_name;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox edt_phone;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox edt_mail;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox edt_address;
        private System.Windows.Forms.Label label4;
    }
}