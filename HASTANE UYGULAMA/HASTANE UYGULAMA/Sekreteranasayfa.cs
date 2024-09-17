using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASTANE_UYGULAMA
{
    public partial class Sekreteranasayfa : Form
    {
        public Sekreteranasayfa()
        {
            InitializeComponent();
        }       
        private void label2_Click_1(object sender, EventArgs e)
        {
            Genel_Giriş loginScreen = new Genel_Giriş();
            loginScreen.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Randevugüncelle hstislem = new Randevugüncelle();
            hstislem.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Randevuoluştur rndal = new Randevuoluştur();
            rndal.Show();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Doktorişlemleri docislem = new Doktorişlemleri();
            docislem.Show();
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Sekreterişlemleri sekreter = new Sekreterişlemleri();
            sekreter.Show();
            this.Close();
        }
    }
}
