namespace GraGUI
{
    partial class Form1
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
            this.NowaGra = new System.Windows.Forms.Button();
            this.Losuj = new System.Windows.Forms.GroupBox();
            this.ZakresOd = new System.Windows.Forms.Label();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ZakresDo = new System.Windows.Forms.TextBox();
            this.Wykonuj = new System.Windows.Forms.Button();
            this.Losuj.SuspendLayout();
            this.SuspendLayout();
            // 
            // NowaGra
            // 
            this.NowaGra.Location = new System.Drawing.Point(33, 37);
            this.NowaGra.Name = "NowaGra";
            this.NowaGra.Size = new System.Drawing.Size(75, 23);
            this.NowaGra.TabIndex = 0;
            this.NowaGra.Text = "Nowa Gra";
            this.NowaGra.UseVisualStyleBackColor = true;
            this.NowaGra.Click += new System.EventHandler(this.NowaGra_Click);
            // 
            // Losuj
            // 
            this.Losuj.Controls.Add(this.Wykonuj);
            this.Losuj.Controls.Add(this.ZakresDo);
            this.Losuj.Controls.Add(this.label2);
            this.Losuj.Controls.Add(this.textBoxOd);
            this.Losuj.Controls.Add(this.ZakresOd);
            this.Losuj.Location = new System.Drawing.Point(53, 124);
            this.Losuj.Name = "Losuj";
            this.Losuj.Size = new System.Drawing.Size(285, 136);
            this.Losuj.TabIndex = 1;
            this.Losuj.TabStop = false;
            this.Losuj.Text = "Losowanie";
            this.Losuj.Visible = false;
            // 
            // ZakresOd
            // 
            this.ZakresOd.AutoSize = true;
            this.ZakresOd.Location = new System.Drawing.Point(12, 38);
            this.ZakresOd.Name = "ZakresOd";
            this.ZakresOd.Size = new System.Drawing.Size(58, 13);
            this.ZakresOd.TabIndex = 0;
            this.ZakresOd.Text = "Zakres od:";
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(76, 35);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxOd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zakres do:";
            // 
            // ZakresDo
            // 
            this.ZakresDo.Location = new System.Drawing.Point(76, 68);
            this.ZakresDo.Name = "ZakresDo";
            this.ZakresDo.Size = new System.Drawing.Size(100, 20);
            this.ZakresDo.TabIndex = 3;
            // 
            // Wykonuj
            // 
            this.Wykonuj.Location = new System.Drawing.Point(193, 50);
            this.Wykonuj.Name = "Wykonuj";
            this.Wykonuj.Size = new System.Drawing.Size(75, 23);
            this.Wykonuj.TabIndex = 4;
            this.Wykonuj.Text = "Wykonuj";
            this.Wykonuj.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 495);
            this.Controls.Add(this.Losuj);
            this.Controls.Add(this.NowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Losuj.ResumeLayout(false);
            this.Losuj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NowaGra;
        private System.Windows.Forms.GroupBox Losuj;
        private System.Windows.Forms.Button Wykonuj;
        private System.Windows.Forms.TextBox ZakresDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.Label ZakresOd;
    }
}

