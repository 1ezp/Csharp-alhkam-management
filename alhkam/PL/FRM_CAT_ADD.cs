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
    public partial class FRM_CAT_ADD : Form
    {
        // init

        MPMContainer db = new MPMContainer();
        TB_CAT tb_cat = new TB_CAT();
        BL.methods methods = new BL.methods();
        //Toast toast = new Toast();
        Dialog dialog = new Dialog();
        PL.FRM_Cat frm_cat = new FRM_Cat();

        public int id;
        public FRM_CAT_ADD()
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
                    tb_cat.CAT_Name = edt_name.Text;
                    db.TB_CAT.Add(tb_cat);
                    db.SaveChanges();
                    Toast toast = new Toast();
                    toast.txt_caption.Text = "تم الاضافة بنجاح";
                    toast.Show();
                    db = new MPMContainer();
                    frm_cat.dataGridViewCat.DataSource = db.TB_CAT.ToList();
                }
                else
                {
                    // edit

                    tb_cat.CAT_Name = edt_name.Text;
                    tb_cat.ID = id;
                    db.Entry(tb_cat).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    Toast toast = new Toast();
                    toast.txt_caption.Text = "تم التعديل بنجاح";
                    toast.Show();
                    db = new MPMContainer();
                    frm_cat.dataGridViewCat.DataSource = db.TB_CAT.ToList();
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
