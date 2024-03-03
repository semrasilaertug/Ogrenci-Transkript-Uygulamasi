namespace OgrenciTranstriptUygulamasi
{
    partial class DersSil
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
            this.btn_silIptal = new System.Windows.Forms.Button();
            this.btn_dersSil = new System.Windows.Forms.Button();
            this.textBox_silinecekDersKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_silIptal
            // 
            this.btn_silIptal.Location = new System.Drawing.Point(438, 224);
            this.btn_silIptal.Name = "btn_silIptal";
            this.btn_silIptal.Size = new System.Drawing.Size(150, 49);
            this.btn_silIptal.TabIndex = 3;
            this.btn_silIptal.Text = "İPTAL";
            this.btn_silIptal.UseVisualStyleBackColor = true;
            this.btn_silIptal.Click += new System.EventHandler(this.btn_silIptal_Click);
            // 
            // btn_dersSil
            // 
            this.btn_dersSil.Location = new System.Drawing.Point(224, 224);
            this.btn_dersSil.Name = "btn_dersSil";
            this.btn_dersSil.Size = new System.Drawing.Size(150, 49);
            this.btn_dersSil.TabIndex = 2;
            this.btn_dersSil.Text = "SİL";
            this.btn_dersSil.UseVisualStyleBackColor = true;
            this.btn_dersSil.Click += new System.EventHandler(this.btn_dersSil_Click);
            // 
            // textBox_silinecekDersKodu
            // 
            this.textBox_silinecekDersKodu.Location = new System.Drawing.Point(438, 100);
            this.textBox_silinecekDersKodu.Name = "textBox_silinecekDersKodu";
            this.textBox_silinecekDersKodu.Size = new System.Drawing.Size(161, 22);
            this.textBox_silinecekDersKodu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Silmek istediğiniz dersin ders kodunu yazınız :";
            // 
            // DersSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_silIptal);
            this.Controls.Add(this.btn_dersSil);
            this.Controls.Add(this.textBox_silinecekDersKodu);
            this.Controls.Add(this.label1);
            this.Name = "DersSil";
            this.Text = "Ders Sil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_silIptal;
        private System.Windows.Forms.Button btn_dersSil;
        private System.Windows.Forms.TextBox textBox_silinecekDersKodu;
        private System.Windows.Forms.Label label1;
    }
}