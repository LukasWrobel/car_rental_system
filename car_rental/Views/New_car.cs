using car_rental.Views;
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
    public partial class New_car : Form
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
        private readonly Samochody _parent;
        public int check;
        public string id, index;
        public New_car(Samochody parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fillcombobox()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "SELECT idlokalizacja, adres FROM baza1.lokalizacja;";

            sqlRd = sqlCmd.ExecuteReader();
            while (sqlRd.Read())
            {
                ComboBoxLokalizacja.Items.Add(sqlRd["adres"].ToString());
                ComboBoxLokalizacja.DisplayMember = sqlRd["adres"].ToString();
                ComboBoxLokalizacja.ValueMember = sqlRd["idlokalizacja"].ToString();
            }
            sqlRd.Close();
            sqlConn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Dodaj")
            {
                addData();
            }
            if (button1.Text == "Zapisz")
            {
                modData(index);
            }
            //Sprawdz();
            //if(check==0)
            //{
            //  MessageBox.Show("Baza została zaakualizowana");
            //this.Close();
            //}

        }

        private void addData()
        {

            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "INSERT INTO `baza1`.`auta` (`marka`, `model`, `rok_prod`, `ilość_drzwi`, `ilość_miejsc`, `klimatyzacja`, `skrzynia`, `dostęp`, `cena`, `klasa`, `nr_rej`, `nr_VIN`, `lokalizacja_idlokalizacja`) " +
                "VALUES (@mar, @mod, @rp, @id, @im, @klima, @skrz, @dos, @cena, @klasa, @nrej, @vin, @lok);";
            sqlCmd.Parameters.AddWithValue("@mar", textBoxMarka.Text);
            sqlCmd.Parameters.AddWithValue("@mod", textBoxModel.Text);
            sqlCmd.Parameters.AddWithValue("@rp", rok_prdukcji_datapicker.Text);
            sqlCmd.Parameters.AddWithValue("@id", textBoxDrzwi.Text);
            sqlCmd.Parameters.AddWithValue("@im", textBoxMiejsca.Text);
            sqlCmd.Parameters.AddWithValue("@klima", comboBoxKlima.Text);
            sqlCmd.Parameters.AddWithValue("@skrz", comboBoxSkrzynia.Text);
            sqlCmd.Parameters.AddWithValue("@dos", comboBoxDostep.Text);
            sqlCmd.Parameters.AddWithValue("@cena", textBoxCenaDoba.Text);
            sqlCmd.Parameters.AddWithValue("@klasa", comboBoxKlasa.Text);
            sqlCmd.Parameters.AddWithValue("@nrej", textBoxNrRej.Text);
            sqlCmd.Parameters.AddWithValue("@vin", textBoxNrVin.Text);
            sqlCmd.Parameters.AddWithValue("@lok", id);
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

        private void modData(string index)
        {
            //Lokal();
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "UPDATE `baza1`.`auta` SET `marka` = @mar, `model` = @mod, `rok_prod` = @rp, `ilość_drzwi` = @id, `ilość_miejsc` = @im," +
                " `klimatyzacja` = @klima, `skrzynia` = @skrz, `dostęp` = @dos, `cena` = @cena, `klasa` = @klasa, `nr_rej` = @nrej, `nr_VIN` = @vin, `lokalizacja_idlokalizacja` = @lok " +
                "WHERE `idAuta` = @index;";
            sqlCmd.Parameters.AddWithValue("@index", MySqlDbType.VarChar).Value = index;
            sqlCmd.Parameters.AddWithValue("@mar", textBoxMarka.Text);
            sqlCmd.Parameters.AddWithValue("@mod", textBoxModel.Text);
            sqlCmd.Parameters.AddWithValue("@rp", rok_prdukcji_datapicker.Text);
            sqlCmd.Parameters.AddWithValue("@id", textBoxDrzwi.Text);
            sqlCmd.Parameters.AddWithValue("@im", textBoxMiejsca.Text);
            sqlCmd.Parameters.AddWithValue("@klima", comboBoxKlima.Text);
            sqlCmd.Parameters.AddWithValue("@skrz", comboBoxSkrzynia.Text);
            sqlCmd.Parameters.AddWithValue("@dos", comboBoxDostep.Text);
            sqlCmd.Parameters.AddWithValue("@cena", textBoxCenaDoba.Text);
            sqlCmd.Parameters.AddWithValue("@klasa", comboBoxKlasa.Text);
            sqlCmd.Parameters.AddWithValue("@nrej", textBoxNrRej.Text);
            sqlCmd.Parameters.AddWithValue("@vin", textBoxNrVin.Text);
            sqlCmd.Parameters.AddWithValue("@lok", id);
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

        public void Clear()
        {
            textBoxMarka.Text = "";
            textBoxModel.Text = "";
            rok_prdukcji_datapicker.Text = "01.01.2022";
            textBoxDrzwi.Text = "";
            textBoxMiejsca.Text = "";
            comboBoxKlima.Text = "";
            comboBoxSkrzynia.Text = "";
            comboBoxDostep.Text = "";
            textBoxCenaDoba.Text = "";
            comboBoxKlasa.Text = "";
            textBoxNrRej.Text = "";
            textBoxNrVin.Text = "";
            ComboBoxLokalizacja.Text = "";
        }

        private void Lokal()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT idlokalizacja FROM baza1.lokalizacja WHERE adres= '" + ComboBoxLokalizacja.SelectedItem + "';";
            sqlRd = sqlCmd.ExecuteReader();
            while (sqlRd.Read())
            {
                id = sqlRd[0].ToString();
            }
            sqlRd.Close();
            sqlConn.Close();
        }

        private void New_car_Load(object sender, EventArgs e)
        {
            Fillcombobox();
        }

        

        private void ComboBoxLokalizacja_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lokal();
        }

        /* private void Sprawdz()
         {
             check = 0;
             int liczba = 0;
             bool isNumber = false;
             bool isNumber1 = false;
             isNumber = int.TryParse(textBoxKlima.Text, out liczba);
             isNumber1 = int.TryParse(textBoxCenaDoba.Text, out liczba);
             if (textBoxMarka.Text.Length > 15|| string.IsNullOrEmpty(textBoxMarka.Text) || !(System.Text.RegularExpressions.Regex.IsMatch(textBoxMarka.Text, "^[a-zA-Z ]*$")))
             {
                 MessageBox.Show("Zawartość pola marka nie może zawierać cyfr, być puste i dłuże niż 15 znaków");
                 check++;
             }
             if(textBoxModel.Text.Length > 15 || string.IsNullOrEmpty(textBoxModel.Text))
             {
                 MessageBox.Show("Zawartość pola model nie może być puste i dłuże niż 15 znaków");
                 check++;
             }
             if (textBoxDrzwi.Text.Length > 30 || string.IsNullOrEmpty(textBoxDrzwi.Text) || !(System.Text.RegularExpressions.Regex.IsMatch(textBoxDrzwi.Text, "^[a-zA-Z ]*$")))
             {
                 MessageBox.Show("Zawartość pola kolor nie może zawierać cyfr, być puste i dłuże niż 30 znaków");
                 check++;
             }
             if (!(textBoxMiejsca.Text.Length == 3) || string.IsNullOrEmpty(textBoxMiejsca.Text))
             {
                 MessageBox.Show("Zawartość pola pojemność silnika nie może być puste i musi zawierać 3 znaki");
                 check++;
             }
             if (textBoxKlima.Text.Length > 1|| string.IsNullOrEmpty(textBoxKlima.Text) || !isNumber)
             {
                 MessageBox.Show("Zawartość pola ilość miejsc musi być liczbą, nie może być puste i dłuże niż 1 znak");
                 check++;
             }
             if (!(textBoxNrRej.Text.Length == 7||textBoxNrRej.Text.Length == 8) || string.IsNullOrEmpty(textBoxNrRej.Text))
             {
                 MessageBox.Show("Zawartość pola numer rejstracyjny nie może być puste i musi zawierać 7 lub 8 znaków");
                 check++;
             }
             if (!(textBoxNrVin.Text.Length == 17) || string.IsNullOrEmpty(textBoxNrVin.Text))
             {
                 MessageBox.Show("Zawartość pola numer VIN nie może być puste i musi zawierać 17 znaków");
                 check++;
             }
             if (textBoxCenaDoba.Text.Length > 5 || string.IsNullOrEmpty(textBoxCenaDoba.Text) || !isNumber1)
             {
                 MessageBox.Show("Zawartość pola cena za dobe musi być liczbą nie może być puste i dłuże niż 5 znaków");
                 check++;
             }
             if (!(comboBoxDostep.Text =="tak"|| comboBoxDostep.Text == "nie"))
             {
                 MessageBox.Show("Zawartość pola dostępność musi zawierać jedną z wartości dostępnych w menu");
                 check++;
             }
             if (!(comboBoxSkrzynia.Text == "manualna" || comboBoxSkrzynia.Text == "automatyczna"))
             {
                 MessageBox.Show("Zawartość pola skrzynia musi zawierać jedną z wartości dostępnych w menu");
                 check++;
             }
             if (!(comboBoxKlasa.Text == "coupe" || comboBoxKlasa.Text == "hatchback" || comboBoxKlasa.Text == "kabriolet"
                 || comboBoxKlasa.Text == "kombi" || comboBoxKlasa.Text == "limuzyna" || comboBoxKlasa.Text == "sedan" || comboBoxKlasa.Text == "SUV"))
             {
                 MessageBox.Show("Zawartość pola klasa musi zawierać jedną z wartości dostępnych w menu");
                 check++;
             }
         } 
        */
    }
}
