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
    public partial class Start : Form
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
        string id, imie_nazw, imie, nazw, rola, haslo;
        public Start()
        {
            InitializeComponent();
        }

        private void Login()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            sqlQuery = "SELECT * FROM baza1.pracownicy WHERE login = '" + login.Texts + "'";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            dataGridView1.DataSource = sqlDt;
            sqlConn.Close();
            id = dataGridView1.Rows[0].Cells[0].Value.ToString();
            imie = dataGridView1.Rows[0].Cells[1].Value.ToString();
            nazw = dataGridView1.Rows[0].Cells[2].Value.ToString();
            rola = dataGridView1.Rows[0].Cells[5].Value.ToString();
            haslo = dataGridView1.Rows[0].Cells[7].Value.ToString();
            imie_nazw = imie + " " + nazw;
            if (haslo == pass.Texts)
            {
                Menu form;
                form = new Menu(this);
                form.label5.Text = imie_nazw;
                form.pracID = id;
                form.userRole = rola;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Spróbuj ponownie.\nBłędny login lub hasło.");
                pass.Texts = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(login.Texts=="" && pass.Texts == "")
            {
                MessageBox.Show("Spróbuj ponownie.\nZawartość pola login i hasło nue może być puste.");
            }
            else
            {
                Login();
            }
        }
    }
}
