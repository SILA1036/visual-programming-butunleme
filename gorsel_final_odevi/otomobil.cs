using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace gorsel_final_odevi
{
    public partial class otomobil : Form
    {
        public otomobil()
        {
            InitializeComponent();
        }
        private const string api = "b87d124450c2c1d68a146fceec3d1a63";
        // hava durumu bilgileri bir alt satırdaki web adresinden çekilecektir
        private const string baglanti = "http://api.openweathermap.org/data/2.5/weather?q=Turkey,Ankara&mode=xml&units=metric&APPID=" + api;

        private void otomobil_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            XDocument Hava = XDocument.Load(baglanti);
            var Sicaklik = Hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            label3.Text = Sicaklik.ToString() + "°";

            //aşağıda yazılan kod satırları için bu siteden faydalanıyoruz.
            var Durum = Hava.Descendants("clouds").ElementAt(0).Attribute("name").Value;
            label4.Text = Durum.ToString();
            pictureBox1.ImageLocation = "https://w7.pngwing.com/pngs/656/864/png-transparent-weather-forecasting-cloud-overcast-wind-cloud-heart-weather-forecasting.png";
            pictureBox2.ImageLocation = "https://w7.pngwing.com/pngs/533/833/png-transparent-weather-forecasting-computer-icons-android-cloudy-angle-cloud-weather-forecasting.png";
            pictureBox3.ImageLocation = "https://w7.pngwing.com/pngs/642/891/png-transparent-weather-forecasting-computer-icons-meteorology-sun-cloud-weather-forecasting-meteorology.png";
            if (Durum.Contains("clouds") == true)
            {
                pictureBox1.Visible = true;
            }
            if (Durum.Contains("clear sky") == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            if (Durum.Contains("sun") == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
