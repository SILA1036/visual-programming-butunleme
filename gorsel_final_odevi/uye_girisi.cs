using MySql.Data.MySqlClient;
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
    public partial class uye_girisi : Form
    {
        public uye_girisi()
        {
            InitializeComponent();
        }

        veritabani vtnn = new veritabani();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           uye_ol uye_Ol = new uye_ol();
            uye_Ol.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vtnn.con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from uyeler where tel='" + textBox1.Text + "' and sifre='" + textBox2.Text + "'", vtnn.con);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                anasayfa.anf.linkLabel6.Visible = false;
                anasayfa.anf.linkLabel5.Visible = false;
                anasayfa.anf.linkLabel13.Visible = true;
                anasayfa.anf.giris_yaptimi = true;
                anasayfa.anf.k_id = (int)dr["id"];
                int yetki = (int)dr["yetkisi"];
                if (yetki == 1)
                {
                    anasayfa.anf.label1.Text = "Hoşgeldin Admin";
                    anasayfa.anf.giris_yetkisi = true;
                    anasayfa.anf.linkLabel16.Visible = true;

                }
                else
                {
                    anasayfa.anf.label1.Text = "Hoşgeldin Üyemiz";
                    anasayfa.anf.giris_yetkisi = false;
                    anasayfa.anf.linkLabel16.Visible = false;

                }
              
                this.Close();
               

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
              
            vtnn.con.Close();

        }
    }
}
