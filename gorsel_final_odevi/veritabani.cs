using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace gorsel_final_odevi
{
    internal class veritabani
    {


      public MySqlConnection con = new MySqlConnection("Server=localhost;Database=otomobil_;Uid=root;Pwd=q_a_v_z1485#^6;");
       // public MySqlConnection con = new MySqlConnection("Server=localhost;Database=otomobil_;Uid=root;Pwd=;");

        public int ekle_arac(string arac, string sifir)
        {
            int x = 0;
            con.Open();
            MySqlCommand cmd = new MySqlCommand("insert into araclar (arac_ad,sifir_ikinci)values('" + arac + "','" + sifir + "')", con);
            x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }

        public int ekle_sepet(string urun, string k_id)
        {
            int x = 0;
            con.Open();
            MySqlCommand cmd = new MySqlCommand("insert into sepet (urun,k_id)values('" + urun + "','" + k_id + "')", con);
            x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }

        public int ekle(string adi, string soyad, string eposta, string sifre,string tel)
        {
            int x = 0;
            con.Open();
            MySqlCommand cmd = new MySqlCommand("insert into uyeler (ad,soyad,eposta,sifre,tel,yetkisi)values('"+adi+"','"+soyad+"','"+eposta+"','"+sifre+"','"+tel+"','0')", con);
            x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }

        public string giris(string tel, string sifre)
        {
            string x ="";
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from uyeler where tel='"+ tel + "' and sifre='"+sifre+"'",con);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
                x = dr["ad"].ToString(); 
            else
                x = "";
            con.Close();
            return x;
        }

    }
}
