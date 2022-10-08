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
    public partial class FRM_Cat : Form
    {
        public FRM_Cat()
        {
            InitializeComponent();
        }
        MPMContainer db = new MPMContainer();
        TB_CAT tb_cat = new TB_CAT();
        int id;


        private void FRM_Cat_Load(object sender, EventArgs e)
        {
            Update_cat();

        }
      
        public void Update_cat()
        {
            db = new MPMContainer();
            dataGridViewCat.DataSource = db.TB_CAT.ToList();
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            PL.FRM_CAT_ADD frm_add = new FRM_CAT_ADD();
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
                    tb_cat = db.TB_CAT.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(tb_cat).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    Update_cat();
                }

            }
            else
            {
                Dialog dialog = new Dialog();
                dialog.txt_caption.Text = "يرجى تحديد صنف لحذفة";
                dialog.Show();
            }
            
            


        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridViewCat.SelectedRows.Count >= 0)
            {
                PL.FRM_CAT_ADD frm_add = new FRM_CAT_ADD();
                id = Convert.ToInt32(dataGridViewCat.CurrentRow.Cells[0].Value.ToString());
                frm_add.id = id;
                tb_cat = db.TB_CAT.Where(x => x.ID == id).FirstOrDefault();
                frm_add.edt_name.Text = tb_cat.CAT_Name.ToString();
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
