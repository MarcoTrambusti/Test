namespace TrovaMaxMin
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCarica = new System.Windows.Forms.Button();
            this.nupNumero = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblArray = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(160, 42);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(75, 23);
            this.btnCarica.TabIndex = 0;
            this.btnCarica.Text = "Carica ";
            this.btnCarica.UseVisualStyleBackColor = true;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // nupNumero
            // 
            this.nupNumero.Location = new System.Drawing.Point(12, 42);
            this.nupNumero.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupNumero.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nupNumero.Name = "nupNumero";
            this.nupNumero.Size = new System.Drawing.Size(120, 20);
            this.nupNumero.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carica 10 numeri";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(12, 83);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(30, 13);
            this.lblMax.TabIndex = 3;
            this.lblMax.Text = "Max:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(12, 108);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(27, 13);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "Min:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(160, 95);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Location = new System.Drawing.Point(12, 147);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(75, 13);
            this.lblArray.TabIndex = 6;
            this.lblArray.Text = "Array ordinato:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 178);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupNumero);
            this.Controls.Add(this.btnCarica);
            this.Name = "Form1";
            this.Text = "MaxMin";
            ((System.ComponentModel.ISupportInitialize)(this.nupNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.NumericUpDown nupNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblArray;
    }
}

