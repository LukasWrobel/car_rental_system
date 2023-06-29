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

namespace car_rental
{

    public partial class Klienci : Form
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
        private readonly Menu _parent;
        public string userROLA;
        public string client_index, client_imie, client_nazw, client_PESEL, client_nrDow, client_tel, client_mail;
        
        public Klienci(Menu parent)
        {
            InitializeComponent();
            _parent = parent;
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



        private void new_client_Click(object sender, EventArgs e)
        {
            New_klient form;
            form = new New_klient(this);
            form.kl_dodaj.Text = "Dodaj";
            form.Clear();
            OpenChildForm(form);
        }

        public void upLoadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            sqlQuery = "SELECT * FROM baza1.klienci";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            clients_dataGridView.DataSource = sqlDt;
            sqlConn.Close();
        }

        private void Delete(string id)
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlQuery = "DELETE FROM baza1.klienci WHERE idklienci = @id";

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
            sqlQuery = "SELECT * FROM baza1.klienci WHERE nazw LIKE '%" + textBox1.Texts + "%'";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            clients_dataGridView.DataSource = sqlDt;
            sqlConn.Close();
        }

        private void textBox1__TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Klienci_Load(object sender, EventArgs e)
        {
            upLoadData();
            if (userROLA == "użytkownik")
            {
                delete_client.Visible = false;
                delete_client.Enabled = false;
            }

        }

        private void delete_client_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Czy napewno chcesz usunąć dane klienta?", "Usuń klienta", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            {
                Delete(client_index);
            }
            if (dR == DialogResult.No)
            {

            }
            
        }

        private void clients_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            try
            {
                client_index = clients_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                client_imie = clients_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                client_nazw = clients_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                client_PESEL = clients_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                client_nrDow = clients_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                client_tel = clients_dataGridView.SelectedRows[0].Cells[5].Value.ToString();
                client_mail = clients_dataGridView.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void edit_client_Click(object sender, EventArgs e)
        {
            New_klient form;
            form = new New_klient(this);
            form.kl_dodaj.Text = "Zapisz";
            OpenChildForm(form);
            form.id = client_index;
            form.klient_imie.Text = client_imie;
            form.klient_nazw.Text = client_nazw;
            form.klientPESEL.Text = client_PESEL;
            form.klient_nr_dow.Text = client_nrDow;
            form.telefon.Text = client_tel;
            form.mail.Text = client_mail;
        }
    }
}
