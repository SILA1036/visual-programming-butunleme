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

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
      

        }

        private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            aracparcalari a_i_g = new aracparcalari();
            a_i_g.Show();

        }
    }
}
