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
    public partial class Podsumowanie : Form
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
        private readonly Choose_client _client;
        public string autID, klientID, pracownikID;
        string id1, id2;
        string brak = "-";
        string rez = "rezerwacja";
        public Podsumowanie(Choose_client client)
        {
            InitializeComponent();
            _client = client;
        }

        private void addData()
        {

            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "INSERT INTO `baza1`.`rezerwacje/wypozyczenia` (`termin_rezerwacji`, `termin_odb`, `termin_odd`, `cena_wyp`, `status`, `pracownik_rez`, `lokalizacja_odb`, `lokalizacja_odd`, `klienci_idklienci`, `auta_idAuta`) " +
                "VALUES (@tr, @todb, @todd, @cenwyp, @status, @prez, @lokodb, @lokodd, @klient, @auto);";
            sqlCmd.Parameters.AddWithValue("@tr", DateTime.Now);
            sqlCmd.Parameters.AddWithValue("@todb", wyp_od.Text);
            //sqlCmd.Parameters.AddWithValue("@godb", brak);
            sqlCmd.Parameters.AddWithValue("@todd", wyp_do.Text);
            //sqlCmd.Parameters.AddWithValue("@godd", brak);
            sqlCmd.Parameters.AddWithValue("@cenwyp", wyp_cena.Text);
            sqlCmd.Parameters.AddWithValue("@status", rez);
            sqlCmd.Parameters.AddWithValue("@prez", pracownikID);
            //sqlCmd.Parameters.AddWithValue("@pwyp", brak);
            //sqlCmd.Parameters.AddWithValue("@pkonwyp", brak);
            sqlCmd.Parameters.AddWithValue("@lokodb", id1);
            sqlCmd.Parameters.AddWithValue("@lokodd", id2);
            sqlCmd.Parameters.AddWithValue("@auto", autID);
            //sqlCmd.Parameters.AddWithValue("@auto_lok", id1);
            sqlCmd.Parameters.AddWithValue("@klient", klientID);
            try
            {
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Rezerwacja przebiegła pomyślnie");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
        }

        private void Lokal1()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT idlokalizacja FROM baza1.lokalizacja WHERE adres= '" + wyp_modb.Text + "';";
            sqlRd = sqlCmd.ExecuteReader();
            while (sqlRd.Read())
            {
                id1 = sqlRd[0].ToString();
            }
            sqlRd.Close();
            sqlConn.Close();
        }
        private void Lokal2()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT idlokalizacja FROM baza1.lokalizacja WHERE adres= '" + wyp_modd.Text + "';";
            sqlRd = sqlCmd.ExecuteReader();
            while (sqlRd.Read())
            {
                id2 = sqlRd[0].ToString();
            }
            sqlRd.Close();
            sqlConn.Close();
        }

        private void Auto()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "UPDATE `baza1`.`auta` SET `dostęp` = 'nie' WHERE (`idAuta` = '"+autID+"') and (`lokalizacja_idlokalizacja` = '"+id1+"');";
            try
            {
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
        }

        private void new_rezerw_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Czy napewno chcesz dokonać rezerwacji?", "Potwierdź rezerwację", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            {
                Lokal1();
                Lokal2();
                Auto();
                addData();
            }
            if (dR == DialogResult.No)
            {

            }
            
        }

        private void Podsumowanie_Load(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
