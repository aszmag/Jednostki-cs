using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jednostki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Miary jed;
        string nWielkosci;
        int jWybor = 0;

        string[] jsDlugosc = { "m", "in", "ft", "yd", "M", "NM" };
        string[] jnDlugosc = { "metr", "cal", "stopa", "jard", "mila lądowa", "mila morska" };
        double[] jwDlugosc = { 1, .0254, .3048, .9144, 1609.344, 1852 };

        string[] jsMasa = { "kg", "gr", "oz", "lb" };
        string[] jnMasa = { "kilogram", "gran", "uncja", "funt" };
        double[] jwMasa = { 1, .00006479891, .028349, .453592 };

        string[] jsCzas = { "s" };
        string[] jnCzas = { "sekunda" };
        double[] jwCzas = { 1 };


        private void textBoxWartosc_KeyDown(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
            if (e.KeyCode == Keys.Enter) Przelicz();
        }

        private void Przelicz()
        {
            double w = 0;
            if (!Odczytaj(ref w)) return;
            string wynik="";
            int i = 0;
            foreach (double c in jed.przeliczenia)
            {
                if (listBoxNazwy.SelectedIndex == i) { ++i; continue; }
                wynik += (w * jed.przeliczenia[jWybor] / c).ToString("F5") + " " + jed.skroty[i++] + "\r\n";
            }
            textBoxWynik.Text = wynik;
        }

        private bool Odczytaj(ref double w)
        {
            try { w = double.Parse(textBoxWartosc.Text); }
            catch (FormatException) {
                errorProvider1.SetError(textBoxWartosc, "Podaj liczbę w odpowiednim formacie");
                return false;
            }
            catch (OverflowException)
            {
                errorProvider1.SetError(textBoxWartosc, "Podaj mniejszą liczbę");
                return false;
            }
            catch(Exception e)
            {
                errorProvider1.SetError(textBoxWartosc, e.Message);
                return false;
            }
            return true;
        }

        private void radioButtonDlugosc_CheckedChanged(object sender, EventArgs e)
        {
            nWielkosci = "Długość";
            labelWartosc.Text = nWielkosci + " [" + jsDlugosc[0] + "]";
            Wyczysc();
            jed.skroty = jsDlugosc;
            jed.nazwy = jnDlugosc;
            jed.przeliczenia = jwDlugosc;
            listBoxNazwy.Items.AddRange(jed.nazwy);
        }

        private void radioButtonMasa_CheckedChanged(object sender, EventArgs e)
        {
            nWielkosci = "Masa";
            labelWartosc.Text = nWielkosci + " [" + jsMasa[0] + "]";
            Wyczysc();
            jed.skroty = jsMasa;
            jed.nazwy = jnMasa;
            jed.przeliczenia = jwMasa;
            listBoxNazwy.Items.AddRange(jed.nazwy);
        }

        private void radioButtonCzas_CheckedChanged(object sender, EventArgs e)
        {
            nWielkosci = "Czas";
            labelWartosc.Text = nWielkosci + " [" + "s]";
            Wyczysc();
            jed.skroty = jsCzas;
            jed.nazwy = jnCzas;
            jed.przeliczenia = jwCzas;
            listBoxNazwy.Items.AddRange(jed.nazwy);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jed  = new Miary();
            jed.skroty = jsDlugosc;
            jed.nazwy = jnDlugosc;
            jed.przeliczenia = jwDlugosc;
            listBoxNazwy.Items.AddRange(jnDlugosc);
        }

        private void Wyczysc()
        {
            errorProvider1.Clear();
            textBoxWartosc.Text = "";
            textBoxWynik.Text = "";
            listBoxNazwy.Items.Clear();
            jWybor = 0;
        }

        private void listBoxNazwy_SelectedIndexChanged(object sender, EventArgs e)
        {
            jWybor = listBoxNazwy.SelectedIndex;
            labelWartosc.Text = nWielkosci + " [" + jed.skroty[jWybor] + "]";
            Przelicz();
        }
    }
}
