using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGİCLAYER;
using entitylayer;
using iTextSharp.text.pdf;
using System.Net.Mail;
using iTextSharp.text;

namespace HASTANE_UYGULAMA
{
    public partial class Hastarapor : Form
    {
        public Hastarapor()
        {
            InitializeComponent();
        }
        public string doktorad;
        public string doktorsoyad;
        
        private void listeleme(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            textBox3.Text = selectedRow.Cells[0].Value.ToString();
            textBox1.Text = selectedRow.Cells[9].Value.ToString();
        }       
        private void button1_Click_1(object sender, EventArgs e)
        {
            entityhasta ent = new entityhasta();
            ent.Hastaıd = Convert.ToInt32(textBox3.Text);
            ent.Rapor = textBox1.Text;
            logichasta.LLHstGuncelle2(ent);

            entitydoktor doc = new entitydoktor();
            doc.Doctorad = doktorad;
            doc.Doktorsoyad = doktorsoyad;
            List<entityhasta> PerList = logichasta.LLDoktoraGoreHstList(doc);
            dataGridView1.DataSource = PerList;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            entitydoktor doc = new entitydoktor();
            doc.Doctorad = doktorad;
            doc.Doktorsoyad = doktorsoyad;

            List<entityhasta> PerList = logichasta.LLDoktoraGoreHstList(doc);
            dataGridView1.DataSource = PerList;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            entityhasta ent = new entityhasta();
            ent.Hastaıd = Convert.ToInt32(textBox3.Text);
            logichasta.LLHstSil(ent.Hastaıd);

            List<entityhasta> PerList = logichasta.LLHstList();
            dataGridView1.DataSource = PerList;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Boş Alan Bırakmayınız !!!");
            }
            else
            {
                try
                {
                    var mailAddress = new MailAddress(textBox2.Text);
                    MailMessage mesaj = new MailMessage();
                    mesaj.From = new MailAddress("ukarakoc40@gmail.com");
                    mesaj.To.Add(mailAddress.Address);
                    mesaj.Subject = "# Umut Karakoç Doktor Raporu #";
                    mesaj.Body = textBox1.Text; 

                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                    smtpClient.Credentials = new System.Net.NetworkCredential("ukarakoc40@gmail.com", "tift dzky onkd jsgi");
                    smtpClient.EnableSsl = true;

                    smtpClient.Send(mesaj);
                    MessageBox.Show("Mail Gönderilmiştir");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Geçersiz e-posta adresi!");
                }
                catch (SmtpException ex)
                {
                    MessageBox.Show("Mail gönderme hatası: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
            {
            Doktoranasayfa dok = new Doktoranasayfa();
            dok.doctorad = doktorad;
            dok.doktorsoyad = doktorsoyad;
            dok.Show();
            this.Close();
        }

            private void Hastarapor_Load_1(object sender, EventArgs e)
            {
            dataGridView1.CellClick += new DataGridViewCellEventHandler(listeleme);
        }

            private void button4_Click_1(object sender, EventArgs e)
            {
            
            try
            {
                string pdfFilePath = "C:\\Users\\ukara\\OneDrive\\Masaüstü\\HastaRaporu.pdf";

              
                Document pdfDoc = new Document();
                PdfWriter.GetInstance(pdfDoc, new FileStream(pdfFilePath, FileMode.Create));

                pdfDoc.Open();

                pdfDoc.Add(new Paragraph($"Doktor Adı: {doktorad} {doktorsoyad}"));
                pdfDoc.Add(new Paragraph($"Hasta ID: {textBox3.Text}"));
                pdfDoc.Add(new Paragraph("Görüşme Raporu:"));
                pdfDoc.Add(new Paragraph(textBox1.Text));

                pdfDoc.Close();

                MessageBox.Show("PDF oluşturuldu: " + pdfFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF oluşturma hatası: " + ex.Message);
            }
        }
    }
 }


