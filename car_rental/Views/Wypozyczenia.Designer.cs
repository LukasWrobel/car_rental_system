
namespace car_rental.Views
{
    partial class Wypozyczenia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewLok2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewLok1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.dataGridViewCar = new System.Windows.Forms.DataGridView();
            this.edit_rent = new System.Windows.Forms.Button();
            this.end_rent = new System.Windows.Forms.Button();
            this.rents_dataGridView = new System.Windows.Forms.DataGridView();
            this.rent_details = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxKlient = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLok2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLok1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rents_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ComboBoxKlient);
            this.panel1.Controls.Add(this.dataGridViewLok2);
            this.panel1.Controls.Add(this.dataGridViewLok1);
            this.panel1.Controls.Add(this.dataGridViewClient);
            this.panel1.Controls.Add(this.dataGridViewCar);
            this.panel1.Controls.Add(this.edit_rent);
            this.panel1.Controls.Add(this.end_rent);
            this.panel1.Controls.Add(this.rents_dataGridView);
            this.panel1.Controls.Add(this.rent_details);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 453);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewLok2
            // 
            this.dataGridViewLok2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLok2.Enabled = false;
            this.dataGridViewLok2.Location = new System.Drawing.Point(78, 266);
            this.dataGridViewLok2.Name = "dataGridViewLok2";
            this.dataGridViewLok2.RowHeadersWidth = 51;
            this.dataGridViewLok2.RowTemplate.Height = 24;
            this.dataGridViewLok2.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewLok2.TabIndex = 44;
            this.dataGridViewLok2.Visible = false;
            // 
            // dataGridViewLok1
            // 
            this.dataGridViewLok1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLok1.Enabled = false;
            this.dataGridViewLok1.Location = new System.Drawing.Point(26, 110);
            this.dataGridViewLok1.Name = "dataGridViewLok1";
            this.dataGridViewLok1.RowHeadersWidth = 51;
            this.dataGridViewLok1.RowTemplate.Height = 24;
            this.dataGridViewLok1.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewLok1.TabIndex = 43;
            this.dataGridViewLok1.Visible = false;
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Enabled = false;
            this.dataGridViewClient.Location = new System.Drawing.Point(348, 123);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.RowTemplate.Height = 24;
            this.dataGridViewClient.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewClient.TabIndex = 42;
            this.dataGridViewClient.Visible = false;
            // 
            // dataGridViewCar
            // 
            this.dataGridViewCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCar.Enabled = false;
            this.dataGridViewCar.Location = new System.Drawing.Point(594, 195);
            this.dataGridViewCar.Name = "dataGridViewCar";
            this.dataGridViewCar.RowHeadersWidth = 51;
            this.dataGridViewCar.RowTemplate.Height = 24;
            this.dataGridViewCar.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewCar.TabIndex = 41;
            this.dataGridViewCar.Visible = false;
            // 
            // edit_rent
            // 
            this.edit_rent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.edit_rent.FlatAppearance.BorderSize = 0;
            this.edit_rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edit_rent.ForeColor = System.Drawing.Color.White;
            this.edit_rent.Location = new System.Drawing.Point(168, 19);
            this.edit_rent.MinimumSize = new System.Drawing.Size(150, 50);
            this.edit_rent.Name = "edit_rent";
            this.edit_rent.Size = new System.Drawing.Size(150, 50);
            this.edit_rent.TabIndex = 40;
            this.edit_rent.Text = "Edytuj";
            this.edit_rent.UseVisualStyleBackColor = false;
            this.edit_rent.Click += new System.EventHandler(this.edit_rent_Click);
            // 
            // end_rent
            // 
            this.end_rent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.end_rent.FlatAppearance.BorderSize = 0;
            this.end_rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.end_rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.end_rent.ForeColor = System.Drawing.Color.White;
            this.end_rent.Location = new System.Drawing.Point(324, 19);
            this.end_rent.MinimumSize = new System.Drawing.Size(150, 50);
            this.end_rent.Name = "end_rent";
            this.end_rent.Size = new System.Drawing.Size(150, 50);
            this.end_rent.TabIndex = 39;
            this.end_rent.Text = "Zakończ";
            this.end_rent.UseVisualStyleBackColor = false;
            this.end_rent.Click += new System.EventHandler(this.end_rent_Click);
            // 
            // rents_dataGridView
            // 
            this.rents_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rents_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rents_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.rents_dataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.rents_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rents_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rents_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rents_dataGridView.GridColor = System.Drawing.Color.DimGray;
            this.rents_dataGridView.Location = new System.Drawing.Point(12, 85);
            this.rents_dataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.rents_dataGridView.MinimumSize = new System.Drawing.Size(938, 349);
            this.rents_dataGridView.Name = "rents_dataGridView";
            this.rents_dataGridView.RowHeadersWidth = 51;
            this.rents_dataGridView.RowTemplate.Height = 24;
            this.rents_dataGridView.Size = new System.Drawing.Size(938, 349);
            this.rents_dataGridView.TabIndex = 35;
            this.rents_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rents_dataGridView_CellClick);
            // 
            // rent_details
            // 
            this.rent_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.rent_details.FlatAppearance.BorderSize = 0;
            this.rent_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rent_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rent_details.ForeColor = System.Drawing.Color.White;
            this.rent_details.Location = new System.Drawing.Point(12, 19);
            this.rent_details.MinimumSize = new System.Drawing.Size(150, 50);
            this.rent_details.Name = "rent_details";
            this.rent_details.Size = new System.Drawing.Size(150, 50);
            this.rent_details.TabIndex = 34;
            this.rent_details.Text = "Szczegóły";
            this.rent_details.UseVisualStyleBackColor = false;
            this.rent_details.Click += new System.EventHandler(this.rent_details_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(635, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 90;
            this.label1.Text = "Wybierz klienta:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ComboBoxKlient
            // 
            this.ComboBoxKlient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxKlient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComboBoxKlient.FormattingEnabled = true;
            this.ComboBoxKlient.Location = new System.Drawing.Point(639, 39);
            this.ComboBoxKlient.MaximumSize = new System.Drawing.Size(400, 0);
            this.ComboBoxKlient.MinimumSize = new System.Drawing.Size(250, 0);
            this.ComboBoxKlient.Name = "ComboBoxKlient";
            this.ComboBoxKlient.Size = new System.Drawing.Size(311, 28);
            this.ComboBoxKlient.TabIndex = 89;
            this.ComboBoxKlient.SelectedIndexChanged += new System.EventHandler(this.ComboBoxKlient_SelectedIndexChanged);
            // 
            // Wypozyczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(962, 453);
            this.Controls.Add(this.panel1);
            this.Name = "Wypozyczenia";
            this.Text = "Wypozyczenia";
            this.Load += new System.EventHandler(this.Wypozyczenia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLok2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLok1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rents_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button end_rent;
        public System.Windows.Forms.DataGridView rents_dataGridView;
        private System.Windows.Forms.Button rent_details;
        private System.Windows.Forms.Button edit_rent;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.DataGridView dataGridViewCar;
        private System.Windows.Forms.DataGridView dataGridViewLok2;
        private System.Windows.Forms.DataGridView dataGridViewLok1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox ComboBoxKlient;
    }
}