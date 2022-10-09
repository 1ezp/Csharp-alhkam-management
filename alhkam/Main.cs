using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace alhkam
{
    public partial class Main : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessge(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        MPMContainer db = new MPMContainer();
        public PL.FRM_Cat frm_cat = new PL.FRM_Cat();
        PL.FRM_Supp frm_supp = new PL.FRM_Supp();
        PL.FRM_Agents frm_agents = new PL.FRM_Agents();
        PL.FRM_Home frm_home = new PL.FRM_Home();



        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
            
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.pn_home);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pn_cont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        

        private void pn_topbar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessge(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(WindowState== FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            lb_titlepage.Text = "الرئيسة";
            pn_cont.Controls.Add(frm_home.pn_home);
        }

        private void btn_agents_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            lb_titlepage.Text = "العملاء";
            //frm_cat.dataGridViewCat.DataSource = db.TB_CAT.ToList();
            pn_cont.Controls.Add(frm_agents.pn_cat);
        }

        private void btn_cat_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            lb_titlepage.Text = "الاصناف";
            frm_cat.dataGridViewCat.DataSource = db.TB_CAT.ToList();
            pn_cont.Controls.Add(frm_cat.pn_cat);
        }

        private void btn_supp_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            lb_titlepage.Text = "الموردين";
            //frm_cat.dataGridViewCat.DataSource = db.TB_CAT.ToList();
            pn_cont.Controls.Add(frm_supp.pn_cat);
        }
    }
}
