using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class button : Form
    {
        double ostatnieBMI = 0;

        public button()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void obliczbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Double waga = double.Parse(txtwaga.Text);
                Double wzrostCm = double.Parse(txtwzrost.Text);
                Double wzrostM = wzrostCm / 100;
                Double bmi = waga / (wzrostM * wzrostM);
                lblBMI.Text = $"Twoje BMI: {bmi:F2}";
                ostatnieBMI = bmi;

                if (bmi < 16.0)
                {
                    lblKategoria.Text = "Wygłodzenie";
                    panelWynik.BackColor = Color.DarkBlue;
                    LinkLabelOtylosc.Visible = false;
                }
                else if (bmi < 16.99)
                {
                    lblKategoria.Text = "Wychudzenie";
                    panelWynik.BackColor = Color.LightBlue;
                    LinkLabelOtylosc.Visible = false;
                }
                else if (bmi < 18.49)
                {
                    lblKategoria.Text = "Niedowaga";
                    panelWynik.BackColor = Color.LightGreen;
                    LinkLabelOtylosc.Visible = false;
                }
                else if (bmi < 24.99)
                {
                    lblKategoria.Text = "Waga prawidłowa";
                    panelWynik.BackColor = Color.Khaki;
                    LinkLabelOtylosc.Visible = false;
                }
                else if (bmi < 29.99)
                {
                    lblKategoria.Text = "Nadwaga";
                    panelWynik.BackColor = Color.Yellow;
                    LinkLabelOtylosc.Visible = true;
                }
                else if (bmi < 34.99)
                {
                    lblKategoria.Text = "Otyłość 1 stopnia";
                    panelWynik.BackColor = Color.Orange;
                    LinkLabelOtylosc.Visible = true;
                }
                else if (bmi < 39.99)
                {
                    lblKategoria.Text = "Otyłość 2 stopnia";
                    panelWynik.BackColor = Color.Red;
                    LinkLabelOtylosc.Visible = true;
                }
                else
                {
                    lblKategoria.Text = "Otyłość 3 stopnia (chorobliwa)";
                    panelWynik.BackColor = Color.DarkRed;
                    LinkLabelOtylosc.Visible = true;
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Proszę wpisać poprawne liczby w obu polach!", "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wyczyscbutton_Click(object sender, EventArgs e)
        {
            txtwaga.Clear();
            txtwzrost.Clear();
            lblBMI.Text = "";
            lblKategoria.Text = " ";
            txtwiek.Clear();
            LinkLabelOtylosc.Visible = false; // schowaj linka do strony o otyłości
            lblKomunikat.Text = "";//znika komunikat
            panelWynik.BackColor = SystemColors.Control; //domyślny kolor 

        }

        private void Sprawdzbutton_Click(object sender, EventArgs e)
        {
            int[,] zakresyBMI = new int[,]

            {
            {18,24,19,24},
            {25,34,20,25},
            {35,44,21,26},
            {45,54,22,27},
            {55,64,23,28},
            {65,120,24,29}
            };

            int wiek = int.Parse(txtwiek.Text);
            bool znalezionoZakres = false;
            string komunikat = "Brak danych dla podanego wieku.";
            for (int i = 0; i < zakresyBMI.GetLength(0); i++)
            {
                int wiekMin = zakresyBMI[i, 0];
                int wiekMax = zakresyBMI[i, 1];
                int bmiMin = zakresyBMI[i, 2];
                int bmiMax = zakresyBMI[i, 3];

                if (wiek >= wiekMin && wiek <= wiekMax)
                {
                    znalezionoZakres = true;
                    if (ostatnieBMI >= bmiMin && ostatnieBMI <= bmiMax)
                    {
                        komunikat = "Twoje BMI jest w zalecanym zakresie.";
                        lblKomunikat.Text = komunikat;
                    }
                    else
                    {
                        komunikat = $"Twoje BMI jest poza zalecanym zakresem {bmiMin}-{bmiMax}.";
                        lblKomunikat.Text = komunikat;
                    }
                    break;
                }
            }


        }

        private void pokazbutton_Click(object sender, EventArgs e)
        {
               public partial class Form1 : Form
        {
            private List<double> ostatnieWynikiBMI = new List<double>();

            public Form1()
            {
                InitializeComponent();
            }

            private void obliczbutton_Click(object sender, EventArgs e)
            {
                // Przykład obliczenia BMI (musisz mieć własną logikę obliczania)
                double bmi = ObliczBMI();

                // Dodaj wynik do listy
                ostatnieWynikiBMI.Add(bmi);

                // Zachowaj tylko 3 ostatnie
                if (ostatnieWynikiBMI.Count > 3)
                {
                   ostatnieWynikiBMI.RemoveAt(0);
                }
            }

            private void pokazbutton_Click(object sender, EventArgs e)
            {
                if (ostatnieWynikiBMI.Count == 0)
                {
                    MessageBox.Show("Brak obliczonych wyników BMI.");
                    return;
                }

                string wyniki = "Ostatnie wyniki BMI:\n";
                foreach (double wynik in ostatnieWynikiBMI)
                {
                    wyniki += $"- {Math.Round(wynik, 2)}\n";
                }

                MessageBox.Show(wyniki);
            }
        }
          
        

        private void LinkLabelOtylosc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ootylosci.pl/",
                UseShellExecute = true
            });
        }
    }
    }

    

