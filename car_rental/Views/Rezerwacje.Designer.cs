
namespace car_rental.Views
{
    partial class Rezerwacje
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxKlient = new System.Windows.Forms.ComboBox();
            this.dataGridViewLok2 = new System.Windows.Forms.DataGridView();
            this.rent = new System.Windows.Forms.Button();
            this.dataGridViewLok1 = new System.Windows.Forms.DataGridView();
            this.edit = new System.Windows.Forms.Button();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.dataGridViewCar = new System.Windows.Forms.DataGridView();
            this.rents_dataGridView = new System.Windows.Forms.DataGridView();
            this.new_rent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ComboBoxKlient);
            this.panel1.Controls.Add(this.dataGridViewLok2);
            this.panel1.Controls.Add(this.rent);
            this.panel1.Controls.Add(this.dataGridViewLok1);
            this.panel1.Controls.Add(this.edit);
            this.panel1.Controls.Add(this.dataGridViewClient);
            this.panel1.Controls.Add(this.dataGridViewCar);
            this.panel1.Controls.Add(this.rents_dataGridView);
            this.panel1.Controls.Add(this.new_rent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 453);
            this.panel1.TabIndex = 0;
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
            // dataGridViewLok2
            // 
            this.dataGridViewLok2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLok2.Enabled = false;
            this.dataGridViewLok2.Location = new System.Drawing.Point(134, 251);
            this.dataGridViewLok2.Name = "dataGridViewLok2";
            this.dataGridViewLok2.RowHeadersWidth = 51;
            this.dataGridViewLok2.RowTemplate.Height = 24;
            this.dataGridViewLok2.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewLok2.TabIndex = 48;
            this.dataGridViewLok2.Visible = false;
            // 
            // rent
            // 
            this.rent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.rent.FlatAppearance.BorderSize = 0;
            this.rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rent.ForeColor = System.Drawing.Color.White;
            this.rent.Location = new System.Drawing.Point(345, 19);
            this.rent.MinimumSize = new System.Drawing.Size(150, 50);
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(150, 50);
            this.rent.TabIndex = 51;
            this.rent.Text = "Wypożycz";
            this.rent.UseVisualStyleBackColor = false;
            this.rent.Click += new System.EventHandler(this.rent_Click);
            // 
            // dataGridViewLok1
            // 
            this.dataGridViewLok1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLok1.Enabled = false;
            this.dataGridViewLok1.Location = new System.Drawing.Point(82, 95);
            this.dataGridViewLok1.Name = "dataGridViewLok1";
            this.dataGridViewLok1.RowHeadersWidth = 51;
            this.dataGridViewLok1.RowTemplate.Height = 24;
            this.dataGridViewLok1.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewLok1.TabIndex = 47;
            this.dataGridViewLok1.Visible = false;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(179, 19);
            this.edit.MinimumSize = new System.Drawing.Size(150, 50);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(150, 50);
            this.edit.TabIndex = 50;
            this.edit.Text = "Edytuj";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Enabled = false;
            this.dataGridViewClient.Location = new System.Drawing.Point(404, 108);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.RowTemplate.Height = 24;
            this.dataGridViewClient.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewClient.TabIndex = 46;
            this.dataGridViewClient.Visible = false;
            // 
            // dataGridViewCar
            // 
            this.dataGridViewCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCar.Enabled = false;
            this.dataGridViewCar.Location = new System.Drawing.Point(650, 180);
            this.dataGridViewCar.Name = "dataGridViewCar";
            this.dataGridViewCar.RowHeadersWidth = 51;
            this.dataGridViewCar.RowTemplate.Height = 24;
            this.dataGridViewCar.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewCar.TabIndex = 45;
            this.dataGridViewCar.Visible = false;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rents_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.rents_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rents_dataGridView.GridColor = System.Drawing.Color.DimGray;
            this.rents_dataGridView.Location = new System.Drawing.Point(12, 85);
            this.rents_dataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.rents_dataGridView.MinimumSize = new System.Drawing.Size(938, 349);
            this.rents_dataGridView.Name = "rents_dataGridView";
            this.rents_dataGridView.RowHeadersWidth = 51;
            this.rents_dataGridView.RowTemplate.Height = 24;
            this.rents_dataGridView.Size = new System.Drawing.Size(938, 349);
            this.rents_dataGridView.TabIndex = 47;
            this.rents_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rents_dataGridView_CellClick);
            // 
            // new_rent
            // 
            this.new_rent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.new_rent.FlatAppearance.BorderSize = 0;
            this.new_rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.new_rent.ForeColor = System.Drawing.Color.White;
            this.new_rent.Location = new System.Drawing.Point(12, 19);
            this.new_rent.MinimumSize = new System.Drawing.Size(150, 50);
            this.new_rent.Name = "new_rent";
            this.new_rent.Size = new System.Drawing.Size(150, 50);
            this.new_rent.TabIndex = 46;
            this.new_rent.Text = "Dodaj";
            this.new_rent.UseVisualStyleBackColor = false;
            this.new_rent.Click += new System.EventHandler(this.new_rent_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(511, 19);
            this.button1.MinimumSize = new System.Drawing.Size(150, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 91;
            this.button1.Text = "Anuluj ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rezerwacje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 453);
            this.Controls.Add(this.panel1);
            this.Name = "Rezerwacje";
            this.Text = "Rezerwacje";
            this.Load += new System.EventHandler(this.Rezerwacje_Load);
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
        private System.Windows.Forms.Button rent;
        private System.Windows.Forms.Button edit;
        public System.Windows.Forms.DataGridView rents_dataGridView;
        private System.Windows.Forms.Button new_rent;
        private System.Windows.Forms.DataGridView dataGridViewLok2;
        private System.Windows.Forms.DataGridView dataGridViewLok1;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.DataGridView dataGridViewCar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox ComboBoxKlient;
        private System.Windows.Forms.Button button1;
    }
}