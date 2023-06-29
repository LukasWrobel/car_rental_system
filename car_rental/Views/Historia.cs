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
    public partial class Historia : Form
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
        string chooseClientID;
        string idrent, idauto, idklient, lokoddID, lokodbID, termin1, termin2, terminRez, terminWyp, terminKon, PracRez, PracWyp, PracKon, cena;


        private void Fillcombobox()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "SELECT idklienci, imie, nazw FROM baza1.klienci;";

            ComboBoxKlient.Items.Add("Wszyscy");
            sqlRd = sqlCmd.ExecuteReader();
            while (sqlRd.Read())
            {
                ComboBoxKlient.Items.Add(sqlRd["idklienci"].ToString() + " " + sqlRd["imie"].ToString() +" "+ sqlRd["nazw"].ToString());
                ComboBoxKlient.DisplayMember = sqlRd["imie"].ToString() +" "+ sqlRd["nazw"].ToString();
                ComboBoxKlient.ValueMember = sqlRd["idklienci"].ToString();
            }
            sqlRd.Close();
            sqlConn.Close();
        }

        private void ChooseClientTable()
        {
            sqlQuery = "SELECT * FROM baza1.`rezerwacje/wypozyczenia` WHERE status  = 'zakończone' and klienci_idklienci  = '" + chooseClientID + "'";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            rents_dataGridView.DataSource = sqlDt;
            sqlConn.Close();
        }

        private void ChooseAllClientTable()
        {
            sqlQuery = "SELECT * FROM baza1.`rezerwacje/wypozyczenia` WHERE status  = 'zakończone'";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            rents_dataGridView.DataSource = sqlDt;
            sqlConn.Close();
        }

        private void ComboBoxKlient_SelectedIndexChanged(object sender, EventArgs e)
        {
            chooseClientID = ComboBoxKlient.SelectedItem.ToString().Substring(0, 2);
            if (ComboBoxKlient.Text == "Wszyscy")
            {
                ChooseAllClientTable();
            }
            else
            {
                ChooseClientTable();
            }
        }

        private void rents_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idrent = rents_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                termin1 = rents_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                termin2 = rents_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                terminRez = rents_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                terminWyp = rents_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                terminKon = rents_dataGridView.SelectedRows[0].Cells[5].Value.ToString();
                PracRez = rents_dataGridView.SelectedRows[0].Cells[8].Value.ToString();
                PracWyp = rents_dataGridView.SelectedRows[0].Cells[9].Value.ToString();
                PracKon = rents_dataGridView.SelectedRows[0].Cells[10].Value.ToString();
                cena = rents_dataGridView.SelectedRows[0].Cells[6].Value.ToString();
                lokodbID = rents_dataGridView.SelectedRows[0].Cells[11].Value.ToString();
                lokoddID = rents_dataGridView.SelectedRows[0].Cells[12].Value.ToString();
                idklient = rents_dataGridView.SelectedRows[0].Cells[13].Value.ToString();
                idauto = rents_dataGridView.SelectedRows[0].Cells[14].Value.ToString();
                AutoTable();
                ClientTable();
                Lok1Table();
                Lok2Table();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Historia()
        {
            InitializeComponent();
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

        private void upLoadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            sqlQuery = "SELECT * FROM baza1.`rezerwacje/wypozyczenia` WHERE status  = 'zakończone'";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            rents_dataGridView.DataSource = sqlDt;
            sqlConn.Close();
        }
        private void Historia_Load(object sender, EventArgs e)
        {
            Fillcombobox();
            upLoadData();
        }


        private void details_Click_1(object sender, EventArgs e)
        {
            //zrób blokadę by nie dało się kliknąć bez wyboru z tabeli
            Szczegoly form;
            form = new Szczegoly(this);
            form.kl_imie.Text = dataGridViewClient.Rows[0].Cells[1].Value.ToString(); ;
            form.kl_nazw.Text = dataGridViewClient.Rows[0].Cells[2].Value.ToString(); ;
            form.kl_pesel.Text = dataGridViewClient.Rows[0].Cells[3].Value.ToString(); ;
            form.kl_dow.Text = dataGridViewClient.Rows[0].Cells[4].Value.ToString(); ;
            form.kl_mail.Text = dataGridViewClient.Rows[0].Cells[6].Value.ToString(); ;
            form.kl_tel.Text = dataGridViewClient.Rows[0].Cells[5].Value.ToString(); ;
            form.wyp_od.Text = termin1;
            form.wyp_do.Text = termin2;
            form.wyp_cena.Text = cena;
            form.wyp_modb.Text = dataGridViewLok1.Rows[0].Cells[1].Value.ToString();
            form.wyp_modd.Text = dataGridViewLok2.Rows[0].Cells[1].Value.ToString();
            form.aut_mar.Text = dataGridViewCar.Rows[0].Cells[1].Value.ToString();
            form.aut_mod.Text = dataGridViewCar.Rows[0].Cells[2].Value.ToString();
            form.aut_rok.Text = dataGridViewCar.Rows[0].Cells[3].Value.ToString();
            form.aut_drzwi.Text = dataGridViewCar.Rows[0].Cells[4].Value.ToString();
            form.aut_miej.Text = dataGridViewCar.Rows[0].Cells[5].Value.ToString();
            form.aut_klima.Text = dataGridViewCar.Rows[0].Cells[6].Value.ToString();
            form.aut_skrz.Text = dataGridViewCar.Rows[0].Cells[7].Value.ToString();
            form.aut_cena.Text = dataGridViewCar.Rows[0].Cells[9].Value.ToString();
            form.aut_klasa.Text = dataGridViewCar.Rows[0].Cells[10].Value.ToString();
            form.data_rez.Text = terminRez;
            form.id_prac_rez.Text = PracRez;
            form.data_wyp.Text = terminWyp;
            form.id_prac_wyp.Text = PracWyp;
            form.data_kon.Text = terminKon;
            form.id_prac_kon.Text = PracKon;
            OpenChildForm(form);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void AutoTable()
        {
            sqlQuery = "SELECT * FROM baza1.auta WHERE idAuta  = '" + idauto + "'";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            dataGridViewCar.DataSource = sqlDt;
            sqlConn.Close();
        }

        private void ClientTable()
        {
            sqlQuery = "SELECT * FROM baza1.klienci WHERE idklienci  = '" + idklient + "'";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            dataGridViewClient.DataSource = sqlDt;
            sqlConn.Close();
        }

        private void Lok1Table()
        {
            sqlQuery = "SELECT * FROM baza1.lokalizacja WHERE idlokalizacja  = '" + lokodbID + "'";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            dataGridViewLok1.DataSource = sqlDt;
            sqlConn.Close();
        }

        private void Lok2Table()
        {
            sqlQuery = "SELECT * FROM baza1.lokalizacja WHERE idlokalizacja  = '" + lokoddID + "'";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            dataGridViewLok2.DataSource = sqlDt;
            sqlConn.Close();
        }

        private void rents_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
