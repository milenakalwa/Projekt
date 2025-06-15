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
        private List<PictureBox> balony = new List<PictureBox>();
        private Timer timerBalonowy = new Timer();

        double ostatnieBMI = 0;

        public button()
        {
            InitializeComponent();

            timerBalonowy.Interval = 50;
            timerBalonowy.Tick += TimerBalonowy_Tick;
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

                    PokazBalony();
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
            LinkLabelOtylosc.Visible = false; // chowa linka do strony o walce z otyłością
            lblKomunikat.Text = "";//znika komunikat
            panelWynik.BackColor = SystemColors.Control; //domyślny kolor wraca

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


       private void PokazBalony()
        {
            var rnd = new Random();
        for (int i = 0; i< 5; i++)
            {
                PictureBox balon = new PictureBox();
                balon.Image = Properties.Resources.balon;
                balon.SizeMode = PictureBoxSizeMode.StretchImage;
                balon.Size = new Size(50, 70);
                balon.Left = rnd.Next(0, this.ClientSize.Width - balon.Width);
                balon.Top = this.ClientSize.Height;

                this.Controls.Add(balon);
                balony.Add(balon);
            }
            timerBalonowy.Start();
            }
            private void TimerBalonowy_Tick(object sender, EventArgs e)
            {
            for (int i = balony.Count - 1; i >= 0; i--)
            {
                balony[i].Top -= 5;
                if (balony[i].Bottom < 0)
                {
                    this.Controls.Remove(balony[i]);
                    balony.RemoveAt(i);
                }
            }
            if (balony.Count == 0)
            {
                timerBalonowy.Stop();
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

    

