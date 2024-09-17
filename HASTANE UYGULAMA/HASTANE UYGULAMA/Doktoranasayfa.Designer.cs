namespace HASTANE_UYGULAMA
{
    partial class Doktoranasayfa
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
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SeaShell;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(199, 90);
            label1.Name = "label1";
            label1.Size = new Size(551, 66);
            label1.TabIndex = 0;
            label1.Text = "DOKTOR BİLGİ SİSTEMİ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Impact", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(199, 282);
            button1.Name = "button1";
            button1.Size = new Size(384, 92);
            button1.TabIndex = 1;
            button1.Text = "HASTA İŞLEMLERİ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Impact", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(281, 447);
            label2.Name = "label2";
            label2.Size = new Size(186, 57);
            label2.TabIndex = 3;
            label2.Text = "ANA MENÜ";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.Font = new Font("Impact", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(35, 636);
            label3.Name = "label3";
            label3.Size = new Size(216, 74);
            label3.TabIndex = 4;
            // 
            // Doktoranasayfa
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.DOKTOR_RESMİ;
            ClientSize = new Size(1583, 829);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Doktoranasayfa";
            Text = "Doktoranasayfa";
            Load += Doktoranasayfa_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}