namespace BMI
{
    partial class button
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtwaga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtwzrost = new System.Windows.Forms.TextBox();
            this.obliczbutton = new System.Windows.Forms.Button();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblKategoria = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtwiek = new System.Windows.Forms.TextBox();
            this.lblKomunikat = new System.Windows.Forms.Label();
            this.wyczyscbutton = new System.Windows.Forms.Button();
            this.panelWynik = new System.Windows.Forms.Panel();
            this.Sprawdzbutton = new System.Windows.Forms.Button();
            this.LinkLabelOtylosc = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj dane do obliczenia BMI ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Waga(kg):";
            // 
            // txtwaga
            // 
            this.txtwaga.Location = new System.Drawing.Point(128, 52);
            this.txtwaga.Name = "txtwaga";
            this.txtwaga.Size = new System.Drawing.Size(85, 26);
            this.txtwaga.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(20, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Wzrost (cm):";
            // 
            // txtwzrost
            // 
            this.txtwzrost.Location = new System.Drawing.Point(162, 93);
            this.txtwzrost.Name = "txtwzrost";
            this.txtwzrost.Size = new System.Drawing.Size(85, 26);
            this.txtwzrost.TabIndex = 4;
            // 
            // obliczbutton
            // 
            this.obliczbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.obliczbutton.Location = new System.Drawing.Point(254, 37);
            this.obliczbutton.Name = "obliczbutton";
            this.obliczbutton.Size = new System.Drawing.Size(191, 56);
            this.obliczbutton.TabIndex = 5;
            this.obliczbutton.Text = "Oblicz moje BMI";
            this.obliczbutton.UseVisualStyleBackColor = true;
            this.obliczbutton.Click += new System.EventHandler(this.obliczbutton_Click);
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBMI.Location = new System.Drawing.Point(460, 37);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 26);
            this.lblBMI.TabIndex = 6;
            // 
            // lblKategoria
            // 
            this.lblKategoria.AutoSize = true;
            this.lblKategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKategoria.Location = new System.Drawing.Point(460, 76);
            this.lblKategoria.Name = "lblKategoria";
            this.lblKategoria.Size = new System.Drawing.Size(0, 26);
            this.lblKategoria.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(719, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sprawdź, czy jesteś w pożądanym BMI dla swojej grupy wiekowej.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Podaj wiek:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtwiek
            // 
            this.txtwiek.Location = new System.Drawing.Point(142, 206);
            this.txtwiek.Name = "txtwiek";
            this.txtwiek.Size = new System.Drawing.Size(98, 26);
            this.txtwiek.TabIndex = 10;
            // 
            // lblKomunikat
            // 
            this.lblKomunikat.AutoSize = true;
            this.lblKomunikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKomunikat.Location = new System.Drawing.Point(21, 251);
            this.lblKomunikat.Name = "lblKomunikat";
            this.lblKomunikat.Size = new System.Drawing.Size(0, 26);
            this.lblKomunikat.TabIndex = 11;
            this.lblKomunikat.Click += new System.EventHandler(this.label6_Click);
            // 
            // wyczyscbutton
            // 
            this.wyczyscbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyczyscbutton.Location = new System.Drawing.Point(271, 354);
            this.wyczyscbutton.Name = "wyczyscbutton";
            this.wyczyscbutton.Size = new System.Drawing.Size(232, 67);
            this.wyczyscbutton.TabIndex = 12;
            this.wyczyscbutton.Text = "Wyczyść formularz";
            this.wyczyscbutton.UseVisualStyleBackColor = true;
            this.wyczyscbutton.Click += new System.EventHandler(this.wyczyscbutton_Click);
            // 
            // panelWynik
            // 
            this.panelWynik.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelWynik.Location = new System.Drawing.Point(463, 115);
            this.panelWynik.Name = "panelWynik";
            this.panelWynik.Size = new System.Drawing.Size(225, 45);
            this.panelWynik.TabIndex = 14;
            // 
            // Sprawdzbutton
            // 
            this.Sprawdzbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Sprawdzbutton.Location = new System.Drawing.Point(254, 193);
            this.Sprawdzbutton.Name = "Sprawdzbutton";
            this.Sprawdzbutton.Size = new System.Drawing.Size(191, 52);
            this.Sprawdzbutton.TabIndex = 15;
            this.Sprawdzbutton.Text = "Sprawdź";
            this.Sprawdzbutton.UseVisualStyleBackColor = true;
            this.Sprawdzbutton.Click += new System.EventHandler(this.Sprawdzbutton_Click);
            // 
            // LinkLabelOtylosc
            // 
            this.LinkLabelOtylosc.AutoSize = true;
            this.LinkLabelOtylosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LinkLabelOtylosc.Location = new System.Drawing.Point(215, 307);
            this.LinkLabelOtylosc.Name = "LinkLabelOtylosc";
            this.LinkLabelOtylosc.Size = new System.Drawing.Size(372, 26);
            this.LinkLabelOtylosc.TabIndex = 16;
            this.LinkLabelOtylosc.TabStop = true;
            this.LinkLabelOtylosc.Text = "Poznaj sposoby na walkę z otyłością.";
            this.LinkLabelOtylosc.Visible = false;
            this.LinkLabelOtylosc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelOtylosc_LinkClicked);
            // 
            // button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LinkLabelOtylosc);
            this.Controls.Add(this.Sprawdzbutton);
            this.Controls.Add(this.panelWynik);
            this.Controls.Add(this.wyczyscbutton);
            this.Controls.Add(this.lblKomunikat);
            this.Controls.Add(this.txtwiek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblKategoria);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.obliczbutton);
            this.Controls.Add(this.txtwzrost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtwaga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtwaga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtwzrost;
        private System.Windows.Forms.Button obliczbutton;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblKategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtwiek;
        private System.Windows.Forms.Label lblKomunikat;
        private System.Windows.Forms.Button wyczyscbutton;
        private System.Windows.Forms.Panel panelWynik;
        private System.Windows.Forms.Button Sprawdzbutton;
        private System.Windows.Forms.LinkLabel LinkLabelOtylosc;
    }
}

