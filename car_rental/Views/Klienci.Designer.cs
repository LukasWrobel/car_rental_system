
namespace car_rental
{
    partial class Klienci
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delete_client = new System.Windows.Forms.Button();
            this.edit_client = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new car_rental.Controls.TextBox();
            this.search = new FontAwesome.Sharp.IconButton();
            this.clients_dataGridView = new System.Windows.Forms.DataGridView();
            this.new_client = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clients_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.delete_client);
            this.panel1.Controls.Add(this.edit_client);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.clients_dataGridView);
            this.panel1.Controls.Add(this.new_client);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 453);
            this.panel1.TabIndex = 0;
            // 
            // delete_client
            // 
            this.delete_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.delete_client.FlatAppearance.BorderSize = 0;
            this.delete_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete_client.ForeColor = System.Drawing.Color.White;
            this.delete_client.Location = new System.Drawing.Point(345, 19);
            this.delete_client.MinimumSize = new System.Drawing.Size(150, 50);
            this.delete_client.Name = "delete_client";
            this.delete_client.Size = new System.Drawing.Size(150, 50);
            this.delete_client.TabIndex = 23;
            this.delete_client.Text = "Usuń";
            this.delete_client.UseVisualStyleBackColor = false;
            this.delete_client.Click += new System.EventHandler(this.delete_client_Click);
            // 
            // edit_client
            // 
            this.edit_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.edit_client.FlatAppearance.BorderSize = 0;
            this.edit_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edit_client.ForeColor = System.Drawing.Color.White;
            this.edit_client.Location = new System.Drawing.Point(179, 19);
            this.edit_client.MinimumSize = new System.Drawing.Size(150, 50);
            this.edit_client.Name = "edit_client";
            this.edit_client.Size = new System.Drawing.Size(150, 50);
            this.edit_client.TabIndex = 22;
            this.edit_client.Text = "Edytuj";
            this.edit_client.UseVisualStyleBackColor = false;
            this.edit_client.Click += new System.EventHandler(this.edit_client_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(651, 23);
            this.panel2.MaximumSize = new System.Drawing.Size(300, 50);
            this.panel2.MinimumSize = new System.Drawing.Size(300, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 50);
            this.panel2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderColor = System.Drawing.Color.Black;
            this.textBox1.BorderFocusColor = System.Drawing.Color.Black;
            this.textBox1.BorderSize = 2;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new System.Windows.Forms.Padding(7);
            this.textBox1.PasswordChar = false;
            this.textBox1.Size = new System.Drawing.Size(300, 44);
            this.textBox1.TabIndex = 8;
            this.textBox1.Texts = "";
            this.textBox1.UnderlinedStyle = true;
            this.textBox1._TextChanged += new System.EventHandler(this.textBox1__TextChanged);
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.search.IconColor = System.Drawing.Color.White;
            this.search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.search.IconSize = 40;
            this.search.Location = new System.Drawing.Point(594, 19);
            this.search.MinimumSize = new System.Drawing.Size(50, 50);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(50, 50);
            this.search.TabIndex = 20;
            this.search.UseVisualStyleBackColor = false;
            // 
            // clients_dataGridView
            // 
            this.clients_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clients_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clients_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.clients_dataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.clients_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clients_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.clients_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clients_dataGridView.GridColor = System.Drawing.Color.DimGray;
            this.clients_dataGridView.Location = new System.Drawing.Point(12, 85);
            this.clients_dataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.clients_dataGridView.MinimumSize = new System.Drawing.Size(938, 349);
            this.clients_dataGridView.Name = "clients_dataGridView";
            this.clients_dataGridView.RowHeadersWidth = 51;
            this.clients_dataGridView.RowTemplate.Height = 24;
            this.clients_dataGridView.Size = new System.Drawing.Size(938, 349);
            this.clients_dataGridView.TabIndex = 19;
            this.clients_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clients_dataGridView_CellClick);
            // 
            // new_client
            // 
            this.new_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.new_client.FlatAppearance.BorderSize = 0;
            this.new_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.new_client.ForeColor = System.Drawing.Color.White;
            this.new_client.Location = new System.Drawing.Point(12, 19);
            this.new_client.MinimumSize = new System.Drawing.Size(150, 50);
            this.new_client.Name = "new_client";
            this.new_client.Size = new System.Drawing.Size(150, 50);
            this.new_client.TabIndex = 18;
            this.new_client.Text = "Dodaj";
            this.new_client.UseVisualStyleBackColor = false;
            this.new_client.Click += new System.EventHandler(this.new_client_Click);
            // 
            // Klienci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(962, 453);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(980, 500);
            this.Name = "Klienci";
            this.Text = "Klienci";
            this.Load += new System.EventHandler(this.Klienci_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clients_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delete_client;
        private System.Windows.Forms.Button edit_client;
        private System.Windows.Forms.Panel panel2;
        private Controls.TextBox textBox1;
        private FontAwesome.Sharp.IconButton search;
        public System.Windows.Forms.DataGridView clients_dataGridView;
        private System.Windows.Forms.Button new_client;
    }
}