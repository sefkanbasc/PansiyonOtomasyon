using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon1
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void BtnAdminGiris_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            
        }

        private void BtnYeniMusteri_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
        }

        private void BtnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vegas Pansiyon Kayıt Uygulması / 2022 ");
        }

        private void BtnOdalar_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGelirGİder_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
        }

        private void BtnStok_Click(object sender, EventArgs e)
        {
            FrmStok fr = new FrmStok();
            fr.Show();
        }

        private void BtnRadyoDinle_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle fr = new FrmRadyoDinle();
            fr.Show();
        }
    }
}
