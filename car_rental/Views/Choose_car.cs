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
    public partial class Choose_car : Form
    {
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        String sqlQuery, sqlQuery1;
        public String sqlQ;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        DataSet DS = new DataSet();
        MySqlDataReader sqlRd;
        String server = "localhost";
        String username = "root";
        String password = "P@ssw0rd";
        String database = "baza1";
        private Form currentChildForm;
        string ile_miejsc = ""; 
        string nadwozie =""; 
        string klima = "";
        string skrz = "";
        string cena, aut_id, data;
        int iledni;
        public DateTime datetime1, datetime2;
        public string dataOD, dataDO, lokal1, lokal2, pID, lokID;
        public string idKl, idAut, idAutZm,idAutZmLok, idR, imie, nazw, pesel, dow, tel, mail;
        private readonly PanelWynikow _panel;
        private readonly Edit_Rez _editRez;

        public Choose_car(PanelWynikow panel)
        {
            InitializeComponent();
            _panel = panel;
        }
        public Choose_car(Edit_Rez editRez)
        {
            InitializeComponent();
            _editRez = editRez;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void comboBoxLM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLM.Text == "Wszystkie")
            {
                ile_miejsc = "";
            }
            if (comboBoxLM.Text == "4")
            {
                ile_miejsc = " AND ilość_miejsc = 4";
            }
            if (comboBoxLM.Text == "5")
            {
                ile_miejsc = " AND ilość_miejsc = 5";
            }
            if (comboBoxLM.Text == "6+")
            {
                ile_miejsc = " AND ilość_miejsc >= 6";
            }
        }

        private void comboBoxKlasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxKlasa.Text == "Wszystkie")
            {
                nadwozie = "";
            }
            if (comboBoxKlasa.Text == "Coupe")
            {
                nadwozie = " AND klasa = 'coupe'";
            }
            if (comboBoxKlasa.Text == "Hatchback")
            {
                nadwozie = " AND klasa = 'hatchback'";
            }
            if (comboBoxKlasa.Text == "Kabriolet")
            {
                nadwozie = " AND klasa = 'kabriolet'";
            }
            if (comboBoxKlasa.Text == "Kombi")
            {
                nadwozie = " AND klasa = 'kombi'";
            }
            if (comboBoxKlasa.Text == "Limuzyna")
            {
                nadwozie = " AND klasa = 'limuzyna'";
            }
            if (comboBoxKlasa.Text == "Sedan")
            {
                nadwozie = " AND klasa = 'sedan'";
            }
            if (comboBoxKlasa.Text == "SUV")
            {
                nadwozie = " AND klasa = 'SUV'";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxSkrz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSkrz.Text == "Wszystkie")
            {
                skrz = "";
            }
            if (comboBoxSkrz.Text == "Automatyczna")
            {
                skrz = " and skrzynia = 'aut'";
            }
            if (comboBoxSkrz.Text == "Manualna")
            {
                skrz = " and skrzynia = 'man'";
            }
        }

        

        private void upLoadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;
            sqlQuery = "SELECT idAuta, marka, model, ilość_miejsc, rok_prod, klasa, cena FROM baza1.auta WHERE dostęp = 'tak' " +
                "AND lokalizacja_idlokalizacja = '"+lokID+"'";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            dataGridView1.DataSource = sqlDt;
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

        private void Choose_car_Load(object sender, EventArgs e)
        {
            upLoadData();
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today.AddDays(1);
            //dateTimePicker1.Value = datetime1;
            //dateTimePicker2.Value = datetime2;
            Oblicz();
        }

        private void Oblicz()
        {
            data = ((dateTimePicker2.Value - dateTimePicker1.Value).TotalDays).ToString();
            iledni = Int32.Parse(data);
        }

        private void Filtr()
        {
            if (textBox1.Text == "")
            {
                cena = "2000";
            }
            sqlQuery1 = "SELECT idAuta, marka, model, ilość_miejsc, rok_prod, klasa, cena FROM baza1.auta WHERE dostęp = 'tak' " +
                "AND lokalizacja_idlokalizacja = '" + lokID + "' AND cena <= " + cena + "" + nadwozie + "" + ile_miejsc + "" + klima + "" + skrz + "";
            sqlCmd = new MySqlCommand(sqlQuery1, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            dataGridView1.DataSource = sqlDt;
            sqlConn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkCar.Text !="")
            {
                if (button1.Text == "Dalej")
                {
                    Choose_client form;
                    form = new Choose_client(this);
                    form.pracID = pID;
                    form.data1 = dataOD;
                    form.data2 = dataDO;
                    form.carID = aut_id;
                    form.dni = iledni;
                    form.l1 = lokal1;
                    form.l2 = lokal2;
                    OpenChildForm(form);
                }
                if (button1.Text == "Zmień auto")
                {
                    //zmien status auta
                    //idAutZm
                    zmienStatusAuta();
                    Edit_Rez form;
                    form = new Edit_Rez(this);
                    form.idRent = idR;
                    form.idAuto = aut_id;
                    form.idAutZm = idAutZm;
                    form.idKlient = idKl;
                    form.kl_imie.Text = imie;
                    form.kl_nazw.Text = nazw;
                    form.kl_dow.Text = dow;
                    form.kl_pesel.Text = pesel;
                    form.kl_mail.Text = mail;
                    form.kl_tel.Text = tel;
                    form.lok1id = lokID;
                    form.ComboBoxLokalizacja.Text = lokal1;
                    form.Lokalizacja1.Text = lokal2;
                    form.dateTimePicker1.Value = datetime1;
                    form.dateTimePicker2.Value = datetime2;
                    form.upLoadData();
                    //form.Oblicz();
                    OpenChildForm(form);
                }
            }
            else
            {
                MessageBox.Show("Wybierz pojazd.");
            }
            
        }

        private void zmienStatusAuta()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "UPDATE `baza1`.`auta` SET `dostęp` = 'tak', `lokalizacja_idlokalizacja` = '" + idAutZmLok + "' WHERE(`idAuta` = '" + idAutZm + "') and(`lokalizacja_idlokalizacja` = '" + idAutZmLok + "');";
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

        private void zmienStatus()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "UPDATE `baza1`.`auta` SET `dostęp` = 'tak', `lokalizacja_idlokalizacja` = '" + lokID + "' WHERE(`idAuta` = '" + idAutZm + "') and(`lokalizacja_idlokalizacja` = '" + lokID + "');";
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            klima = "";
            //klima
            if (checkBox1.Checked == true)
            {
                //klima = "tak";
                klima = " and klimatyzacja = 'tak'";
            }
            if (checkBox1.Checked == false)
            {
                //klima = "nie";
                klima = " and klimatyzacja = 'nie'";
            }
        }

        private void Filtruj_Click(object sender, EventArgs e)
        {
            Filtr();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cena = textBox1.Text;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            upLoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                aut_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                checkCar.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
