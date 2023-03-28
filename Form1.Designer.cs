
namespace Jednostki
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
            this.components = new System.ComponentModel.Container();
            this.radioButtonDlugosc = new System.Windows.Forms.RadioButton();
            this.radioButtonMasa = new System.Windows.Forms.RadioButton();
            this.radioButtonCzas = new System.Windows.Forms.RadioButton();
            this.listBoxNazwy = new System.Windows.Forms.ListBox();
            this.textBoxWartosc = new System.Windows.Forms.TextBox();
            this.textBoxWynik = new System.Windows.Forms.TextBox();
            this.labelWartosc = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonDlugosc
            // 
            this.radioButtonDlugosc.AutoSize = true;
            this.radioButtonDlugosc.Location = new System.Drawing.Point(38, 40);
            this.radioButtonDlugosc.Name = "radioButtonDlugosc";
            this.radioButtonDlugosc.Size = new System.Drawing.Size(66, 17);
            this.radioButtonDlugosc.TabIndex = 0;
            this.radioButtonDlugosc.TabStop = true;
            this.radioButtonDlugosc.Text = "Długość";
            this.radioButtonDlugosc.UseVisualStyleBackColor = true;
            this.radioButtonDlugosc.CheckedChanged += new System.EventHandler(this.radioButtonDlugosc_CheckedChanged);
            // 
            // radioButtonMasa
            // 
            this.radioButtonMasa.AutoSize = true;
            this.radioButtonMasa.Location = new System.Drawing.Point(38, 64);
            this.radioButtonMasa.Name = "radioButtonMasa";
            this.radioButtonMasa.Size = new System.Drawing.Size(51, 17);
            this.radioButtonMasa.TabIndex = 1;
            this.radioButtonMasa.TabStop = true;
            this.radioButtonMasa.Text = "Masa";
            this.radioButtonMasa.UseVisualStyleBackColor = true;
            this.radioButtonMasa.CheckedChanged += new System.EventHandler(this.radioButtonMasa_CheckedChanged);
            // 
            // radioButtonCzas
            // 
            this.radioButtonCzas.AutoSize = true;
            this.radioButtonCzas.Location = new System.Drawing.Point(38, 88);
            this.radioButtonCzas.Name = "radioButtonCzas";
            this.radioButtonCzas.Size = new System.Drawing.Size(48, 17);
            this.radioButtonCzas.TabIndex = 2;
            this.radioButtonCzas.TabStop = true;
            this.radioButtonCzas.Text = "Czas";
            this.radioButtonCzas.UseVisualStyleBackColor = true;
            this.radioButtonCzas.CheckedChanged += new System.EventHandler(this.radioButtonCzas_CheckedChanged);
            // 
            // listBoxNazwy
            // 
            this.listBoxNazwy.FormattingEnabled = true;
            this.listBoxNazwy.Location = new System.Drawing.Point(178, 40);
            this.listBoxNazwy.Name = "listBoxNazwy";
            this.listBoxNazwy.Size = new System.Drawing.Size(120, 95);
            this.listBoxNazwy.TabIndex = 3;
            this.listBoxNazwy.SelectedIndexChanged += new System.EventHandler(this.listBoxNazwy_SelectedIndexChanged);
            // 
            // textBoxWartosc
            // 
            this.textBoxWartosc.Location = new System.Drawing.Point(38, 194);
            this.textBoxWartosc.Name = "textBoxWartosc";
            this.textBoxWartosc.Size = new System.Drawing.Size(100, 20);
            this.textBoxWartosc.TabIndex = 4;
            this.textBoxWartosc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxWartosc_KeyDown);
            // 
            // textBoxWynik
            // 
            this.textBoxWynik.Location = new System.Drawing.Point(380, 40);
            this.textBoxWynik.Multiline = true;
            this.textBoxWynik.Name = "textBoxWynik";
            this.textBoxWynik.Size = new System.Drawing.Size(100, 174);
            this.textBoxWynik.TabIndex = 5;
            // 
            // labelWartosc
            // 
            this.labelWartosc.AutoSize = true;
            this.labelWartosc.Location = new System.Drawing.Point(35, 178);
            this.labelWartosc.Name = "labelWartosc";
            this.labelWartosc.Size = new System.Drawing.Size(65, 13);
            this.labelWartosc.TabIndex = 6;
            this.labelWartosc.Text = "Długość [m]";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 307);
            this.Controls.Add(this.labelWartosc);
            this.Controls.Add(this.textBoxWynik);
            this.Controls.Add(this.textBoxWartosc);
            this.Controls.Add(this.listBoxNazwy);
            this.Controls.Add(this.radioButtonCzas);
            this.Controls.Add(this.radioButtonMasa);
            this.Controls.Add(this.radioButtonDlugosc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Przelicznik jednostek";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonDlugosc;
        private System.Windows.Forms.RadioButton radioButtonMasa;
        private System.Windows.Forms.RadioButton radioButtonCzas;
        private System.Windows.Forms.ListBox listBoxNazwy;
        private System.Windows.Forms.TextBox textBoxWartosc;
        private System.Windows.Forms.TextBox textBoxWynik;
        private System.Windows.Forms.Label labelWartosc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

