namespace GraGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosuj = new System.Windows.Forms.GroupBox();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.labelDo = new System.Windows.Forms.Label();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.labelOd = new System.Windows.Forms.Label();
            this.groupBoxZgadnij = new System.Windows.Forms.GroupBox();
            this.labelWynik = new System.Windows.Forms.Label();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.textBoxOdpowiedz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLiczbaProbText = new System.Windows.Forms.Label();
            this.labelLiczbaProb = new System.Windows.Forms.Label();
            this.groupBoxLosuj.SuspendLayout();
            this.groupBoxZgadnij.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(17, 16);
            this.buttonNowaGra.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(100, 28);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosuj
            // 
            this.groupBoxLosuj.Controls.Add(this.buttonLosuj);
            this.groupBoxLosuj.Controls.Add(this.textBoxDo);
            this.groupBoxLosuj.Controls.Add(this.labelDo);
            this.groupBoxLosuj.Controls.Add(this.textBoxOd);
            this.groupBoxLosuj.Controls.Add(this.labelOd);
            this.groupBoxLosuj.Location = new System.Drawing.Point(17, 64);
            this.groupBoxLosuj.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLosuj.Name = "groupBoxLosuj";
            this.groupBoxLosuj.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLosuj.Size = new System.Drawing.Size(403, 123);
            this.groupBoxLosuj.TabIndex = 1;
            this.groupBoxLosuj.TabStop = false;
            this.groupBoxLosuj.Text = "Losowanie";
            this.groupBoxLosuj.Visible = false;
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(276, 49);
            this.buttonLosuj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(100, 28);
            this.buttonLosuj.TabIndex = 2;
            this.buttonLosuj.Text = "Wylosuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            this.buttonLosuj.Click += new System.EventHandler(this.buttonLosuj_Click);
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(109, 78);
            this.textBoxDo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(132, 22);
            this.textBoxDo.TabIndex = 3;
            // 
            // labelDo
            // 
            this.labelDo.AutoSize = true;
            this.labelDo.Location = new System.Drawing.Point(23, 81);
            this.labelDo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDo.Name = "labelDo";
            this.labelDo.Size = new System.Drawing.Size(76, 17);
            this.labelDo.TabIndex = 2;
            this.labelDo.Text = "Zakres do:";
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(109, 21);
            this.textBoxOd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(132, 22);
            this.textBoxOd.TabIndex = 1;
            // 
            // labelOd
            // 
            this.labelOd.AutoSize = true;
            this.labelOd.Location = new System.Drawing.Point(24, 25);
            this.labelOd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOd.Name = "labelOd";
            this.labelOd.Size = new System.Drawing.Size(76, 17);
            this.labelOd.TabIndex = 0;
            this.labelOd.Text = "Zakres od:";
            // 
            // groupBoxZgadnij
            // 
            this.groupBoxZgadnij.Controls.Add(this.labelLiczbaProbText);
            this.groupBoxZgadnij.Controls.Add(this.labelWynik);
            this.groupBoxZgadnij.Controls.Add(this.labelLiczbaProb);
            this.groupBoxZgadnij.Controls.Add(this.buttonSprawdz);
            this.groupBoxZgadnij.Controls.Add(this.textBoxOdpowiedz);
            this.groupBoxZgadnij.Controls.Add(this.label2);
            this.groupBoxZgadnij.Location = new System.Drawing.Point(17, 216);
            this.groupBoxZgadnij.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxZgadnij.Name = "groupBoxZgadnij";
            this.groupBoxZgadnij.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxZgadnij.Size = new System.Drawing.Size(403, 167);
            this.groupBoxZgadnij.TabIndex = 2;
            this.groupBoxZgadnij.TabStop = false;
            this.groupBoxZgadnij.Text = "Zgadnij wynik";
            this.groupBoxZgadnij.Visible = false;
            this.groupBoxZgadnij.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWynik.Location = new System.Drawing.Point(23, 102);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(67, 17);
            this.labelWynik.TabIndex = 3;
            this.labelWynik.Text = "WYNIK: ";
            this.labelWynik.Visible = false;
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Enabled = false;
            this.buttonSprawdz.Location = new System.Drawing.Point(276, 19);
            this.buttonSprawdz.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(100, 28);
            this.buttonSprawdz.TabIndex = 2;
            this.buttonSprawdz.Text = "Sprawdz";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            this.buttonSprawdz.Click += new System.EventHandler(this.ButtonSprawdz_Click);
            // 
            // textBoxOdpowiedz
            // 
            this.textBoxOdpowiedz.Enabled = false;
            this.textBoxOdpowiedz.Location = new System.Drawing.Point(109, 21);
            this.textBoxOdpowiedz.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOdpowiedz.Name = "textBoxOdpowiedz";
            this.textBoxOdpowiedz.Size = new System.Drawing.Size(132, 22);
            this.textBoxOdpowiedz.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Podaj liczbe";
            // 
            // labelLiczbaProbText
            // 
            this.labelLiczbaProbText.AutoSize = true;
            this.labelLiczbaProbText.Location = new System.Drawing.Point(24, 68);
            this.labelLiczbaProbText.Name = "labelLiczbaProbText";
            this.labelLiczbaProbText.Size = new System.Drawing.Size(90, 17);
            this.labelLiczbaProbText.TabIndex = 5;
            this.labelLiczbaProbText.Text = "Liczba prób: ";
            this.labelLiczbaProbText.Visible = false;
            // 
            // labelLiczbaProb
            // 
            this.labelLiczbaProb.AutoSize = true;
            this.labelLiczbaProb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLiczbaProb.Location = new System.Drawing.Point(120, 68);
            this.labelLiczbaProb.Name = "labelLiczbaProb";
            this.labelLiczbaProb.Size = new System.Drawing.Size(17, 17);
            this.labelLiczbaProb.TabIndex = 4;
            this.labelLiczbaProb.Text = "0";
            this.labelLiczbaProb.Visible = false;
            this.labelLiczbaProb.Click += new System.EventHandler(this.LabelLiczbaProb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 416);
            this.Controls.Add(this.groupBoxZgadnij);
            this.Controls.Add(this.groupBoxLosuj);
            this.Controls.Add(this.buttonNowaGra);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxLosuj.ResumeLayout(false);
            this.groupBoxLosuj.PerformLayout();
            this.groupBoxZgadnij.ResumeLayout(false);
            this.groupBoxZgadnij.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosuj;
        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.Label labelDo;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.Label labelOd;
        private System.Windows.Forms.GroupBox groupBoxZgadnij;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.TextBox textBoxOdpowiedz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.Label labelLiczbaProbText;
        private System.Windows.Forms.Label labelLiczbaProb;
    }
}

