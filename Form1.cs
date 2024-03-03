using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTranstriptUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dersEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersEkle dersEkle = new DersEkle();
            dersEkle.Show();
        }

        private void dersGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersGuncelle dersGuncelle = new DersGuncelle();
            dersGuncelle.Show();
        }

        private void dersSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersSil dersSil = new DersSil();
            dersSil.Show();
        }

        private void transkriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transkript transkript = new Transkript();
            transkript.Show();
        }
    }
}
