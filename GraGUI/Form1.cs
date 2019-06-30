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
using static ModelGry.Gra;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        private ModelGry.Gra g;
        private DateTime czasRozpoczecia;

        public Form1()
        {
            InitializeComponent();
            Text = "GRA";
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            // wyczysc stan gry
            
            groupBoxLosuj.Visible = true;
            groupBoxZgadnij.Visible = true;
            buttonNowaGra.Enabled = false;
            textBoxOdpowiedz.Text = "";
            labelLiczbaProb.Visible = false;
            labelLiczbaProbText.Visible = false;

            labelWynik.Visible = false;

            textBoxOd.Enabled = true;
            textBoxOd.Text = "";
            textBoxDo.Enabled = true;
            textBoxDo.Text = "";

            buttonLosuj.Enabled = true;
        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            if (textBoxOd.Text == null || textBoxOd.Text == "")
            {
                MessageBox.Show("Podaj poprawna odpowiedz");
                return;
            }

            if (textBoxOd.Text == null || textBoxOd.Text == "")
            {
                MessageBox.Show("Podaj poprawna odpowiedz");
                return;
            }

            // wczytaj zakres do losowania
            int a = int.Parse( textBoxOd.Text );
            int b = int.Parse( textBoxDo.Text );

            // utwórz grę
            g = new ModelGry.Gra(a, b);

            textBoxOd.Enabled = false;
            textBoxDo.Enabled = false;
            buttonLosuj.Enabled = false;
            buttonSprawdz.Enabled = true;
            textBoxOdpowiedz.Enabled = true;
            czasRozpoczecia = DateTime.Now;
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonSprawdz_Click(object sender, EventArgs e)
        {
            int mojaOdpowiedz = int.Parse(textBoxOdpowiedz.Text);
             
            Odpowiedz odpowiedz = g.Ocena(mojaOdpowiedz);
            labelLiczbaProb.Text = Convert.ToString(g.LicznikRuchow);

            labelLiczbaProb.Visible = true;
            labelLiczbaProbText.Visible = true;
            labelWynik.Visible = true;

            // wyswietl wynik

            if (odpowiedz == Odpowiedz.ZaMalo)
            {
                labelWynik.Text = "Za mało! Zgaduj dalej!";
            }
            else if(odpowiedz == Odpowiedz.ZaDuzo)
            {
                labelWynik.Text = "Za dużo! Zgaduj dalej!";
            }
            else
            {
                double sekund = (DateTime.Now - czasRozpoczecia).Seconds;
                labelWynik.Text = $"Brawo! Zgadłeś za {g.LicznikRuchow} razem w ciągu {sekund} sekund!";

                // pozwol na rozpoczecie nowej gry
                textBoxOdpowiedz.Enabled = false;
  
                buttonSprawdz.Enabled = false;
                buttonNowaGra.Enabled = true;
            }           
        }

        private void LabelLiczbaProb_Click(object sender, EventArgs e)
        {

        }
    }
}
