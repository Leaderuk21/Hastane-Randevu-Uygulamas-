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
using entitylayer;
using LOGİCLAYER;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;


namespace HASTANE_UYGULAMA
{
    public partial class Randevugüncelle : Form
    {
        public Randevugüncelle()
        {
            InitializeComponent();
        }        
       
        string saat;
        string dakika;
        private void listeleme(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            textBox5.Text = selectedRow.Cells[0].Value.ToString();
            textBox1.Text = selectedRow.Cells[1].Value.ToString();
            textBox2.Text = selectedRow.Cells[2].Value.ToString();
            textBox3.Text = selectedRow.Cells[3].Value.ToString();
            textBox4.Text = selectedRow.Cells[4].Value.ToString();
            comboBox1.Text = selectedRow.Cells[5].Value.ToString();
            comboBox2.Text = selectedRow.Cells[6].Value.ToString();
            DateTime tarihValue;
            if (DateTime.TryParse(selectedRow.Cells[7].Value.ToString(), out tarihValue))
            {
                if (tarihValue < dateTimePicker1.MinDate)
                {
                    dateTimePicker1.Value = dateTimePicker1.MinDate;
                }
                else if (tarihValue > dateTimePicker1.MaxDate)
                {
                    dateTimePicker1.Value = dateTimePicker1.MaxDate;
                }
                else
                {
                    dateTimePicker1.Value = tarihValue;
                }
            }
            else
            {
                dateTimePicker1.Value = dateTimePicker1.MinDate;
            }
            saat = selectedRow.Cells[8].Value.ToString();
            saat = saat.Substring(0, 2);
            comboBox3.Text = saat;
            dakika = selectedRow.Cells[8].Value.ToString();
            dakika = dakika.Substring(3);
            comboBox4.Text = dakika;
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            List<entityhasta> PerList = logichasta.LLHstList();
            dataGridView1.DataSource = PerList;
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            Sekreteranasayfa sekreteranasayfa = new Sekreteranasayfa();
            sekreteranasayfa.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" +
                           "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "")
            {
                MessageBox.Show("Hiçbir Alan Boş Bırakılamaz", "!!!");
            }
            else
            {
                entityhasta ent = new entityhasta();
                ent.Hastaıd = Convert.ToInt32(textBox5.Text);
                ent.Hastaad = textBox1.Text;
                ent.Hastasoyad = textBox2.Text;
                ent.Hastatc = textBox3.Text;
                ent.Hastatel = textBox4.Text;
                ent.Hastarandevu = comboBox1.Text;
                ent.Doktoradı = comboBox2.Text;
                ent.Tarih = dateTimePicker1.Value;
                ent.Saat = comboBox3.Text + ":" + comboBox4.Text;
                logichasta.LLHstGuncelle(ent);

                List<entityhasta> PerList = logichasta.LLHstList();
                dataGridView1.DataSource = PerList;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            entityhasta ent = new entityhasta();
            ent.Hastaıd = Convert.ToInt32(textBox5.Text);
            logichasta.LLHstSil(ent.Hastaıd);

            List<entityhasta> PerList = logichasta.LLHstList();
            dataGridView1.DataSource = PerList;
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

        private void Randevugüncelle_Load_1(object sender, EventArgs e)
        {
            dataGridView1.CellClick += new DataGridViewCellEventHandler(listeleme);

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

            List<string> bolumListesi = new List<string>
    {
        "Kardiyoloji",
        "Ortopedi",
        "Dahiliye",
        "Genel Cerrahi",
        "Psikiyatri",
        "Kulak-Burun-Boğaz",
        "Kadın Hastalıkları",
        "Kadın Doğum",
        "Üroloji",
        "Dahiliye",
        "Çocuk Hastalıkları",
        "Aile Hekimi"
    };

            comboBox1.DataSource = bolumListesi;
            dateTimePicker1.MinDate = DateTime.Now;           
            string selectedBolum = comboBox1.Text;
            OleDbDataReader dr = logichasta.LLFilter(selectedBolum);
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["Doctorad"] + " " + dr["Doktorsoyad"]);
            }
            dr.Close();
        }

    }
}
