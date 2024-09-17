using System;
using System.Windows.Forms;

namespace HASTANE_UYGULAMA
{
    public partial class Doktoranasayfa : Form
    {
        public Doktoranasayfa()
        {
            InitializeComponent();
        }

        public string doctorad;
        public string doktorsoyad;

        private void Doktoranasayfa_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(doctorad) || string.IsNullOrEmpty(doktorsoyad))
            {
                MessageBox.Show("Doktor adı veya soyadı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            label3.Text = doctorad + " " + doktorsoyad;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hastarapor hastaislem = new Hastarapor();

            hastaislem.doktorad = this.doctorad;
            hastaislem.doktorsoyad = this.doktorsoyad;
            hastaislem.Show();

            this.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Genel_Giriş loginScreen = new Genel_Giriş();
            loginScreen.Show();
            this.Close();
        }     
    }
}
