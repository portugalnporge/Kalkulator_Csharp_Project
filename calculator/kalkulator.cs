/*
Filnavn: kalkulator.cs
Teknisk: Selvstendig program, CUI
Versjon: 2
Kommentar: Å lage et enkelt Windows-kalkulatorprogram.

Forfatter: sc - Sergio Cadete
            
Historikk: Når Hvem Hva
20150904 sr Opprettet

 --------------------------------------------------------------
Kommentarer:
  Programmet skal ha deler av den
funksjonaliteten som gjelder for den vanlige lommeregneren du finner i
Windows:


(Her kan du forklare detaljer.)
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class kalkulator : Form
    {
        double verdi = 0;
        string tegn = ""; //håndtering av tegn +,x,-,/
        bool tegn_tastet = false; //rense display
        public bool close = false;
      
        public kalkulator()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            beregning.Text = ""; //funger kun for label. etter beregninger forsvinner tall på beregninglabel
            switch (tegn)
            {
                case "+":
                    display.Text = (verdi + Double.Parse(display.Text)).ToString();
                    break;
                case "-":
                    display.Text = (verdi - Double.Parse(display.Text)).ToString();
                    break;
                case "*":
                    display.Text = (verdi * Double.Parse(display.Text)).ToString();
                    break;
                case "/":
                    display.Text = (verdi / Double.Parse(display.Text)).ToString();
                    break;
                default:
                    break;

            } //switch
            verdi = Double.Parse(display.Text); // for å lagre verdiene
            tegn = "";
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (tegn_tastet)) // rense 0 før plassere de andre nr.
                display.Clear();
            
                tegn_tastet = false;
                Button knappen = (Button)sender;
                //display.Text = display.Text + knappen.Text; den må fjernes eller når du taster, skriver man to ganger

                if (knappen.Text == ",")
                {
                    if (!display.Text.Contains(","))             // hvis det inneholder ",". det betyr kommer ikke til å skje igjen
                        display.Text = display.Text + knappen.Text;
                }
                else
                     display.Text = display.Text + knappen.Text;
                
            
             // verdi = Int32.Parse(display.Text);
               // tegn = "";
        }

        private void tegn_click(object sender, EventArgs e)
        {
            Button knappen = (Button)sender;
            if (verdi !=0)
            {
                lik.PerformClick();
                tegn_tastet = true;
                tegn = knappen.Text;
                beregning.Text = verdi + " " + tegn;
            }
            else
            {
                tegn = knappen.Text;
                verdi = Double.Parse(display.Text);
                tegn_tastet = true;
                beregning.Text = verdi + " " + tegn;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            display.Text = "";
            beregning.Text = "";
            display.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

               
        }

        private void hjelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Her finner du mange informasjoner kun for å hjelpe deg mest mulig.",
                "Velkommen til hjelp");
               
                
        }

        private void plus_minusClick(object sender, EventArgs e)
        {
            if (display.Text.Contains("-"))
                display.Text = display.Text.Remove(0, 1);
            else
                display.Text = "-" + display.Text;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void åpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Her finner du mange informasjoner. Vi hjelper deg mest mulig.",
                "Velkommen til hjelp");
        }

        private void avsluttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var svar = MessageBox.Show(" Vil du virkelig avslutte eller å få hjelp ?",   //
                "Heia Brann",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (svar == DialogResult.OK)

                this.Close();
        }

        private void lukk_click(object sender, FormClosingEventArgs e)
        {
            if(this.close)
            {
                // X knappen er tastet
            }

                
        }

        private void kalkulator_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
            switch(e.KeyChar.ToString())
            {
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    tre.PerformClick();
                    break;
                case "4":
                    fire.PerformClick();
                    break;
                case "5":
                    fem.PerformClick();
                    break;
                case "6":
                    seks.PerformClick();
                    break;
                case "7":
                    sju.PerformClick();
                    break;
                case "8":
                    atte.PerformClick();
                    break;

                case "9":
                    ni.PerformClick();
                    break;
                case "0":
                    zero.PerformClick();
                    break;
                case "/":
                    dele.PerformClick();
                    break;
                case "*":
                    ganger.PerformClick();
                    break;
                case "-":
                    minus.PerformClick();
                    break;
                case "+":
                    pluss.PerformClick();
                    break;
                case "=":
                    lik.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void display_KeyPress(object sender, KeyPressEventArgs e)
        {


            MessageBox.Show(e.KeyChar.ToString());
            switch (e.KeyChar.ToString())
            {
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    tre.PerformClick();
                    break;
                case "4":
                    fire.PerformClick();
                    break;
                case "5":
                    fem.PerformClick();
                    break;
                case "6":
                    seks.PerformClick();
                    break;
                case "7":
                    sju.PerformClick();
                    break;
                case "8":
                    atte.PerformClick();
                    break;

                case "9":
                    ni.PerformClick();
                    break;
                case "0":
                    zero.PerformClick();
                    break;
                case "/":
                    dele.PerformClick();
                    break;
                case "*":
                    ganger.PerformClick();
                    break;
                case "-":
                    minus.PerformClick();
                    break;
                case "+":
                    pluss.PerformClick();
                    break;
                case "=":
                    lik.PerformClick();
                    break;
                default:
                    break;
            }

        }
        
    }
}
