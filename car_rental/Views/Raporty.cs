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
    public partial class Raporty : Form
    {
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        String sqlQuery, sqlQuery1;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        DataSet DS = new DataSet();
        MySqlDataReader sqlRd;
        String server = "localhost";
        String username = "root";
        String password = "P@ssw0rd";
        String database = "baza1";
        string data1, data2;
        public Raporty()
        {
            InitializeComponent();
        }

        private void new_raport_Click(object sender, EventArgs e)
        {
            if (ComboBox.Text == "Przychody")
            {
                label5.Visible = true;
                label5.Text = "Przychody:";
                label6.Visible = true;
                sqlQuery = "SELECT * FROM baza1.`rezerwacje/wypozyczenia` WHERE (status  = 'zakończone') and (godz_odd between '" + data1 + "' and '" + data2 + "');";
                sqlQuery1 = "SELECT SUM(cena_wyp) FROM baza1.`rezerwacje/wypozyczenia` WHERE(status = 'zakończone') and(godz_odd between '" + data1 + "' and '" + data2 + "');";
                resultGridView.Visible = false;
                label7.Visible = false;
                upLoadData();
            }
            if (ComboBox.Text == "Wypożyczenia")
            {
                label5.Visible = true;
                label5.Text = "Ilość wypożyczeń:";
                label6.Visible = true;
                sqlQuery = "SELECT * FROM baza1.`rezerwacje/wypozyczenia` WHERE (status  = 'zakończone') and (godz_odd between '" + data1 + "' and '" + data2 + "');";
                sqlQuery1 = "SELECT count(idrezerwacje) FROM baza1.`rezerwacje/wypozyczenia` WHERE(status = 'zakończone') and(godz_odd between '" + data1 + "' and '" + data2 + "');";
                resultGridView.Visible = false;
                label7.Visible = false;
                upLoadData();
            }
            if (ComboBox.Text == "Najczęściej wypożyczane pojazdy")
            {
                label5.Visible = false;
                label6.Visible = false;
                sqlQuery = "SELECT * FROM baza1.`rezerwacje/wypozyczenia` WHERE (status  = 'zakończone') and (godz_odd between '" + data1 + "' and '" + data2 + "');";
                sqlQuery1 = "SELECT rez.auta_idAuta as id_auta, count(rez.idrezerwacje) as ilosc_wypozyczen, a.marka, a.model, a.rok_prod, a.cena, a.klasa, a.nr_rej, a.nr_vin FROM baza1.`rezerwacje/wypozyczenia` AS rez JOIN baza1.`auta` AS a ON a.idAuta = rez.auta_idAuta WHERE (status = 'zakończone') and (godz_odd between '"+data1+"' and '"+data2+"') group by auta_idAuta; ";
                resultGridView.Visible = true;
                label7.Text = "Najczęściej wypożyczane pojazdy:";
                label7.Visible = true;
                upLoadData1();
            }
            if (ComboBox.Text == "Najczęściej wypożyczający klienci")
            {
                label5.Visible = false;
                label6.Visible = false;
                sqlQuery = "SELECT * FROM baza1.`rezerwacje/wypozyczenia` WHERE (status  = 'zakończone') and (godz_odd between '" + data1 + "' and '" + data2 + "');";
                sqlQuery1 = "SELECT rez.klienci_idklienci as id_klienta, count(rez.idrezerwacje) as ilosc_wypozyczen, k.imie, k.nazw, k.PESEL, k.`nr.dowodu`, k.`nr.tel`, k.mail FROM baza1.`rezerwacje/wypozyczenia` AS rez JOIN baza1.`klienci` AS k ON k.idklienci = rez.klienci_idklienci WHERE(status = 'zakończone') and(godz_odd between '"+data1+"' and '"+data2+"') group by klienci_idklienci; ";
                resultGridView.Visible = true;
                label7.Text = "Najczęściej wypożyczający klienci:";
                label7.Visible = true;
                upLoadData1();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            data1 = dateTimePicker1.Value.Date.ToString("yyyy.MM.dd");
            data1 += " 00:00:00";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            data2 = dateTimePicker2.Value.Date.ToString("yyyy.MM.dd");
            data2 += " 23:59:59";
        }

        private void Raporty_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
            data1 = dateTimePicker1.Value.Date.ToString("yyyy.MM.dd");
            data1 += " 00:00:00";
            dateTimePicker2.MaxDate = DateTime.Today;
            data2 = dateTimePicker2.Value.Date.ToString("yyyy.MM.dd");
            data2 += " 23:59:59";
        }

        private void upLoadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            //sqlQuery = "SELECT * FROM baza1.`rezerwacje/wypozyczenia` WHERE status  = 'zakończone'";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            raports_dataGridView.DataSource = sqlDt;
            sqlConn.Close();

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = sqlQuery1;
            sqlRd = sqlCmd.ExecuteReader();
            while (sqlRd.Read())
            {
                label6.Text = sqlRd[0].ToString();
            }
            sqlRd.Close();
            sqlConn.Close();
        }

        private void upLoadData1()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            raports_dataGridView.DataSource = sqlDt;
            sqlConn.Close();

            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery1, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            resultGridView.DataSource = sqlDt;
            sqlConn.Close();
        }
    }
}
