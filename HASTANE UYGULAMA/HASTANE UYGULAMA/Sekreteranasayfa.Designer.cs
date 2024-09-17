namespace HASTANE_UYGULAMA
{
    partial class Sekreteranasayfa
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
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.Adsız_tasarım__4_;
            pictureBox1.Location = new Point(499, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(930, 970);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Impact", 19.875F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(26, 32);
            label1.Name = "label1";
            label1.Size = new Size(467, 103);
            label1.TabIndex = 1;
            label1.Text = "SEKRETER ANA SAYFA";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Impact", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(26, 223);
            button1.Name = "button1";
            button1.Size = new Size(416, 111);
            button1.TabIndex = 2;
            button1.Text = "HASTA İŞLEMLERİ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Impact", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(26, 381);
            button2.Name = "button2";
            button2.Size = new Size(416, 111);
            button2.TabIndex = 3;
            button2.Text = "RANDEVU EKLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Font = new Font("Impact", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.Location = new Point(26, 541);
            button3.Name = "button3";
            button3.Size = new Size(416, 111);
            button3.TabIndex = 4;
            button3.Text = "DOKTOR İŞLEMLERİ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Info;
            button4.Font = new Font("Impact", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button4.Location = new Point(26, 700);
            button4.Name = "button4";
            button4.Size = new Size(416, 111);
            button4.TabIndex = 5;
            button4.Text = "SEKRETER İŞLEMLERİ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Info;
            label2.Font = new Font("Impact", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(26, 859);
            label2.Name = "label2";
            label2.Size = new Size(283, 61);
            label2.TabIndex = 6;
            label2.Text = "ANA MENÜ";
            label2.Click += label2_Click_1;
            // 
            // Sekreteranasayfa
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1441, 974);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Sekreteranasayfa";
            Text = "Sekreteranasayfa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
    }
}