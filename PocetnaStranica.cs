using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zatvor.Forme;

namespace Zatvor
{
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }

        private void btnZatvorskeJed_Click(object sender, EventArgs e)
        {
            ZatvoriForma form = new ZatvoriForma();
            form.ShowDialog();
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            SviZaposleniForma form = new SviZaposleniForma();
            form.ShowDialog();
        }

        private void btnZatvorenici_Click(object sender, EventArgs e)
        {
            SviZatvoreniciForma form = new SviZatvoreniciForma();
            form.ShowDialog();
        }
    }

}
