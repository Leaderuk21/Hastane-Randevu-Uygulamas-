using entitylayer;
using LOGİCLAYER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATAACCESSLAYER;

namespace HASTANE_UYGULAMA
{
    public partial class Doktorişlemleri : Form
    {
        public Doktorişlemleri()
        {
            InitializeComponent();
        }
        private void listeleme(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                textBox6.Text = selectedRow.Cells[0].Value.ToString();
                textBox1.Text = selectedRow.Cells[1].Value.ToString();
                textBox2.Text = selectedRow.Cells[2].Value.ToString();
                comboBox1.Text = selectedRow.Cells[3].Value.ToString();
                textBox3.Text = selectedRow.Cells[4].Value.ToString();
                textBox4.Text = selectedRow.Cells[5].Value.ToString();
                textBox5.Text = selectedRow.Cells[6].Value.ToString();
            }
        }
        private void label8_Click_1(object sender, EventArgs e)
        {
            Sekreteranasayfa Sekreteranasayfa = new Sekreteranasayfa();
            Sekreteranasayfa.Show();
            this.Hide();

        }

        private void Doktorişlemleri_Load_1(object sender, EventArgs e)
        {
            List<string> bolumListesi = new List<string>();
            bolumListesi.Add("Kardiyoloji");
            bolumListesi.Add("Ortopedi");
            bolumListesi.Add("Dahiliye");
            bolumListesi.Add("Genel Cerrahi");
            bolumListesi.Add("Psikiyatri");
            bolumListesi.Add("Kulak-Burun-Boğaz");
            bolumListesi.Add("Kadın Hastalıkları");
            bolumListesi.Add("Kadın Doğum");
            bolumListesi.Add("Üroloji");
            bolumListesi.Add("Dahiliye");
            bolumListesi.Add("Çocuk Hastalıkları");
            bolumListesi.Add("Aile Hekimi");
            comboBox1.DataSource = bolumListesi;
            dataGridView1.CellClick += new DataGridViewCellEventHandler(listeleme);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<entitydoktor> docList = logicdoktor.LLDocList();
            dataGridView1.DataSource = docList;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            entitydoktor ent = new entitydoktor();
            ent.Doctorad = textBox1.Text;
            ent.Doktorsoyad = textBox2.Text;
            ent.Doktoralan = comboBox1.Text;
            ent.Doktortel = textBox3.Text;
            ent.Doktorkullanıcıadı = textBox4.Text;
            ent.Doctorşifre = textBox5.Text;
            logicdoktor.LLDocEkle(ent);

            List<entitydoktor> docList = logicdoktor.LLDocList();
            dataGridView1.DataSource = docList;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" +
             "" || comboBox1.Text == "" || textBox4.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Hiçbir Alan Boş Bırakılamaz", "!!!");
            }
            else
            {
                if (int.TryParse(textBox6.Text, out int dokıd))
                {
                    entitydoktor ent = new entitydoktor();
                    ent.Doktorıd = dokıd;
                    ent.Doctorad = textBox1.Text;
                    ent.Doktorsoyad = textBox2.Text;
                    ent.Doktoralan = comboBox1.Text;
                    ent.Doktortel = textBox3.Text;
                    ent.Doktorkullanıcıadı = textBox4.Text;
                    ent.Doctorşifre = textBox5.Text;
                    logicdoktor.LLDocGuncelle(ent);

                    List<entitydoktor> docList = logicdoktor.LLDocList();
                    dataGridView1.DataSource = docList;
                }
                else
                {
                    MessageBox.Show("Geçersiz doktor ID değeri. Lütfen geçerli bir ID girin.", "Hata");
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox6.Text, out int dokıd))
            {
                logicdoktor.LLDocSil(dokıd);

                List<entitydoktor> docList = logicdoktor.LLDocList();
                dataGridView1.DataSource = docList;
            }
            else
            {
                MessageBox.Show("Geçersiz doktor ID değeri. Lütfen geçerli bir ID girin.", "Hata");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            int maxLength = 11;
            if (textBox3.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}



