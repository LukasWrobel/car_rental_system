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
    public partial class PanelWynikow : Form
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
        string data1, data2, time1, time2, lok1, lok2, lok1id;
        public DateTime dateTime1, dateTime2;
        public string pracownikID;
        private Form currentChildForm;
        private readonly Menu _parent;
        private readonly Rezerwacje _rez;

        public PanelWynikow(Menu parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public PanelWynikow(Rezerwacje rez)
        {
            InitializeComponent();
            _rez = rez;
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

        private void Lokal()
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboBoxLokalizacja_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lokal();
            lok1 = ComboBoxLokalizacja.Text;
        }

        private void Lokalizacja1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lok2 = Lokalizacja1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Lokalizacja1.Text = ComboBoxLokalizacja.Text;
                lok2 = Lokalizacja1.Text;
            }
            else Lokalizacja1.Text = "";
        }

        private void PanelWynikow_Load(object sender, EventArgs e)
        {
            Fillcombobox();
            dateTimePicker1.MinDate = DateTime.Today;
            data1 = dateTimePicker1.Value.Date.ToString("dd.MM.yyyy");
            dateTime1 = dateTimePicker1.Value.Date;
            dateTimePicker2.MinDate = DateTime.Today.AddDays(1);
            data2 = dateTimePicker2.Value.Date.ToString("dd.MM.yyyy");
            dateTime2 = dateTimePicker2.Value.Date;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ComboBoxLokalizacja.Text !="" && Lokalizacja1.Text != "")
            {
                Choose_car form;
                form = new Choose_car(this);
                form.lokID = lok1id;
                form.pID = pracownikID;
                form.dataOD = data1;
                form.dataDO = data2;
                form.lokal1 = lok1;
                form.lokal2 = lok2;
                form.dateTimePicker1.Value = dateTime1;
                form.dateTimePicker2.Value = dateTime2;
                form.button4.Visible = true;
                form.button4.Enabled = true;
                OpenChildForm(form);
            }
            else
            {
                MessageBox.Show("Wybierz lokalizację odbioru i zwrotu pojazdu");
            }
        }


        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            data2 = dateTimePicker2.Value.Date.ToString("dd.MM.yyyy");
            dateTime2 = dateTimePicker2.Value.Date;
        }


        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            data1 = dateTimePicker1.Value.Date.ToString("dd.MM.yyyy");
            dateTime1 = dateTimePicker1.Value.Date;
            //label5.Text = data1;
        }
    }
}
