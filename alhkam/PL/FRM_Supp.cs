using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using alhkam.PL;
using alhkam.EPL;

namespace alhkam.PL
{
    public partial class FRM_Supp : Form
    {
        public FRM_Supp()
        {
            InitializeComponent();
            dataGridViewCat.DataSource = db.TB_Supp.ToList();
        }
        MPMContainer db = new MPMContainer();
        TB_Supp tb_supp = new TB_Supp();
        int id;


        
      
        public void Update_cat()
        {
            db = new MPMContainer();
            dataGridViewCat.DataSource = db.TB_Supp.ToList();
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            PL.FRM_SUPP_ADD frm_add = new FRM_SUPP_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void btn_upadte_Click(object sender, EventArgs e)
        {
            Update_cat();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //var id = dataGridViewCat.SelectedRows[0].Cells[0].Value.ToString();
            if(dataGridViewCat.SelectedRows.Count >= 0){

                var rs = MessageBox.Show("هل انت متاكد من عملية الحذف", "عملية حذف", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridViewCat.CurrentRow.Cells[0].Value.ToString());
                    tb_supp = db.TB_Supp.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(tb_supp).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    Update_cat();
                }

            }
            else
            {
                Dialog dialog = new Dialog();
                dialog.txt_caption.Text = "يرجى تحديد مورد لحذفة";
                dialog.Show();
            }
            
            


        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridViewCat.SelectedRows.Count >= 0)
            {
                PL.FRM_SUPP_ADD frm_add = new FRM_SUPP_ADD();
                id = Convert.ToInt32(dataGridViewCat.CurrentRow.Cells[0].Value.ToString());
                frm_add.id = id;
                tb_supp = db.TB_Supp.Where(x => x.ID == id).FirstOrDefault();
                frm_add.edt_name.Text = tb_supp.Supp_Name.ToString();
                frm_add.edt_phone.Text = tb_supp.Supp_Phone.ToString();
                frm_add.edt_mail.Text = tb_supp.Supp_Email.ToString();
                frm_add.edt_address.Text = tb_supp.Supp_address .ToString();
                frm_add.btn_add.Text = "تعديل";
                frm_add.Show();
            }
            else
            {
                Dialog dialog = new Dialog();
                dialog.txt_caption.Text = "يرجى تحديد صنف لتعديله";
                dialog.Show();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var search = edt_search.Text;
            dataGridViewCat.DataSource = db.TB_CAT.Where(x => x.CAT_Name.Contains(search)).ToList();
        }
    }
}
