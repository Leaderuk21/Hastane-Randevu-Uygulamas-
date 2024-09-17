namespace HASTANE_UYGULAMA
{
    partial class Genel_Giriş
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Adsız_tasarım__2_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(550, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(823, 798);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Impact", 19.875F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(30, 21);
            label1.Name = "label1";
            label1.Size = new Size(487, 86);
            label1.TabIndex = 1;
            label1.Text = " UMUT HASTANESİ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Impact", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(1, 151);
            button1.Name = "button1";
            button1.Size = new Size(527, 127);
            button1.TabIndex = 2;
            button1.Text = "DOKTOR GİRİŞİ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Impact", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(1, 375);
            button2.Name = "button2";
            button2.Size = new Size(527, 133);
            button2.TabIndex = 3;
            button2.Text = "SEKRETER GİRİŞİ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Genel_Giriş
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1374, 784);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Genel_Giriş";
            Text = "Genel_Giriş";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}