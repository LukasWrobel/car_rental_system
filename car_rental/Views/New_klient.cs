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
    public partial class New_klient : Form
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
        private readonly Klienci _parent;
        public int check;
        public string id;
        //private Choose_client choose_client;
        private readonly Choose_client _choose_client;

        public New_klient(Klienci parent)
        {
            InitializeComponent();
            _parent = parent;
            //_choose_client = choose_Client;
        }

        public New_klient(Choose_client choose_client)
        {
            InitializeComponent();
            _choose_client = choose_client;
            //this.choose_client = choose_client;
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

        

        private void wstecz_Click(object sender, EventArgs e)
        {
            this.Close();
            //OpenChildForm(new Klienci());
        }

        private void kl_dodaj_Click(object sender, EventArgs e)
        {
            if(kl_dodaj.Text == "Dodaj")
            {
                addData();
            }
            if (kl_dodaj.Text == "Zapisz")
            {
                modData(id);
            }
            if (kl_dodaj.Text == "Dodaj klienta")
            {
                addDataClient();
            }


            //Sprawdz();
            /*if (check == 0)
            {
                MessageBox.Show("Baza została zaakualizowana");
                this.Close();
            } */
        }

        public void Clear()
        {
            klient_imie.Text = "";
            klient_nazw.Text = "";
            klientPESEL.Text = "";
            klient_nr_dow.Text = "";
            telefon.Text = "";
            mail.Text = "";
        }

        private void addData()
        {

            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "INSERT INTO `baza1`.`klienci` (`imie`, `nazw`, `PESEL`, `nr.dowodu`, `nr.tel`, `mail`) VALUES (@im, @naz, @PESEL, @nr_dow, @tel, @mail);";
            sqlCmd.Parameters.AddWithValue("@im", klient_imie.Text);
            sqlCmd.Parameters.AddWithValue("@naz", klient_nazw.Text);
            sqlCmd.Parameters.AddWithValue("@PESEL", klientPESEL.Text);
            sqlCmd.Parameters.AddWithValue("@nr_dow", klient_nr_dow.Text);
            sqlCmd.Parameters.AddWithValue("@tel", telefon.Text);
            sqlCmd.Parameters.AddWithValue("@mail", mail.Text);
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

        private void addDataClient()
        {

            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "INSERT INTO `baza1`.`klienci` (`imie`, `nazw`, `PESEL`, `nr.dowodu`, `nr.tel`, `mail`) VALUES (@im, @naz, @PESEL, @nr_dow, @tel, @mail);";
            sqlCmd.Parameters.AddWithValue("@im", klient_imie.Text);
            sqlCmd.Parameters.AddWithValue("@naz", klient_nazw.Text);
            sqlCmd.Parameters.AddWithValue("@PESEL", klientPESEL.Text);
            sqlCmd.Parameters.AddWithValue("@nr_dow", klient_nr_dow.Text);
            sqlCmd.Parameters.AddWithValue("@tel", telefon.Text);
            sqlCmd.Parameters.AddWithValue("@mail", mail.Text);
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
            _choose_client.upLoadData();
        }

        private void modData(string id)
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "UPDATE `baza1`.`klienci` SET `imie` = @im, `nazw` = @naz, `PESEL` = @PESEL, `nr.dowodu` = @nr_dow, `nr.tel` = @tel, `mail` = @mail WHERE `idklienci` = @index;";
            sqlCmd.Parameters.AddWithValue("@index", MySqlDbType.VarChar).Value = id;
            sqlCmd.Parameters.AddWithValue("@im", klient_imie.Text);
            sqlCmd.Parameters.AddWithValue("@naz", klient_nazw.Text);
            sqlCmd.Parameters.AddWithValue("@PESEL", klientPESEL.Text);
            sqlCmd.Parameters.AddWithValue("@nr_dow", klient_nr_dow.Text);
            sqlCmd.Parameters.AddWithValue("@tel", telefon.Text);
            sqlCmd.Parameters.AddWithValue("@mail", mail.Text);
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

        

        /* private void Sprawdz()
         {
             check = 0;
             long liczba = 0;
             bool isNumber = false;
             bool isNumber1 = false;
             isNumber = long.TryParse(klient_PESEL.Text, out liczba);
             isNumber1 = long.TryParse(klient_tel.Text, out liczba);
             if (klient_imie.Text.Length > 15 || string.IsNullOrEmpty(klient_imie.Text)|| !(System.Text.RegularExpressions.Regex.IsMatch(klient_imie.Text, "^[a-zA-Z ]*$")))
             {
                 MessageBox.Show("Zawartość pola imię nie może zawierać cyfr, być puste i dłuże niż 15 znaków");
                 check++;
             }
             if (klient_nazw.Text.Length > 30 || string.IsNullOrEmpty(klient_nazw.Text) || !(System.Text.RegularExpressions.Regex.IsMatch(klient_nazw.Text, "^[a-zA-Z ]*$")))
             {
                 MessageBox.Show("Zawartość pola nazwisko nie może zawierać cyfr, być puste i dłuże niż 30 znaków");
                 check++;
             }
             if (telefon.Text.Length > 15 || string.IsNullOrEmpty(telefon.Text) || !(System.Text.RegularExpressions.Regex.IsMatch(telefon.Text, "^[a-zA-Z ]*$")))
             {
                 MessageBox.Show("Zawartość pola miasto nie może zawierać cyfr, być puste i dłuże niż 15 znaków");
                 check++;
             }
             if (mail.Text.Length > 15 || string.IsNullOrEmpty(mail.Text) || !(System.Text.RegularExpressions.Regex.IsMatch(mail.Text, "^[a-zA-Z ]*$")))
             {
                 MessageBox.Show("Zawartość pola ulica nie może zawierać cyfr, być puste i dłuże niż 15 znaków");
                 check++;
             }
             if (klient_adr.Text.Length > 15 || string.IsNullOrEmpty(klient_adr.Text))
             {
                 MessageBox.Show("Zawartość pola adres nie może być puste i dłuże niż 15 znaków");
                 check++;
             }
             if (!(klient_kp.Text.Length ==6) || string.IsNullOrEmpty(klient_kp.Text))
             {
                 MessageBox.Show("Zawartość pola kod pocztowy nie może być puste i musi się składać z 6 znaków \n np: 11-111");
                 check++;
             }
             if (!(klient_PESEL.Text.Length == 11) || string.IsNullOrEmpty(klient_PESEL.Text)|| !isNumber)
             {
                 MessageBox.Show("Zawartość pola PESEL nie może być puste i musi się składać z 11 cyfr");
                 check++;
             }
             if (!(klient_tel.Text.Length == 9) || string.IsNullOrEmpty(klient_tel.Text)|| !isNumber1)
             {
                 MessageBox.Show("Zawartość pola telefon nie może być puste i musi się składać z 9 cyfr");
                 check++;
             }
         }*/
    }
}
