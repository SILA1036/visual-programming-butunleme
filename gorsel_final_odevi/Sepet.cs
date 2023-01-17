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
    public partial class Sepet : Form
    {
        public Sepet()
        {
            InitializeComponent();
        }
        veritabani vtn = new veritabani();
        void yukle_1()
        {
            vtn.con.Open();
            MySqlCommand cm = new MySqlCommand("select * from sepet where k_id='"+anasayfa.anf.k_id.ToString()+"'", vtn.con);
            MySqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["urun"]);
            }
            vtn.con.Close();
        }
        private void Sepet_Load(object sender, EventArgs e)
        {
            yukle_1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex!= -1)
            {
                int x = 0;
                vtn.con.Open();
                MySqlCommand cmd = new MySqlCommand("delete from  sepet where  k_id='" + anasayfa.anf.k_id.ToString() + "' and urun='" + listBox1.SelectedItem.ToString() + "'", vtn.con);
                x = cmd.ExecuteNonQuery();
                if (x == 1)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem.ToString());
                    MessageBox.Show("silindi");
                }
                vtn.con.Close();
            }
            
        }
    }
}
