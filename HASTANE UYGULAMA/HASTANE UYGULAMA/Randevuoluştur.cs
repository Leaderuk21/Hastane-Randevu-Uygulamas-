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
using entitylayer;
using LOGİCLAYER;
using DATAACCESSLAYER;
using System.Data.SqlClient;

namespace HASTANE_UYGULAMA
{
    public partial class Randevuoluştur : Form
    {
        public Randevuoluştur()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" +
                "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "")
            {
                MessageBox.Show("Hiçbir alan boş bırakılamaz!!!");
            }
            else
            {
                entityhasta ent = new entityhasta();
                ent.Hastaad = textBox1.Text;
                ent.Hastasoyad = textBox2.Text;
                ent.Hastatc = textBox3.Text;
                ent.Hastatel = textBox4.Text;
                ent.Hastarandevu = comboBox1.Text;
                ent.Doktoradı = comboBox2.Text;
                ent.Tarih = dateTimePicker1.Value;
                ent.Saat = comboBox3.Text + ":" + comboBox4.Text;
                ent.Rapor = " ";
                logichasta.LLHstEkle(ent);

                MessageBox.Show("Randevu başarıyla kaydedilmiştir.");
            }
        }

        private void Randevuoluştur_Load_1(object sender, EventArgs e)
        {
            for (int i = 0; i <= 23; i++)
            {
                comboBox3.Items.Add(i.ToString("00"));
            }
            for (int i = 0; i <= 59; i++)
            {
                comboBox4.Items.Add(i.ToString("00"));
            }
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
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

            dateTimePicker1.MinDate = DateTime.Now;
            OleDbDataReader dr = logichasta.LLFilter(comboBox1.Text);
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["Doctorad"] + " " + dr["Doktorsoyad"]);
            }
            dr.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            OleDbDataReader dr = logichasta.LLFilter(comboBox1.Text);
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["Doctorad"] + " " + dr["Doktorsoyad"]);
            }
            dr.Close();

        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            int maxLength = 11;
            if (textBox4.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            Sekreteranasayfa sekreteranasayfa = new Sekreteranasayfa();
            sekreteranasayfa.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Saturday || dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Hafta sonları seçilemez!");
                dateTimePicker1.Value = DateTime.Now.AddDays(2);
            }
        }
        private void combobBox1_SelectedIndexChanged_Version2(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string selectedBolum = comboBox1.SelectedItem.ToString();

            OleDbDataReader dr = logichasta.LLFilter(selectedBolum);
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["Doctorad"] + " " + dr["Doktorsoyad"]);
            }
            dr.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
