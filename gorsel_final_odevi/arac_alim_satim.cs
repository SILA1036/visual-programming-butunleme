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
    public partial class arac_alim_satim : Form
    {
        public arac_alim_satim()
        {
            InitializeComponent();
        }

        veritabani vtn = new veritabani();

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }


        void yukle_1()
        {
            vtn.con.Open();
            MySqlCommand cm = new MySqlCommand("select * from araclar ", vtn.con);
            MySqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                guna2ComboBox1.Items.Add(dr["arac_ad"]);
            }
            vtn.con.Close();
        }

        void yukle_2()
        {
            if (guna2ComboBox2.SelectedIndex != -1)
            {

                listBox1.Items.Clear();
                int x = 0;
                if (guna2ComboBox2.SelectedItem.ToString() == "SIFIR")
                    x = 0;
                else
                    x = 1;

                vtn.con.Open();
                MySqlCommand cm = new MySqlCommand("select * from araclar where  sifir_ikinci='" + x.ToString() + "'", vtn.con);
                MySqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    listBox1.Items.Add(dr["arac_ad"]);
                }
                vtn.con.Close();

            }
        }


        private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            aracparcalari a_i_g = new aracparcalari();
            a_i_g.Show();

        }

        private void arac_alim_satim_Load(object sender, EventArgs e)
        {
            yukle_1();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            yukle_2();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            yukle_2();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)
            {
                if (vtn.ekle_sepet(listBox1.SelectedItem.ToString(), anasayfa.anf.k_id.ToString()) == 1)
                {
                    MessageBox.Show("Sepete Eklendi");
                }
            }
        }
    }
}
