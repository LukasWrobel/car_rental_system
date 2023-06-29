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
    public partial class Lokalizacje : Form
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

        string lok_index, lok_adres;
        private Form currentChildForm;
        public Lokalizacje()
        {
            InitializeComponent();
        }

        public void upLoadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            sqlQuery = "SELECT * FROM baza1.lokalizacja";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            localization_dataGridView.DataSource = sqlDt;
            sqlConn.Close();
        }

        private void Delete(string id)
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlQuery = "DELETE FROM baza1.lokalizacja WHERE idlokalizacja = @id";
            
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            try
            {
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Dane zostały usunięte");
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
            sqlQuery = "SELECT * FROM baza1.lokalizacja WHERE adres LIKE '%" + textBox1.Texts + "%'";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            localization_dataGridView.DataSource = sqlDt;
            sqlConn.Close();
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

        private void Lokalizacje_Load(object sender, EventArgs e)
        {
            upLoadData();
        }


        private void new_localization_Click(object sender, EventArgs e)
        {
            new_localization form;
            form = new new_localization(this);
            form.kl_dodaj.Text = "Dodaj";
            form.Clear();
            OpenChildForm(form);
        }

        private void delete_localization_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Czy napewno chcesz usunąć dane lokalizacji?", "Usuń lokalizację", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            {
                Delete(lok_index);
            }
            if (dR == DialogResult.No)
            {

            }
            
        }

        private void localization_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lok_index = localization_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                lok_adres = localization_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1__TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void edit_localization_Click(object sender, EventArgs e)
        {
            new_localization form;
            form = new new_localization(this);
            form.kl_dodaj.Text = "Zapisz";
            form.id = lok_index;
            form.adres.Text = lok_adres;
            OpenChildForm(form);
        }
    }
}
