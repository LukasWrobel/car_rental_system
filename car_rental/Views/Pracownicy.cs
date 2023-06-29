using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_rental.Views
{
    public partial class Pracownicy : Form
    {
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        DataSet DS = new DataSet();
        MySqlDataReader sqlRd;
        String server = "localhost";
        String username = "root";
        String password = "P@ssw0rd";
        String database = "baza1";
        private Form currentChildForm;
        string lokal;
        string employee_index, employee_im, employee_nazw, employee_tel, employee_pesel, employee_rola, employee_log, employee_pass, employee_lok;
        public Pracownicy()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void upLoadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            
            sqlQuery = "SELECT * FROM baza1.pracownicy";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            employee_dataGridView.DataSource = sqlDt;
            sqlConn.Close();
        }

        private void Delete(string id)
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlQuery = "DELETE FROM baza1.pracownicy WHERE idpracownicy = @id";

            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            try
            {
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Dane zostały usunięte");

                foreach (DataGridViewRow item in this.employee_dataGridView.SelectedRows)
                {
                    employee_dataGridView.Rows.RemoveAt(item.Index);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();

            upLoadData();
        }

        private void Search()
        {
            sqlQuery = "SELECT * FROM baza1.pracownicy WHERE nazw LIKE '%" + textBox1.Texts + "%'";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            employee_dataGridView.DataSource = sqlDt;
            sqlConn.Close();
        }
        private void new_employee_Click(object sender, EventArgs e)
        {
            New_employee form;
            form = new New_employee(this);
            form.kl_dodaj.Text = "Dodaj";
            form.Clear();
            OpenChildForm(form);
        }

        private void Pracownicy_Load(object sender, EventArgs e)
        {
            upLoadData();
        }

        private void delete_employee_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Czy napewno chcesz usunąć dane pracownika?", "Usuń pracownika", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            {
                Delete(employee_index);
            }
            if (dR == DialogResult.No)
            {

            }
        }

        private void employee_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                employee_index = employee_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                employee_im = employee_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                employee_nazw = employee_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                employee_tel = employee_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                employee_pesel = employee_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                employee_rola = employee_dataGridView.SelectedRows[0].Cells[5].Value.ToString();
                employee_log = employee_dataGridView.SelectedRows[0].Cells[6].Value.ToString();
                employee_pass = employee_dataGridView.SelectedRows[0].Cells[7].Value.ToString();
                employee_lok = employee_dataGridView.SelectedRows[0].Cells[8].Value.ToString();
                Lok();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Lok()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT `adres` FROM baza1.lokalizacja WHERE `idlokalizacja` = '" + employee_lok + "'";
            sqlRd = sqlCmd.ExecuteReader();
            while (sqlRd.Read())
            {
                 lokal= sqlRd[0].ToString();
            }
            sqlRd.Close();
            sqlConn.Close();
        }

        private void textBox1__TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void edit_employee_Click(object sender, EventArgs e)
        {
            New_employee form;
            form = new New_employee(this);
            form.kl_dodaj.Text = "Zapisz";
            OpenChildForm(form);
            form.id = employee_index;
            form.pracownik_imie.Text = employee_im;
            form.pracownik_nazw.Text = employee_nazw;
            form.pracownik_tel.Text = employee_tel;
            form.pracownik_PESEL.Text = employee_pesel;
            form.rola_cbox.Text = employee_rola;
            form.pracownik_login.Text = employee_log;
            form.pracownik_pass.Text = employee_pass;
            form.pracownik_pass_powtorz.Text = employee_pass;
            form.comboBox1.Text = lokal;
        }
    }
}
