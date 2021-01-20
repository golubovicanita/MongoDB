using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_MongoDB
{
    public partial class PrikaziInfoBiblioteka : Form
    {
        Biblioteka b;
        public PrikaziInfoBiblioteka()
        {
            InitializeComponent();
        }
        public PrikaziInfoBiblioteka(Biblioteka bb)
        {
            InitializeComponent();
            b = bb;
            popuniPodacima();
        }
        private void PrikaziInfoBiblioteka_Load(object sender, EventArgs e)
        {

        }
        public void popuniPodacima()
        {
           
            txtAdresa.Text = b.Adresa;
            txtNaziv.Text = " '" + b.Naziv + "'";
            txtTelefon.Text = b.Telefon[0];
            txtTelefon2.Text = b.Telefon[1];
           
            txtGodina.Text = b.GodinaOsnivanja.ToString();
            txtCena.Text = b.GodisnjaClanarina.ToString();
           

        }

        private void btnSveKnjige_Click(object sender, EventArgs e)
        {
            PrikaziSveKnjigeForma forma = new PrikaziSveKnjigeForma(b);
            Refresh();
            forma.ShowDialog();
        }
    }
}
