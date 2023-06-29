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
    public partial class Edit_Rez : Form
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
        string data1, data2, time1, time2, lok1, lok2, lok1idStart, lok2id, dni;
        private Form currentChildForm;
        public DateTime dateTime1, dateTime2;
        public string pracownikID, idRent, idKlient, idAuto, idAutZm,idAutZmLok, imie, nazw, pesel, lok1id;
        int iledni, cena;
        private readonly Wypozyczenia _wyp;
        private readonly Rezerwacje _rez;
        private readonly Choose_car _panel;

        public Edit_Rez(Wypozyczenia wyp)
        {
            InitializeComponent();
            _wyp = wyp;
        }

        public Edit_Rez(Rezerwacje rez)
        {
            InitializeComponent();
            _rez = rez;
        }

        public Edit_Rez(Choose_car panel)
        {
            InitializeComponent();
            _panel = panel;
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

        private void button2_Click(object sender, EventArgs e)
        {
            //auto
            Choose_car form;
            form = new Choose_car(this);
            form.lokID = lok1id;
            form.idKl = idKlient;
            form.idAut = idAuto;
            form.idAutZm = idAutZm;
            form.idAutZmLok = idAutZmLok;
            form.idR = idRent;
            form.datetime1 = dateTime1;
            form.datetime2 = dateTime2;
            form.dateTimePicker1.Value = dateTimePicker1.Value;
            form.dateTimePicker2.Value = dateTimePicker2.Value;
            form.imie = kl_imie.Text;
            form.nazw = kl_nazw.Text;
            form.pesel = kl_pesel.Text;
            form.mail = kl_mail.Text;
            form.dow = kl_dow.Text;
            form.tel = kl_tel.Text;
            form.lokal1 = ComboBoxLokalizacja.Text;
            form.lokal2 = Lokalizacja1.Text;
            form.button1.Text = "Zmień auto";
            form.button3.Visible = true;
            form.button3.Enabled = true;
            OpenChildForm(form);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //wstecz
            this.Close();
        }

        private void aut_cena_TextChanged(object sender, EventArgs e)
        {
            //cena = Int32.Parse(dataGridView1.Rows[0].Cells[9].Value.ToString());
            //cena = Int32.Parse(aut_cena.Text);
            //Oblicz();
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            data1 = dateTimePicker1.Value.Date.ToString("dd.MM.yyyy");
            dateTime1 = dateTimePicker1.Value.Date;
            Oblicz();
            wyp_cena.Text = (iledni * cena).ToString();
        }

        private void new_rezerw_Click(object sender, EventArgs e)
        {
            //zapisz
            if(tytul.Text == "Edytor rezerwacji:")
            {
                if (lok1idStart == lok1id)
                {
                    Auto();
                    ModRez();
                    Rezerwacje form;
                    form = new Rezerwacje(this);
                    form.upLoadData();
                    form.idprac = pracownikID;
                    OpenChildForm(form);
                }
                else
                {
                    MessageBox.Show("Jeśli zmieniłeś lokalizację odbioru pojazdu musisz zmienić auto.");
                }
            }
            if (tytul.Text == "Edytor wypożyczenia:")
            {
                ModWyp();
                Wypozyczenia form;
                form = new Wypozyczenia(this);
                form.upLoadData();
                form.IDpracownika = pracownikID;
                OpenChildForm(form);
            }
        }

        private void Auto()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "UPDATE `baza1`.`auta` SET `dostęp` = 'nie', `lokalizacja_idlokalizacja` = '" + lok1id + "' WHERE(`idAuta` = '" + idAuto + "') and(`lokalizacja_idlokalizacja` = '" + lok1id + "');";
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

        private void ModRez()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            //sqlCmd.CommandText = "UPDATE `baza1`.`rezerwacje/wypozyczenia` SET `termin_odb` = '"+data1+ "', `termin_odd` = '" + data2 + "', `cena_wyp` = '"+wyp_cena.Text.ToString()+"', `lokalizacja_odb` = '"+lok1id+ "', `lokalizacja_odd` = '" + lok2id + "', `auta_idAuta` = '"+idAuto+"' WHERE (`idrezerwacje` = '" + idRent + "') and (`klienci_idklienci` = '" + idKlient + "') and (`auta_idAuta` = '" + idAutZm + "');";
            sqlCmd.CommandText = "UPDATE `baza1`.`rezerwacje/wypozyczenia` SET `termin_odb` = '" + data1 + "', `termin_odd` = '" + data2 + "', `cena_wyp` = " + wyp_cena.Text.ToString() + " , `lokalizacja_odb` = '" + lok1id + "', `lokalizacja_odd` = '"+lok2id+"', `auta_idAuta` = '"+idAuto+"' WHERE (`idrezerwacje` = '"+idRent+"') and (`klienci_idklienci` = '"+idKlient+"') and (`auta_idAuta` = '"+idAutZm+"');";
            //UPDATE `baza1`.`rezerwacje / wypozyczenia` SET `termin_odb` = '18.02.2023', `termin_odd` = '28.02.2023', `cena_wyp` = '5500', `lokalizacja_odb` = '3', `lokalizacja_odd` = '2', `auta_idAuta` = '5' WHERE(`idrezerwacje` = '5') and(`klienci_idklienci` = '2') and(`auta_idAuta` = '3');
            try
            {
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
            //_rez.upLoadData();
            
        }

        private void ModWyp()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "UPDATE `baza1`.`rezerwacje/wypozyczenia` SET `termin_odd` = '" + data2 + "', `cena_wyp` = '" + wyp_cena.Text.ToString() + "', `lokalizacja_odd` = '" + lok2id + "' WHERE(`idrezerwacje` = '" + idRent + "') and(`klienci_idklienci` = '" + idKlient + "') and(`auta_idAuta` = '" + idAuto + "');";
            try
            {
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
            //_wyp.upLoadData();
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

                Lokalizacja1.Items.Add(sqlRd["adres"].ToString());
                Lokalizacja1.DisplayMember = sqlRd["adres"].ToString();
                Lokalizacja1.ValueMember = sqlRd["idlokalizacja"].ToString();
            }
            sqlRd.Close();
            sqlConn.Close();
        }

        private void Lokal1()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT idlokalizacja FROM baza1.lokalizacja WHERE adres= '" + ComboBoxLokalizacja.SelectedItem + "';";
            sqlRd = sqlCmd.ExecuteReader();
            while (sqlRd.Read())
            {
                lok1id = sqlRd[0].ToString();
            }
            sqlRd.Close();
            sqlConn.Close();
        }

        private void Lokal2()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT idlokalizacja FROM baza1.lokalizacja WHERE adres= '" + Lokalizacja1.SelectedItem + "';";
            sqlRd = sqlCmd.ExecuteReader();
            while (sqlRd.Read())
            {
                lok2id = sqlRd[0].ToString();
            }
            sqlRd.Close();
            sqlConn.Close();
        }

        private void Lokal1Start()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT idlokalizacja FROM baza1.lokalizacja WHERE adres= '" + ComboBoxLokalizacja.Text + "';";
            sqlRd = sqlCmd.ExecuteReader();
            while (sqlRd.Read())
            {
                lok1id = sqlRd[0].ToString();
                lok1idStart = sqlRd[0].ToString();
            }
            sqlRd.Close();
            sqlConn.Close();
        }

        private void Lokal2Start()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT idlokalizacja FROM baza1.lokalizacja WHERE adres= '" + Lokalizacja1.Text + "';";
            sqlRd = sqlCmd.ExecuteReader();
            while (sqlRd.Read())
            {
                lok2id = sqlRd[0].ToString();
            }
            sqlRd.Close();
            sqlConn.Close();
        }

        public void Oblicz()
        {
            dni = ((dateTime2 - dateTime1).TotalDays).ToString();
            iledni = int.Parse(dni);
            //wyp_cena.Text = (iledni * cena).ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            data2 = dateTimePicker2.Value.Date.ToString("dd.MM.yyyy");
            dateTime2 = dateTimePicker2.Value.Date;
            //iledni = Int32.Parse(dni);
            Oblicz();
            wyp_cena.Text = (iledni * cena).ToString();

        }

        private void ComboBoxLokalizacja_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lokal1();
            lok1 = ComboBoxLokalizacja.Text;
        }

        private void Lokalizacja1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lokal2();
            lok2 = Lokalizacja1.Text;
        }

        public void upLoadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;
            sqlQuery = "SELECT * FROM baza1.auta WHERE idAuta = '" + idAuto + "';";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            dataGridView1.DataSource = sqlDt;
            sqlConn.Close();
            aut_mar.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            aut_mod.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            aut_rok.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            aut_drzwi.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            aut_miej.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
            aut_klima.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
            aut_skrz.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
            aut_cena.Text = dataGridView1.Rows[0].Cells[9].Value.ToString();
            cena = int.Parse(dataGridView1.Rows[0].Cells[9].Value.ToString());
            aut_klasa.Text = dataGridView1.Rows[0].Cells[10].Value.ToString();
        }

        private void Edit_Rez_Load(object sender, EventArgs e)
        {
            Fillcombobox();
            Lokal1Start();
            Lokal2Start();
            upLoadData();
            //cena = Int32.Parse(aut_cena.Text);
            //dateTimePicker2.MinDate = DateTime.Today;
            data1 = dateTimePicker1.Value.Date.ToString("dd.MM.yyyy");
            dateTime1 = dateTimePicker1.Value;
            //dateTimePicker2.MinDate = DateTime.Today.AddDays(1);
            data2 = dateTimePicker2.Value.Date.ToString("dd.MM.yyyy");
            dateTime2 = dateTimePicker2.Value;
            //iledni = Int32.Parse(dni);
            Oblicz();
            wyp_cena.Text = (iledni * cena).ToString();
        }
    }
}
