
namespace Zatvor
{
    partial class PocetnaStranica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaStranica));
            this.btnZatvorskeJed = new System.Windows.Forms.Button();
            this.btnZaposleni = new System.Windows.Forms.Button();
            this.btnZatvorenici = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZatvorskeJed
            // 
            this.btnZatvorskeJed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnZatvorskeJed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvorskeJed.Location = new System.Drawing.Point(100, 288);
            this.btnZatvorskeJed.Name = "btnZatvorskeJed";
            this.btnZatvorskeJed.Size = new System.Drawing.Size(285, 60);
            this.btnZatvorskeJed.TabIndex = 0;
            this.btnZatvorskeJed.Text = "Zatvorke jedinice";
            this.btnZatvorskeJed.UseVisualStyleBackColor = false;
            this.btnZatvorskeJed.Click += new System.EventHandler(this.btnZatvorskeJed_Click);
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnZaposleni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaposleni.Location = new System.Drawing.Point(100, 372);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(285, 60);
            this.btnZaposleni.TabIndex = 1;
            this.btnZaposleni.Text = "Zaposleni";
            this.btnZaposleni.UseVisualStyleBackColor = false;
            this.btnZaposleni.Click += new System.EventHandler(this.btnZaposleni_Click);
            // 
            // btnZatvorenici
            // 
            this.btnZatvorenici.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnZatvorenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvorenici.Location = new System.Drawing.Point(100, 452);
            this.btnZatvorenici.Name = "btnZatvorenici";
            this.btnZatvorenici.Size = new System.Drawing.Size(285, 60);
            this.btnZatvorenici.TabIndex = 2;
            this.btnZatvorenici.Text = "Zatvorenici";
            this.btnZatvorenici.UseVisualStyleBackColor = false;
            this.btnZatvorenici.Click += new System.EventHandler(this.btnZatvorenici_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(127, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 201);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "ZATVOR";
            // 
            // PocetnaStranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(488, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnZatvorenici);
            this.Controls.Add(this.btnZaposleni);
            this.Controls.Add(this.btnZatvorskeJed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PocetnaStranica";
            this.Text = "Pocetna Stranica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZatvorskeJed;
        private System.Windows.Forms.Button btnZaposleni;
        private System.Windows.Forms.Button btnZatvorenici;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}