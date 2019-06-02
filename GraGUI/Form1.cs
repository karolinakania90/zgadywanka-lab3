using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;


namespace GraGUI
{
    public partial class Form1 : Form
    {
        private Gra g;
        public Form1()
        {
            InitializeComponent();
        }

        private void NowaGra_Click(object sender, EventArgs e)
        {
            Losuj.Visible = true;
            NowaGra.Enabled = false; 
        }
        private void losuj_Click(object sender, EventArgs e)
        {
            // wczytaj zakres do losowania
            int a = int.Parse(ZakresOd.Text);
            int b = int.Parse(ZakresDo.Text);

            //utwórz grę
            g = new Gra(a, b);

            ZakresOd.Enabled = false;
            ZakresDo.Enabled = false;
            Losuj.Enabled = false;



            // wyświetl kolejne elementy formularza



        }
    }
}
