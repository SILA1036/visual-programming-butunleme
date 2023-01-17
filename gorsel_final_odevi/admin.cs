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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        veritabani vtn = new veritabani();
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int x = 0;
            if (comboBox1.SelectedItem.ToString() == "SIFIR")
                x = 0;
            else
                x = 1;

            if (textBox1.Text !="")
            {
                if (vtn.ekle_arac(textBox1.Text, x.ToString()) == 1)
                {
                    MessageBox.Show("Araç Eklendi");
                    yukle();
                }
            }
        }

        private void admin_Load(object sender, EventArgs e)
        {
            yukle();
        }

        void yukle()
        {
            listBox1.Items.Clear();
            vtn.con.Open();
            MySqlCommand cm = new MySqlCommand("select * from uyeler", vtn.con);
            MySqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["ad"]+" "+dr["ad"]);
            }
            vtn.con.Close();
        }
    }
}
