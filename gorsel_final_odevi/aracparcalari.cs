using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gorsel_final_odevi
{
    public partial class aracparcalari : Form
    {
        public aracparcalari()
        {
            InitializeComponent();
        }
        veritabani vtn = new veritabani();


        void yukle_1()
        {
            vtn.con.Open();
            MySqlCommand cm = new MySqlCommand("select * from parcalar where id='1'",vtn.con);
            MySqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                richTextBox1.Text = dr["detay"].ToString();
                textBox1.Text = dr["fiyat"].ToString() +" TL";
            }
            vtn.con.Close();
        }
        void yukle_2()
        {
            vtn.con.Open();
            MySqlCommand cm = new MySqlCommand("select * from parcalar where id='2'", vtn.con);
            MySqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                richTextBox2.Text = dr["detay"].ToString();
                textBox2.Text = dr["fiyat"].ToString() + " TL";
            }
            vtn.con.Close();
        }

        void yukle_3()
        {
            vtn.con.Open();
            MySqlCommand cm = new MySqlCommand("select * from parcalar where id='3'", vtn.con);
            MySqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                richTextBox3.Text = dr["detay"].ToString();
                textBox3.Text = dr["fiyat"].ToString() + " TL";
            }
            vtn.con.Close();
        }
        void yukle_4()
        {
            vtn.con.Open();
            MySqlCommand cm = new MySqlCommand("select * from parcalar where id='4'", vtn.con);
            MySqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                richTextBox4.Text = dr["detay"].ToString();
                textBox4.Text = dr["fiyat"].ToString() + " TL";
            }
            vtn.con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void aracparcalari_Load(object sender, EventArgs e)
        {
            yukle_1();
            yukle_2();
            yukle_3();
            yukle_4();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (vtn.ekle_sepet("Tekerlek", anasayfa.anf.k_id.ToString()) == 1)
            {
                MessageBox.Show("Sepete Eklendi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vtn.ekle_sepet("Akü", anasayfa.anf.k_id.ToString()) == 1)
            {
                MessageBox.Show("Sepete Eklendi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (vtn.ekle_sepet("Direksiyon", anasayfa.anf.k_id.ToString()) == 1)
            {
                MessageBox.Show("Sepete Eklendi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (vtn.ekle_sepet("Motor", anasayfa.anf.k_id.ToString()) == 1)
            {
                MessageBox.Show("Sepete Eklendi");
            }
        }
    }
}
