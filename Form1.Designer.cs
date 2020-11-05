namespace CS322_DZ02
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txbIme = new System.Windows.Forms.TextBox();
            this.txbAdresa = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(63, 46);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(63, 80);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(40, 13);
            this.lblAdresa.TabIndex = 1;
            this.lblAdresa.Text = "Adresa";
            // 
            // txbIme
            // 
            this.txbIme.Location = new System.Drawing.Point(122, 43);
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(100, 20);
            this.txbIme.TabIndex = 2;
            // 
            // txbAdresa
            // 
            this.txbAdresa.Location = new System.Drawing.Point(122, 77);
            this.txbAdresa.Name = "txbAdresa";
            this.txbAdresa.Size = new System.Drawing.Size(100, 20);
            this.txbAdresa.TabIndex = 3;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(286, 163);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 4;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 198);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txbAdresa);
            this.Controls.Add(this.txbIme);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblIme);
            this.Name = "Form1";
            this.Text = "CS322-DZ02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.TextBox txbAdresa;
        private System.Windows.Forms.Button btnUnesi;
    }
}

