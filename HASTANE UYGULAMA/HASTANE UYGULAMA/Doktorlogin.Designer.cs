namespace HASTANE_UYGULAMA
{
    partial class Doktorlogin
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Impact", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(298, 306);
            label1.Name = "label1";
            label1.Size = new Size(377, 100);
            label1.TabIndex = 0;
            label1.Text = "DOKTOR GİRİŞ";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientInactiveCaption;
            textBox1.Location = new Point(312, 433);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 54);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter_1;
            textBox1.Leave += textBox1_Leave_1;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.GradientInactiveCaption;
            textBox2.Location = new Point(312, 518);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(363, 53);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Enter += textBox2_Enter_1;
            textBox2.Leave += textBox2_Leave_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.kullanıcıgörsel;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(212, 433);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = Properties.Resources.kilitfoto;
            pictureBox2.Location = new Point(212, 518);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(83, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Impact", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.Location = new Point(312, 659);
            button1.Name = "button1";
            button1.Size = new Size(375, 67);
            button1.TabIndex = 5;
            button1.Text = "GİRİŞ YAP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(498, 593);
            label2.Name = "label2";
            label2.Size = new Size(177, 29);
            label2.TabIndex = 6;
            label2.Text = "TÜMÜNÜ SİL";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(217, 785);
            label3.Name = "label3";
            label3.Size = new Size(135, 34);
            label3.TabIndex = 7;
            label3.Text = "ANA SAYFA";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(636, 785);
            label4.Name = "label4";
            label4.Size = new Size(79, 34);
            label4.TabIndex = 8;
            label4.Text = "ÇIKIŞ";
            label4.Click += label4_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LOGİNÜSTRESİM;
            pictureBox3.Location = new Point(5, -6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1027, 309);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // Doktorlogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1033, 908);
            Controls.Add(pictureBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Doktorlogin";
            Text = "Doktorlogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox3;
    }
}