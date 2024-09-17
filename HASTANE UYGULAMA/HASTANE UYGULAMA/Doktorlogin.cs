using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using entitylayer;
using DATAACCESSLAYER;
using LOGİCLAYER;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace HASTANE_UYGULAMA
{
    public partial class Doktorlogin : Form
    {
        public Doktorlogin()
        {
            InitializeComponent();
        }
      
        private void label2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Kullanıcı Adınız")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Kullanıcı Adınız";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "********")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox2_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "********";
                textBox2.PasswordChar = '\0';
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            entitydoktor ent = new entitydoktor();
            ent.Doktorkullanıcıadı = textBox1.Text;
            ent.Doctorşifre = textBox2.Text;
            if (textBox1.Text == "Kullanıcı Adınız" || textBox2.Text == "********")
            {
                MessageBox.Show("Kullanıcı Adı ya da şifre boş bırakılamaz!!");
            }
            else
            {
                if (logicdoktor.LLDoktorGiris(ent) == 1)
                {
                    OleDbCommand a = logicdoktor.LLDoktorAdıCek(ent);
                    string ad = (string)a.ExecuteScalar();
                    OleDbCommand b = logicdoktor.LLDoktorSoyadıCek(ent);
                    string soyad = (string)b.ExecuteScalar();

                    Doktoranasayfa doktoranasayfa = new Doktoranasayfa();
                    doktoranasayfa.doctorad = ad;
                    doktoranasayfa.doktorsoyad = soyad;
                    doktoranasayfa.Show();
                    this.Hide();
                }
                else if (logicdoktor.LLDoktorGiris(ent) == 2)
                {
                    MessageBox.Show("Kullanıcı adı ya da şifreniz hatalıdır. Lütfen kullanıcı adınızı ya da şifrenizi kontrol ediniz!");
                }
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Genel_Giriş loginScreen = new Genel_Giriş();
            loginScreen.Show();
            this.Hide();
        }
    }
}
  
