
namespace car_rental.Views
{
    partial class new_localization
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.city_adress = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adres = new System.Windows.Forms.TextBox();
            this.wstecz = new System.Windows.Forms.Button();
            this.kl_dodaj = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.city_adress);
            this.panel2.Location = new System.Drawing.Point(13, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 429);
            this.panel2.TabIndex = 50;
            // 
            // city_adress
            // 
            this.city_adress.AutoSize = true;
            this.city_adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.city_adress.ForeColor = System.Drawing.Color.Black;
            this.city_adress.Location = new System.Drawing.Point(3, 3);
            this.city_adress.Name = "city_adress";
            this.city_adress.Size = new System.Drawing.Size(97, 32);
            this.city_adress.TabIndex = 51;
            this.city_adress.Text = "Adres:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.adres);
            this.panel1.Location = new System.Drawing.Point(174, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 429);
            this.panel1.TabIndex = 49;
            // 
            // adres
            // 
            this.adres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adres.Location = new System.Drawing.Point(0, 0);
            this.adres.MaximumSize = new System.Drawing.Size(600, 38);
            this.adres.MaxLength = 45;
            this.adres.MinimumSize = new System.Drawing.Size(250, 38);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(554, 38);
            this.adres.TabIndex = 54;
            // 
            // wstecz
            // 
            this.wstecz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wstecz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.wstecz.FlatAppearance.BorderSize = 2;
            this.wstecz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wstecz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wstecz.ForeColor = System.Drawing.Color.White;
            this.wstecz.Location = new System.Drawing.Point(750, 148);
            this.wstecz.MinimumSize = new System.Drawing.Size(200, 100);
            this.wstecz.Name = "wstecz";
            this.wstecz.Size = new System.Drawing.Size(200, 100);
            this.wstecz.TabIndex = 48;
            this.wstecz.Text = "Wróć";
            this.wstecz.UseVisualStyleBackColor = false;
            this.wstecz.Click += new System.EventHandler(this.wstecz_Click);
            // 
            // kl_dodaj
            // 
            this.kl_dodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kl_dodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.kl_dodaj.FlatAppearance.BorderSize = 2;
            this.kl_dodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kl_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kl_dodaj.ForeColor = System.Drawing.Color.White;
            this.kl_dodaj.Location = new System.Drawing.Point(750, 12);
            this.kl_dodaj.MinimumSize = new System.Drawing.Size(200, 100);
            this.kl_dodaj.Name = "kl_dodaj";
            this.kl_dodaj.Size = new System.Drawing.Size(200, 100);
            this.kl_dodaj.TabIndex = 47;
            this.kl_dodaj.Text = "Dodaj";
            this.kl_dodaj.UseVisualStyleBackColor = false;
            this.kl_dodaj.Click += new System.EventHandler(this.kl_dodaj_Click);
            // 
            // new_localization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wstecz);
            this.Controls.Add(this.kl_dodaj);
            this.Name = "new_localization";
            this.Text = "new_localization";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label city_adress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button wstecz;
        public System.Windows.Forms.Button kl_dodaj;
        public System.Windows.Forms.TextBox adres;
    }
}