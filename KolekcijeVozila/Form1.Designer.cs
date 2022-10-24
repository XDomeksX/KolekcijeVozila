namespace KolekcijeVozila
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
            this.TXTbrojKotaca = new System.Windows.Forms.TextBox();
            this.TXTmodel = new System.Windows.Forms.TextBox();
            this.TXTgodProizvodnje = new System.Windows.Forms.TextBox();
            this.BTNunesi = new System.Windows.Forms.Button();
            this.BTNobradi = new System.Windows.Forms.Button();
            this.BTNispisi = new System.Windows.Forms.Button();
            this.LBLmodel = new System.Windows.Forms.Label();
            this.LBLgodProizvodnje = new System.Windows.Forms.Label();
            this.LBLbrojKotaca = new System.Windows.Forms.Label();
            this.RTBispis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TXTbrojKotaca
            // 
            this.TXTbrojKotaca.Location = new System.Drawing.Point(118, 58);
            this.TXTbrojKotaca.Name = "TXTbrojKotaca";
            this.TXTbrojKotaca.Size = new System.Drawing.Size(121, 20);
            this.TXTbrojKotaca.TabIndex = 1;
            // 
            // TXTmodel
            // 
            this.TXTmodel.Location = new System.Drawing.Point(118, 6);
            this.TXTmodel.Name = "TXTmodel";
            this.TXTmodel.Size = new System.Drawing.Size(121, 20);
            this.TXTmodel.TabIndex = 2;
            // 
            // TXTgodProizvodnje
            // 
            this.TXTgodProizvodnje.Location = new System.Drawing.Point(118, 32);
            this.TXTgodProizvodnje.Name = "TXTgodProizvodnje";
            this.TXTgodProizvodnje.Size = new System.Drawing.Size(121, 20);
            this.TXTgodProizvodnje.TabIndex = 3;
            // 
            // BTNunesi
            // 
            this.BTNunesi.Location = new System.Drawing.Point(268, 6);
            this.BTNunesi.Name = "BTNunesi";
            this.BTNunesi.Size = new System.Drawing.Size(147, 98);
            this.BTNunesi.TabIndex = 5;
            this.BTNunesi.Text = "Unesi";
            this.BTNunesi.UseVisualStyleBackColor = true;
            this.BTNunesi.Click += new System.EventHandler(this.BTNunesi_Click);
            // 
            // BTNobradi
            // 
            this.BTNobradi.Location = new System.Drawing.Point(421, 6);
            this.BTNobradi.Name = "BTNobradi";
            this.BTNobradi.Size = new System.Drawing.Size(147, 98);
            this.BTNobradi.TabIndex = 6;
            this.BTNobradi.Text = "Obradi";
            this.BTNobradi.UseVisualStyleBackColor = true;
            this.BTNobradi.Click += new System.EventHandler(this.BTNobradi_Click);
            // 
            // BTNispisi
            // 
            this.BTNispisi.Location = new System.Drawing.Point(574, 6);
            this.BTNispisi.Name = "BTNispisi";
            this.BTNispisi.Size = new System.Drawing.Size(143, 98);
            this.BTNispisi.TabIndex = 7;
            this.BTNispisi.Text = "Ispiši";
            this.BTNispisi.UseVisualStyleBackColor = true;
            this.BTNispisi.Click += new System.EventHandler(this.BTNispisi_Click);
            // 
            // LBLmodel
            // 
            this.LBLmodel.AutoSize = true;
            this.LBLmodel.Location = new System.Drawing.Point(12, 9);
            this.LBLmodel.Name = "LBLmodel";
            this.LBLmodel.Size = new System.Drawing.Size(39, 13);
            this.LBLmodel.TabIndex = 8;
            this.LBLmodel.Text = "Model:";
            // 
            // LBLgodProizvodnje
            // 
            this.LBLgodProizvodnje.AutoSize = true;
            this.LBLgodProizvodnje.Location = new System.Drawing.Point(12, 35);
            this.LBLgodProizvodnje.Name = "LBLgodProizvodnje";
            this.LBLgodProizvodnje.Size = new System.Drawing.Size(90, 13);
            this.LBLgodProizvodnje.TabIndex = 9;
            this.LBLgodProizvodnje.Text = "God. proizvodnje:";
            // 
            // LBLbrojKotaca
            // 
            this.LBLbrojKotaca.AutoSize = true;
            this.LBLbrojKotaca.Location = new System.Drawing.Point(12, 61);
            this.LBLbrojKotaca.Name = "LBLbrojKotaca";
            this.LBLbrojKotaca.Size = new System.Drawing.Size(64, 13);
            this.LBLbrojKotaca.TabIndex = 10;
            this.LBLbrojKotaca.Text = "Broj kotaca:";
            // 
            // RTBispis
            // 
            this.RTBispis.Location = new System.Drawing.Point(13, 112);
            this.RTBispis.Name = "RTBispis";
            this.RTBispis.Size = new System.Drawing.Size(704, 320);
            this.RTBispis.TabIndex = 11;
            this.RTBispis.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 444);
            this.Controls.Add(this.RTBispis);
            this.Controls.Add(this.LBLbrojKotaca);
            this.Controls.Add(this.LBLgodProizvodnje);
            this.Controls.Add(this.LBLmodel);
            this.Controls.Add(this.BTNispisi);
            this.Controls.Add(this.BTNobradi);
            this.Controls.Add(this.BTNunesi);
            this.Controls.Add(this.TXTgodProizvodnje);
            this.Controls.Add(this.TXTmodel);
            this.Controls.Add(this.TXTbrojKotaca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTbrojKotaca;
        private System.Windows.Forms.TextBox TXTmodel;
        private System.Windows.Forms.TextBox TXTgodProizvodnje;
        private System.Windows.Forms.Button BTNunesi;
        private System.Windows.Forms.Button BTNobradi;
        private System.Windows.Forms.Button BTNispisi;
        private System.Windows.Forms.Label LBLmodel;
        private System.Windows.Forms.Label LBLgodProizvodnje;
        private System.Windows.Forms.Label LBLbrojKotaca;
        private System.Windows.Forms.RichTextBox RTBispis;
    }
}

