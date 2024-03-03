namespace OgrenciTranstriptUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dersEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transkriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(92, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "ÖĞRENCİ TRANSKRİPT UYGULAMASI";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersEkleToolStripMenuItem,
            this.dersGüncelleToolStripMenuItem,
            this.dersSilToolStripMenuItem,
            this.transkriptToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dersEkleToolStripMenuItem
            // 
            this.dersEkleToolStripMenuItem.Name = "dersEkleToolStripMenuItem";
            this.dersEkleToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.dersEkleToolStripMenuItem.Text = "Ders Ekle";
            this.dersEkleToolStripMenuItem.Click += new System.EventHandler(this.dersEkleToolStripMenuItem_Click);
            // 
            // dersGüncelleToolStripMenuItem
            // 
            this.dersGüncelleToolStripMenuItem.Name = "dersGüncelleToolStripMenuItem";
            this.dersGüncelleToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.dersGüncelleToolStripMenuItem.Text = "Ders Güncelle";
            this.dersGüncelleToolStripMenuItem.Click += new System.EventHandler(this.dersGüncelleToolStripMenuItem_Click);
            // 
            // dersSilToolStripMenuItem
            // 
            this.dersSilToolStripMenuItem.Name = "dersSilToolStripMenuItem";
            this.dersSilToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.dersSilToolStripMenuItem.Text = "Ders Sil";
            this.dersSilToolStripMenuItem.Click += new System.EventHandler(this.dersSilToolStripMenuItem_Click);
            // 
            // transkriptToolStripMenuItem
            // 
            this.transkriptToolStripMenuItem.Name = "transkriptToolStripMenuItem";
            this.transkriptToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.transkriptToolStripMenuItem.Text = "Transkript";
            this.transkriptToolStripMenuItem.Click += new System.EventHandler(this.transkriptToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "MENÜ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dersEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transkriptToolStripMenuItem;
    }
}

