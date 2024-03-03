namespace OgrenciTranstriptUygulamasi
{
    partial class Transkript
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
            this.btn_ganoIptal = new System.Windows.Forms.Button();
            this.btn_ganoHesapla = new System.Windows.Forms.Button();
            this.dataGridView_transkript = new System.Windows.Forms.DataGridView();
            this.btn_transkriptGoruntule = new System.Windows.Forms.Button();
            this.textBox_donemGANO = new System.Windows.Forms.TextBox();
            this.btn_donemGANO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transkript)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ganoIptal
            // 
            this.btn_ganoIptal.Location = new System.Drawing.Point(855, 493);
            this.btn_ganoIptal.Name = "btn_ganoIptal";
            this.btn_ganoIptal.Size = new System.Drawing.Size(154, 52);
            this.btn_ganoIptal.TabIndex = 3;
            this.btn_ganoIptal.Text = "İPTAL";
            this.btn_ganoIptal.UseVisualStyleBackColor = true;
            this.btn_ganoIptal.Click += new System.EventHandler(this.btn_ganoIptal_Click);
            // 
            // btn_ganoHesapla
            // 
            this.btn_ganoHesapla.Location = new System.Drawing.Point(603, 545);
            this.btn_ganoHesapla.Name = "btn_ganoHesapla";
            this.btn_ganoHesapla.Size = new System.Drawing.Size(154, 52);
            this.btn_ganoHesapla.TabIndex = 2;
            this.btn_ganoHesapla.Text = "GANO Hesapla";
            this.btn_ganoHesapla.UseVisualStyleBackColor = true;
            this.btn_ganoHesapla.Click += new System.EventHandler(this.btn_ganoHesapla_Click);
            // 
            // dataGridView_transkript
            // 
            this.dataGridView_transkript.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_transkript.Location = new System.Drawing.Point(1, 84);
            this.dataGridView_transkript.Name = "dataGridView_transkript";
            this.dataGridView_transkript.RowHeadersWidth = 51;
            this.dataGridView_transkript.RowTemplate.Height = 24;
            this.dataGridView_transkript.Size = new System.Drawing.Size(1072, 314);
            this.dataGridView_transkript.TabIndex = 4;
            // 
            // btn_transkriptGoruntule
            // 
            this.btn_transkriptGoruntule.Location = new System.Drawing.Point(468, 26);
            this.btn_transkriptGoruntule.Name = "btn_transkriptGoruntule";
            this.btn_transkriptGoruntule.Size = new System.Drawing.Size(154, 52);
            this.btn_transkriptGoruntule.TabIndex = 1;
            this.btn_transkriptGoruntule.Text = "Transkript Görüntüle";
            this.btn_transkriptGoruntule.UseVisualStyleBackColor = true;
            this.btn_transkriptGoruntule.Click += new System.EventHandler(this.btn_transkriptGoruntule_Click);
            // 
            // textBox_donemGANO
            // 
            this.textBox_donemGANO.Location = new System.Drawing.Point(468, 449);
            this.textBox_donemGANO.Name = "textBox_donemGANO";
            this.textBox_donemGANO.Size = new System.Drawing.Size(100, 22);
            this.textBox_donemGANO.TabIndex = 4;
            // 
            // btn_donemGANO
            // 
            this.btn_donemGANO.Location = new System.Drawing.Point(603, 434);
            this.btn_donemGANO.Name = "btn_donemGANO";
            this.btn_donemGANO.Size = new System.Drawing.Size(154, 52);
            this.btn_donemGANO.TabIndex = 5;
            this.btn_donemGANO.Text = "Dönem GANO Hesapla";
            this.btn_donemGANO.UseVisualStyleBackColor = true;
            this.btn_donemGANO.Click += new System.EventHandler(this.btn_donemGANO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Belli bir dönemin GANO\'sunu hesaplamak için dönem giriniz :";
            // 
            // Transkript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_donemGANO);
            this.Controls.Add(this.textBox_donemGANO);
            this.Controls.Add(this.btn_ganoIptal);
            this.Controls.Add(this.btn_ganoHesapla);
            this.Controls.Add(this.dataGridView_transkript);
            this.Controls.Add(this.btn_transkriptGoruntule);
            this.Name = "Transkript";
            this.Text = "Transkript";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transkript)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ganoIptal;
        private System.Windows.Forms.Button btn_ganoHesapla;
        private System.Windows.Forms.DataGridView dataGridView_transkript;
        private System.Windows.Forms.Button btn_transkriptGoruntule;
        private System.Windows.Forms.TextBox textBox_donemGANO;
        private System.Windows.Forms.Button btn_donemGANO;
        private System.Windows.Forms.Label label1;
    }
}