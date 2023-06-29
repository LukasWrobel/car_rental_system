
namespace car_rental.Views
{
    partial class Pracownicy
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
            this.new_employee = new System.Windows.Forms.Button();
            this.employee_dataGridView = new System.Windows.Forms.DataGridView();
            this.search = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new car_rental.Controls.TextBox();
            this.edit_employee = new System.Windows.Forms.Button();
            this.delete_employee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // new_employee
            // 
            this.new_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.new_employee.FlatAppearance.BorderSize = 0;
            this.new_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.new_employee.ForeColor = System.Drawing.Color.White;
            this.new_employee.Location = new System.Drawing.Point(12, 19);
            this.new_employee.MinimumSize = new System.Drawing.Size(150, 50);
            this.new_employee.Name = "new_employee";
            this.new_employee.Size = new System.Drawing.Size(150, 50);
            this.new_employee.TabIndex = 19;
            this.new_employee.Text = "Dodaj";
            this.new_employee.UseVisualStyleBackColor = false;
            this.new_employee.Click += new System.EventHandler(this.new_employee_Click);
            // 
            // employee_dataGridView
            // 
            this.employee_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employee_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employee_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.employee_dataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.employee_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employee_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.employee_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_dataGridView.GridColor = System.Drawing.Color.DimGray;
            this.employee_dataGridView.Location = new System.Drawing.Point(12, 85);
            this.employee_dataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.employee_dataGridView.MinimumSize = new System.Drawing.Size(938, 349);
            this.employee_dataGridView.Name = "employee_dataGridView";
            this.employee_dataGridView.RowHeadersWidth = 51;
            this.employee_dataGridView.RowTemplate.Height = 24;
            this.employee_dataGridView.Size = new System.Drawing.Size(938, 349);
            this.employee_dataGridView.TabIndex = 20;
            this.employee_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employee_dataGridView_CellClick);
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
            this.search.TabIndex = 21;
            this.search.UseVisualStyleBackColor = false;
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
            this.panel2.TabIndex = 22;
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
            // edit_employee
            // 
            this.edit_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.edit_employee.FlatAppearance.BorderSize = 0;
            this.edit_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edit_employee.ForeColor = System.Drawing.Color.White;
            this.edit_employee.Location = new System.Drawing.Point(179, 19);
            this.edit_employee.MinimumSize = new System.Drawing.Size(150, 50);
            this.edit_employee.Name = "edit_employee";
            this.edit_employee.Size = new System.Drawing.Size(150, 50);
            this.edit_employee.TabIndex = 23;
            this.edit_employee.Text = "Edytuj";
            this.edit_employee.UseVisualStyleBackColor = false;
            this.edit_employee.Click += new System.EventHandler(this.edit_employee_Click);
            // 
            // delete_employee
            // 
            this.delete_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.delete_employee.FlatAppearance.BorderSize = 0;
            this.delete_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete_employee.ForeColor = System.Drawing.Color.White;
            this.delete_employee.Location = new System.Drawing.Point(345, 19);
            this.delete_employee.MinimumSize = new System.Drawing.Size(150, 50);
            this.delete_employee.Name = "delete_employee";
            this.delete_employee.Size = new System.Drawing.Size(150, 50);
            this.delete_employee.TabIndex = 24;
            this.delete_employee.Text = "Usuń";
            this.delete_employee.UseVisualStyleBackColor = false;
            this.delete_employee.Click += new System.EventHandler(this.delete_employee_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.delete_employee);
            this.panel1.Controls.Add(this.edit_employee);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.employee_dataGridView);
            this.panel1.Controls.Add(this.new_employee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 453);
            this.panel1.TabIndex = 0;
            // 
            // Pracownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(962, 453);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(980, 500);
            this.Name = "Pracownicy";
            this.Text = "Pracownicy";
            this.Load += new System.EventHandler(this.Pracownicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button new_employee;
        private System.Windows.Forms.DataGridView employee_dataGridView;
        private FontAwesome.Sharp.IconButton search;
        private System.Windows.Forms.Panel panel2;
        private Controls.TextBox textBox1;
        private System.Windows.Forms.Button edit_employee;
        private System.Windows.Forms.Button delete_employee;
        public System.Windows.Forms.Panel panel1;
    }
}