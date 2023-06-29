
namespace car_rental.Views
{
    partial class Lokalizacje
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
            this.delete_localization = new System.Windows.Forms.Button();
            this.edit_localization = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new car_rental.Controls.TextBox();
            this.search = new FontAwesome.Sharp.IconButton();
            this.localization_dataGridView = new System.Windows.Forms.DataGridView();
            this.new_localization = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localization_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.delete_localization);
            this.panel1.Controls.Add(this.edit_localization);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.localization_dataGridView);
            this.panel1.Controls.Add(this.new_localization);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 453);
            this.panel1.TabIndex = 0;
            // 
            // delete_localization
            // 
            this.delete_localization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.delete_localization.FlatAppearance.BorderSize = 0;
            this.delete_localization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_localization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete_localization.ForeColor = System.Drawing.Color.White;
            this.delete_localization.Location = new System.Drawing.Point(345, 19);
            this.delete_localization.MinimumSize = new System.Drawing.Size(150, 50);
            this.delete_localization.Name = "delete_localization";
            this.delete_localization.Size = new System.Drawing.Size(150, 50);
            this.delete_localization.TabIndex = 36;
            this.delete_localization.Text = "Usuń";
            this.delete_localization.UseVisualStyleBackColor = false;
            this.delete_localization.Click += new System.EventHandler(this.delete_localization_Click);
            // 
            // edit_localization
            // 
            this.edit_localization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.edit_localization.FlatAppearance.BorderSize = 0;
            this.edit_localization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_localization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edit_localization.ForeColor = System.Drawing.Color.White;
            this.edit_localization.Location = new System.Drawing.Point(179, 19);
            this.edit_localization.MinimumSize = new System.Drawing.Size(150, 50);
            this.edit_localization.Name = "edit_localization";
            this.edit_localization.Size = new System.Drawing.Size(150, 50);
            this.edit_localization.TabIndex = 35;
            this.edit_localization.Text = "Edytuj";
            this.edit_localization.UseVisualStyleBackColor = false;
            this.edit_localization.Click += new System.EventHandler(this.edit_localization_Click);
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
            this.panel2.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderColor = System.Drawing.Color.Black;
            this.textBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
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
            this.textBox1.TabIndex = 7;
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
            this.search.TabIndex = 33;
            this.search.UseVisualStyleBackColor = false;
            // 
            // localization_dataGridView
            // 
            this.localization_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.localization_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.localization_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.localization_dataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.localization_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.localization_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.localization_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.localization_dataGridView.GridColor = System.Drawing.Color.DimGray;
            this.localization_dataGridView.Location = new System.Drawing.Point(12, 85);
            this.localization_dataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.localization_dataGridView.MinimumSize = new System.Drawing.Size(938, 349);
            this.localization_dataGridView.Name = "localization_dataGridView";
            this.localization_dataGridView.RowHeadersWidth = 51;
            this.localization_dataGridView.RowTemplate.Height = 24;
            this.localization_dataGridView.Size = new System.Drawing.Size(938, 349);
            this.localization_dataGridView.TabIndex = 32;
            this.localization_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.localization_dataGridView_CellClick);
            // 
            // new_localization
            // 
            this.new_localization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.new_localization.FlatAppearance.BorderSize = 0;
            this.new_localization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_localization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.new_localization.ForeColor = System.Drawing.Color.White;
            this.new_localization.Location = new System.Drawing.Point(12, 19);
            this.new_localization.MinimumSize = new System.Drawing.Size(150, 50);
            this.new_localization.Name = "new_localization";
            this.new_localization.Size = new System.Drawing.Size(150, 50);
            this.new_localization.TabIndex = 31;
            this.new_localization.Text = "Dodaj";
            this.new_localization.UseVisualStyleBackColor = false;
            this.new_localization.Click += new System.EventHandler(this.new_localization_Click);
            // 
            // Lokalizacje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(962, 453);
            this.Controls.Add(this.panel1);
            this.Name = "Lokalizacje";
            this.Text = "Lokalizacje";
            this.Load += new System.EventHandler(this.Lokalizacje_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.localization_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delete_localization;
        private System.Windows.Forms.Button edit_localization;
        private System.Windows.Forms.Panel panel2;
        private Controls.TextBox textBox1;
        private FontAwesome.Sharp.IconButton search;
        private System.Windows.Forms.DataGridView localization_dataGridView;
        private System.Windows.Forms.Button new_localization;
    }
}