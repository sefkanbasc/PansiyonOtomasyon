using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pansiyon1
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FS709P1;Initial Catalog=Pansiyon;Integrated Security=True");


        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            int personal;
            personal = Convert.ToInt16(textBox1.Text);
            LblPersonelToplam.Text=(personal*3000).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(LblKasaToplam.Text) - (Convert.ToInt32(LblPersonelToplam.Text) + Convert.ToInt32(LblAlinanaUrunler1.Text) + Convert.ToInt32(LblAlinanaUrunler2.Text) + Convert.ToInt16(LblAlinanaUrunler3.Text));

            LblSonuc.Text = sonuc.ToString();
          
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            //Kasadaki toplam Tutar
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand(" Select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {

                LblKasaToplam.Text = oku1["toplam"].ToString();

            }
            baglanti.Close();

            //Gıda Giderleri

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand(" Select sum(Gida) as toplam1 from Stok", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {

                LblAlinanaUrunler1.Text = oku2["toplam1"].ToString();

            }
            baglanti.Close();


            //İçecek Giderleri

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand(" Select sum(İcecek) as toplam2 from Stok", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {

                LblAlinanaUrunler2.Text = oku3["toplam2"].ToString();

            }
            baglanti.Close();

            //Cerez Giderleri

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand(" Select sum(Cerezler) as toplam3 from Stok", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {

                LblAlinanaUrunler3.Text = oku4["toplam3"].ToString();

            }
            baglanti.Close();


            



        }
    }
}
