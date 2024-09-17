using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entitylayer;
using LOGİCLAYER;

namespace HASTANE_UYGULAMA
{
    public partial class Sekreterlogin : Form
    {
        public Sekreterlogin()
        {
            InitializeComponent();
        }              
        private void label2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(@"Kullanıcı Adınız"))
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "Kullanıcı Adınız")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(@""))
            {
                textBox1.Text = "Kullanıcı Adınız";
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Kullanıcı Adınız";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter_1(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(@"********"))
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
            }
            if (textBox2.Text == "********")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Gray;
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox2_Leave_1(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(@""))
            {
                textBox2.Text = "********";
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "********";
                textBox2.ForeColor = Color.Gray;
                textBox2.PasswordChar = '\0';
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Genel_Giriş loginScreen = new Genel_Giriş();
            loginScreen.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            entitysekreter ent = new entitysekreter();
            ent.Sekreterkullanıcıadı = textBox1.Text;
            ent.Sekreterşifre = textBox2.Text;
            if (textBox1.Text == "Kullanıcı Adınız" || textBox2.Text == "********")
            {
                MessageBox.Show("Kullanıcı Adı ya da şifre boş bırakılamaz!!");
            }
            else
            {
                if (logicsekreter.LLSecGiris(ent) == 1)
                {
                    Sekreteranasayfa sekreteranasayfa = new Sekreteranasayfa();
                    sekreteranasayfa.Show();
                    this.Close();
                }
                else if (logicsekreter.LLSecGiris(ent) == 2)
                {
                    MessageBox.Show("Kullanıcı adı ya da şifreniz hatalıdır. Lütfen kullanıcı adınızı ya da şifrenizi kontrol ediniz!");
                }
            }
        }
    }
}
