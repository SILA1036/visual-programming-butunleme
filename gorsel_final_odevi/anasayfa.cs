using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorsel_final_odevi
{
    public partial class anasayfa : Form
    {

        public static anasayfa anf;
        public bool giris_yaptimi;
        public bool giris_yetkisi;
        public int k_id;
        public anasayfa()
        {
            InitializeComponent();
            anf = this;
        }

         



        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uye_girisi uye_Girisi = new uye_girisi();
            uye_Girisi.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uye_ol uye_Ol = new uye_ol();   
            uye_Ol.Show();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            if (giris_yaptimi)
            {
                linkLabel13.Visible = true;
            }
            else
            {
                linkLabel13.Visible = false;
            }

        }

        private void aracınızıSatınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void otomobilToolStripMenuItem_Click(object sender, EventArgs e)
        {
           panel2.Controls.Clear();
            otomobil oto = new otomobil();
            oto.TopLevel=false;
            panel2.Controls.Add(oto);
            oto.Show    ();
            oto.Dock = DockStyle.Fill;  
            oto.BringToFront();



            //otomobil ot = new otomobil();
            //ot.Show();

            //if (giris_yaptimi)
            //{

            //    arac_alim_satim arac_Alim_Satim = new arac_alim_satim();
            //    arac_Alim_Satim.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen önce giriş yapın");
            //}

        }

        private void araçParçalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (giris_yaptimi)
            {
                aracparcalari arcp = new aracparcalari();
                arcp.Show();
            }
            else
            {
                MessageBox.Show("Lütfen önce giriş yapın");
            }




        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           hakkimizda hkm = new hakkimizda();   
            hkm.Show();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            vergi hkm = new vergi();
            hkm.Show();
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Application.Exit();
        }

        private void sEPETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (giris_yaptimi)
            {
                Sepet hkm = new Sepet();
                hkm.Show();
            }
            else
            {
              MessageBox.Show("Lütfen önce giriş yapın");
            }


     
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //admin hkm = new admin();
            //hkm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin hkm = new admin();
            hkm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
