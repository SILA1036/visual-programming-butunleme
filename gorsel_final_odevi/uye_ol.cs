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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gorsel_final_odevi
{
    public partial class uye_ol : Form
    {
        public uye_ol()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uye_girisi uye_Girisi = new uye_girisi();
            uye_Girisi.Show();
        }
        veritabani vtn = new veritabani();
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "")
            {

                if (checkBox1.Checked)
                {
                    

                        if (vtn.ekle(textBox2.Text, textBox5.Text,textBox3.Text, textBox4.Text, textBox1.Text) == 1)
                        {

                            MessageBox.Show("Veri eklendi");
                            this.Close();
                        }
                        else
                        {


                            MessageBox.Show("Veri eklenemedi");
                        }
                }
                else
                {
                    MessageBox.Show("Gizlilik şartlarını onaylayınız");
                }
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz");

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
