using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_rental
{
    public partial class Choose_client : Form
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
        private readonly Choose_car _car;
        public string carID, data1, data2, l1,l2, pracID;
        public int dni;
        public Choose_client(Choose_car car)
        {
            InitializeComponent();
            _car = car;
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

        public void upLoadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            sqlQuery = "SELECT * FROM baza1.klienci";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            dataGridView1.DataSource = sqlDt;
            sqlConn.Close();
        }

        private void Search()
        {
            sqlQuery = "SELECT * FROM baza1.klienci WHERE nazw LIKE '%" + textBox6.Texts + "%'";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            dataGridView1.DataSource = sqlDt;
            sqlConn.Close();
        }

        private void Auto()
        {
            sqlQuery = "SELECT * FROM baza1.auta WHERE idAuta  = '"+carID+"'";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            dataGridView2.DataSource = sqlDt;
            sqlConn.Close();
        }

        private void Choose_client_Load(object sender, EventArgs e)
        {
            upLoadData();
            Auto();
        }


        private void textBox6__TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void new_client_Click(object sender, EventArgs e)
        {
            New_klient form;
            form = new New_klient(this);
            form.kl_dodaj.Text = "Dodaj klienta";
            form.Clear();
            OpenChildForm(form);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idtxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                imietxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                nazwtxt.Text= dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                peseltxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                nr_dowtxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                teltxt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                mailtxt.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idtxt.Text != "")
            {
                string cenazadobe = dataGridView2.Rows[0].Cells[9].Value.ToString();
                int cena = Int32.Parse(cenazadobe);
                Podsumowanie form;
                form = new Podsumowanie(this);
                form.pracownikID = pracID;
                form.klientID = idtxt.Text;
                form.kl_imie.Text = imietxt.Text;
                form.kl_nazw.Text = nazwtxt.Text;
                form.kl_pesel.Text = peseltxt.Text;
                form.kl_dow.Text = nr_dowtxt.Text;
                form.kl_mail.Text = mailtxt.Text;
                form.kl_tel.Text = teltxt.Text;
                form.wyp_cena.Text = (dni * cena).ToString();
                form.wyp_od.Text = data1;
                form.wyp_do.Text = data2;
                form.wyp_modb.Text = l1;
                form.wyp_modd.Text = l2;
                form.autID = dataGridView2.Rows[0].Cells[0].Value.ToString();
                form.aut_mar.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                form.aut_mod.Text = dataGridView2.Rows[0].Cells[2].Value.ToString();
                form.aut_rok.Text = dataGridView2.Rows[0].Cells[3].Value.ToString();
                form.aut_drzwi.Text = dataGridView2.Rows[0].Cells[4].Value.ToString();
                form.aut_miej.Text = dataGridView2.Rows[0].Cells[5].Value.ToString();
                form.aut_klima.Text = dataGridView2.Rows[0].Cells[6].Value.ToString();
                form.aut_skrz.Text = dataGridView2.Rows[0].Cells[7].Value.ToString();
                form.aut_cena.Text = dataGridView2.Rows[0].Cells[9].Value.ToString();
                form.aut_klasa.Text = dataGridView2.Rows[0].Cells[10].Value.ToString();
                OpenChildForm(form);
            }
            else
            {
                MessageBox.Show("Wybierz klienta.");
            }
        }
    }
}
