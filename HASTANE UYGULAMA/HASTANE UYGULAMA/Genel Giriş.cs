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
    public partial class Genel_Giriş : Form
    {
        public Genel_Giriş()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Sekreterlogin loginScreen = new Sekreterlogin();
            loginScreen.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Doktorlogin loginScreen = new Doktorlogin();
            loginScreen.Show();
            this.Hide();
        }
    }
}
