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
    public partial class new_localization : Form
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
        private readonly Lokalizacje _parent;
        public string id;
        public new_localization(Lokalizacje parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void addData()
        {
            

            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "INSERT INTO `baza1`.`lokalizacja` (`adres`) VALUES (@adres);";
            sqlCmd.Parameters.AddWithValue("@adres", adres.Text);
            try
            {
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Dodano dane");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
            _parent.upLoadData();
            
        }

        private void modData(string id)
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "UPDATE `baza1`.`lokalizacja` SET `adres` = @adres WHERE `idlokalizacja` = @id;";
            sqlCmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;
            sqlCmd.Parameters.AddWithValue("@adres", adres.Text);
            try
            {
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Dane zmodyfikowano");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
            _parent.upLoadData();
        }

        public void Clear()
        {
            adres.Text = "";
        }

        private void wstecz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kl_dodaj_Click(object sender, EventArgs e)
        {
            if (kl_dodaj.Text == "Dodaj")
            {
                addData();
            }
            if (kl_dodaj.Text == "Zapisz")
            {
                modData(id);
            }
        }
    }
}
