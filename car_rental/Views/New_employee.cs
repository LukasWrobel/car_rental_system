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
    public partial class New_employee : Form
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
        private readonly Pracownicy _parent;
        public int check;
        public string id, lok;
        public New_employee(Pracownicy parent)
        {
            InitializeComponent();
            _parent = parent;
        }


        private void wstecz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kl_dodaj_Click(object sender, EventArgs e)
        {
            //Sprawdz();
            /*if (check == 0)
            {
                addData();
            }*/
            if (kl_dodaj.Text == "Dodaj")
            {
                addData();
            }
            if (kl_dodaj.Text == "Zapisz")
            {
                modData(id);
            }

        }

        public void Clear()
        {
            pracownik_imie.Text = "";
            pracownik_nazw.Text = "";
            pracownik_pass.Text = "";
            pracownik_login.Text = "";
            pracownik_pass_powtorz.Text = "";
            pracownik_tel.Text = "";
            pracownik_PESEL.Text = "";
            rola_cbox.Text = "";
            comboBox1.Text = "";
        }

        private void addData()
        {

            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "INSERT INTO `baza1`.`pracownicy` (`imie`, `nazw`, `nr.tel`, `PESEL`, `rola`, `login`, `haslo`, `lokalizacja_idlokalizacja`) " +
                "VALUES (@im, @naz, @tel, @pesel, @rola, @login, @pass, @lok);";
            sqlCmd.Parameters.AddWithValue("@im", pracownik_imie.Text);
            sqlCmd.Parameters.AddWithValue("@naz", pracownik_nazw.Text);
            sqlCmd.Parameters.AddWithValue("@tel", pracownik_tel.Text);
            sqlCmd.Parameters.AddWithValue("@pesel", pracownik_PESEL.Text);
            sqlCmd.Parameters.AddWithValue("@rola", rola_cbox.SelectedItem.ToString());
            sqlCmd.Parameters.AddWithValue("@login", pracownik_login.Text);
            sqlCmd.Parameters.AddWithValue("@pass", pracownik_pass.Text);
            sqlCmd.Parameters.AddWithValue("@lok", lok);
            // sqlRd = sqlCmd.ExecuteReader();
            try
            {
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Dodano dane");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //sqlDt.Load(sqlRd);
            //sqlRd.Close();
            sqlConn.Close();
            _parent.upLoadData();

        }

        private void modData(string id)
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "UPDATE `baza1`.`pracownicy` SET `imie` = @im, `nazw` = @naz, `nr.tel` = @tel, `PESEL` = @pesel, `rola` = @rola, `login` = @log, `haslo` = @pass, `lokalizacja_idlokalizacja` = @lok  WHERE `idpracownicy` = @id;";
            sqlCmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;
            sqlCmd.Parameters.AddWithValue("@im", pracownik_imie.Text);
            sqlCmd.Parameters.AddWithValue("@naz", pracownik_nazw.Text);
            sqlCmd.Parameters.AddWithValue("@tel", pracownik_tel.Text);
            sqlCmd.Parameters.AddWithValue("@pesel", pracownik_PESEL.Text);
            sqlCmd.Parameters.AddWithValue("@rola", rola_cbox.Text);
            sqlCmd.Parameters.AddWithValue("@log", pracownik_login.Text);
            sqlCmd.Parameters.AddWithValue("@pass", pracownik_pass.Text);
            sqlCmd.Parameters.AddWithValue("@lok", lok);
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
            Clear();
        }

        private void Lokal()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT idlokalizacja FROM baza1.lokalizacja WHERE adres= '" + comboBox1.SelectedItem + "';";
            sqlRd = sqlCmd.ExecuteReader();
            while (sqlRd.Read())
            {
                lok = sqlRd[0].ToString();
            }
            sqlRd.Close();
            sqlConn.Close();
        }

        private void Sprawdz()
        {
            
            check = 0;
            long liczba = 0;
            bool isNumber = false;
            bool isNumber1 = false;
            isNumber = long.TryParse(pracownik_PESEL.Text, out liczba);
            isNumber1 = long.TryParse(pracownik_tel.Text, out liczba);
            if (pracownik_imie.Text.Length > 15 || string.IsNullOrEmpty(pracownik_imie.Text) || !(System.Text.RegularExpressions.Regex.IsMatch(pracownik_imie.Text, "^[a-zA-Z ]*$")))
            {
                MessageBox.Show("Zawartość pola imię nie może zawierać cyfr, być puste i dłuże niż 15 znaków");
                check++;
            }
            if (pracownik_nazw.Text.Length > 30 || string.IsNullOrEmpty(pracownik_nazw.Text) || !(System.Text.RegularExpressions.Regex.IsMatch(pracownik_nazw.Text, "^[a-zA-Z ]*$")))
            {
                MessageBox.Show("Zawartość pola nazwisko nie może zawierać cyfr, być puste i dłuże niż 30 znaków");
                check++;
            }
            if (pracownik_login.Text.Length > 15 || string.IsNullOrEmpty(pracownik_login.Text))
            {
                MessageBox.Show("Zawartość pola login nie może być puste i dłuże niż 15 znaków");
                check++;
            }
            if (pracownik_pass.Text.Length > 15 || string.IsNullOrEmpty(pracownik_pass.Text))
            {
                MessageBox.Show("Zawartość pola hasło nie może być puste i dłuże niż 15 znaków");
                check++;
            }
            if (pracownik_pass_powtorz.Text.Length > 15 || string.IsNullOrEmpty(pracownik_pass_powtorz.Text))
            {
                MessageBox.Show("Zawartość pola powtórz hasło nie może być puste i dłuże niż 15 znaków");
                check++;
            }
            if (!(pracownik_pass.Text == pracownik_pass_powtorz.Text))
            {
                MessageBox.Show("Hasła nie są identyczne");
                check++;
            }
            if (!(pracownik_tel.Text.Length == 9) || string.IsNullOrEmpty(pracownik_tel.Text) || !isNumber1)
            {
                MessageBox.Show("Zawartość pola telefon nie może być puste i musi się składać z 9 cyfr");
                check++;
            }
            if (!(pracownik_PESEL.Text.Length == 11) || string.IsNullOrEmpty(pracownik_PESEL.Text) || !isNumber)
            {
                MessageBox.Show("Zawartość pola PESEL nie może być puste i musi się składać z 11 cyfr");
                check++;
            }
            if (!(rola_cbox.Text == "administrator" || rola_cbox.Text == "użytkownik"))
            {
                MessageBox.Show("Zawartość pola rola musi zawierać jedną z wartości dostępnych w menu");
                check++;
            }
        }

        private void New_employee_Load(object sender, EventArgs e)
        {
            Fillcombobox();
        }

        void Fillcombobox()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT idlokalizacja, adres FROM baza1.lokalizacja;";
            sqlRd = sqlCmd.ExecuteReader();
            while (sqlRd.Read())
            {
                comboBox1.Items.Add(sqlRd["adres"].ToString());
                comboBox1.DisplayMember = (sqlRd["adres"].ToString());
                comboBox1.ValueMember = (sqlRd["idlokalizacja"].ToString());
            }
            sqlRd.Close();
            sqlConn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lokal();
        }

    }
}
