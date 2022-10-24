using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using alhkam.EPL;
using alhkam.PL;

namespace alhkam.PL
{
    public partial class FRM_SUPP_ADD : Form
    {
        // init

        MPMContainer db = new MPMContainer();
        TB_Supp tb_supp = new TB_Supp();
        BL.methods methods = new BL.methods();
        //Toast toast = new Toast();
        Dialog dialog = new Dialog();
        PL.FRM_Supp frm_supp = new FRM_Supp();

        public int id;
        public FRM_SUPP_ADD()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (edt_name.Text == "")
            {
                
                Dialog dialog = new Dialog();
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "اسم الصنف مطلوب";
                dialog.Show();
            }
            else
            {
                if (id == 0)
                {
                    tb_supp.Supp_Name = edt_name.Text;
                    tb_supp.Supp_Phone = edt_phone.Text;
                    tb_supp.Supp_Email = edt_mail.Text;
                    tb_supp.Supp_address = edt_address.Text;
                    db.TB_Supp.Add(tb_supp);
                    db.SaveChanges();
                    Toast toast = new Toast();
                    toast.txt_caption.Text = "تم الاضافة بنجاح";
                    toast.Show();
                    db = new MPMContainer();
                    frm_supp.dataGridViewCat.DataSource = db.TB_Supp.ToList();
                }
                else
                {
                    // edit

                    tb_supp.Supp_Name = edt_name.Text;
                    tb_supp.Supp_Phone = edt_phone.Text;
                    tb_supp.Supp_Email = edt_mail.Text;
                    tb_supp.Supp_address = edt_address.Text;
                    tb_supp.ID = id;
                    db.Entry(tb_supp).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    Toast toast = new Toast();
                    toast.txt_caption.Text = "تم التعديل بنجاح";
                    toast.Show();
                    db = new MPMContainer();
                    frm_supp.dataGridViewCat.DataSource = db.TB_Supp.ToList();
                }
            }

            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
