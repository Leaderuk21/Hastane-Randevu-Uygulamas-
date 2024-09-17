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
    public partial class Sekreterişlemleri : Form
    {
        public Sekreterişlemleri()
        {
            InitializeComponent();
        }      

        private void listeleme(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            textBox6.Text = selectedRow.Cells[0].Value.ToString();
            textBox1.Text = selectedRow.Cells[1].Value.ToString();
            textBox2.Text = selectedRow.Cells[2].Value.ToString();
            textBox3.Text = selectedRow.Cells[3].Value.ToString();
            textBox4.Text = selectedRow.Cells[4].Value.ToString();
            textBox5.Text = selectedRow.Cells[5].Value.ToString();
        }
       private void SekreterEkle_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            List<entitysekreter> PerList = logicsekreter.LLSecList();
            dataGridView1.DataSource = PerList;
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            Sekreteranasayfa sekreteranasayfa = new Sekreteranasayfa();
            sekreteranasayfa.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            entitysekreter ent = new entitysekreter();
            ent.Sekreteradı = textBox1.Text;
            ent.Sekretersoyad = textBox2.Text;
            ent.Sekretertel = textBox3.Text;
            ent.Sekreterkullanıcıadı = textBox4.Text;
            ent.Sekreterşifre = textBox5.Text;
            logicsekreter.LLSecEkle(ent);

            List<entitysekreter> PerList = logicsekreter.LLSecList();
            dataGridView1.DataSource = PerList;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" +
              "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Hiçbir Alan Boş Bırakılamaz", "!!!");
            }
            else
            {
                entitysekreter ent = new entitysekreter();
                ent.Sekreterıd = Convert.ToInt32(textBox6.Text);
                ent.Sekreteradı = textBox1.Text;
                ent.Sekretersoyad = textBox2.Text;
                ent.Sekretertel = textBox3.Text;
                ent.Sekreterkullanıcıadı = textBox4.Text;
                ent.Sekreterşifre = textBox5.Text;
                logicsekreter.LLSecGuncelle(ent);

                List<entitysekreter> PerList = logicsekreter.LLSecList();
                dataGridView1.DataSource = PerList;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            entitysekreter ent = new entitysekreter();
            ent.Sekreterıd = Convert.ToInt32(textBox6.Text);
            logicsekreter.LLSecSil(ent.Sekreterıd);

            List<entitysekreter> PerList = logicsekreter.LLSecList();
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

        private void Sekreterişlemleri_Load_1(object sender, EventArgs e)
        {
            dataGridView1.CellClick += new DataGridViewCellEventHandler(listeleme);
        }
    }
}
