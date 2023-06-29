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
    public partial class Samochody : Form
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
        private readonly Menu _parent;
        public string userrola;
        string  lokal;
        string car_index, car_marka,car_model, car_rp, car_id, car_im, car_klima, car_skrz, car_dos, car_cena, car_klasa, car_rej, car_vin, car_lok;
        public Samochody(Menu parent)
        {
            InitializeComponent();
            _parent = parent;
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

            sqlQuery = "SELECT * FROM baza1.auta";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            cars_dataGridView.DataSource = sqlDt;
            sqlConn.Close();
        }

        private void Delete(string id)
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlQuery = "DELETE FROM baza1.auta WHERE idAuta = @id";
            
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            try
            {
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Dane zostały usunięte");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();

            upLoadData();
        }

        private void Search()
        {
            sqlQuery = "SELECT * FROM baza1.auta WHERE marka LIKE '%" + textBox1.Texts + "%'";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            cars_dataGridView.DataSource = sqlDt;
            sqlConn.Close();
        }
        private void new_car_Click_1(object sender, EventArgs e)
        {
            New_car form;
            form = new New_car(this);
            form.button1.Text = "Dodaj";
            form.Clear();
            OpenChildForm(form);
        }

        private void Samochody_Load(object sender, EventArgs e)
        {
            upLoadData();
            if (userrola == "użytkownik")
            {
                delete_car.Visible = false;
                delete_car.Enabled = false;
            }
        }

        private void delete_car_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Czy napewno chcesz usunąć dane pojzadu?", "Usuń pojazd", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            {
                Delete(car_index);
            }
            if (dR == DialogResult.No)
            {

            }
            
        }

        private void Lok()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT `adres` FROM baza1.lokalizacja WHERE `idlokalizacja` = '" + car_lok + "'";
            sqlRd = sqlCmd.ExecuteReader();
            while (sqlRd.Read())
            {
                lokal = sqlRd[0].ToString();
            }
            sqlRd.Close();
            sqlConn.Close();
            /*sqlQuery = "SELECT `adres` FROM baza.lokalizacja WHERE `idlokalizacja` = '" + car_lok + "'";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            lokal = sqlDt.Rows[0].ItemArray.ToString();
            //form.ComboBoxLokalizacja.Items = sqlDt.Rows[0].val;
            sqlConn.Close();*/
        }

        private void cars_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                car_index = cars_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                car_marka = cars_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                car_model = cars_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                car_rp = cars_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                car_id = cars_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                car_im = cars_dataGridView.SelectedRows[0].Cells[5].Value.ToString();
                car_klima = cars_dataGridView.SelectedRows[0].Cells[6].Value.ToString();
                car_skrz = cars_dataGridView.SelectedRows[0].Cells[7].Value.ToString();
                car_dos = cars_dataGridView.SelectedRows[0].Cells[8].Value.ToString();
                car_cena = cars_dataGridView.SelectedRows[0].Cells[9].Value.ToString();
                car_klasa = cars_dataGridView.SelectedRows[0].Cells[10].Value.ToString();
                car_rej = cars_dataGridView.SelectedRows[0].Cells[11].Value.ToString();
                car_vin = cars_dataGridView.SelectedRows[0].Cells[12].Value.ToString();
                car_lok = cars_dataGridView.SelectedRows[0].Cells[13].Value.ToString();
                Lok();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1__TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void edit_car_Click(object sender, EventArgs e)
        {
            New_car form;
            form = new New_car(this);
            form.button1.Text = "Zapisz";
            OpenChildForm(form);
            form.index = car_index;
            form.textBoxMarka.Text = car_marka;
            form.textBoxModel.Text = car_model;
            form.rok_prdukcji_datapicker.Text = "01.01."+car_rp;
            form.textBoxDrzwi.Text = car_id;
            form.textBoxMiejsca.Text = car_im;
            form.comboBoxKlima.Text = car_klima;
            form.comboBoxSkrzynia.Text = car_skrz;
            form.comboBoxDostep.Text = car_dos;
            form.textBoxCenaDoba.Text = car_cena;
            form.comboBoxKlasa.Text = car_klasa;
            form.textBoxNrRej.Text = car_rej;
            form.textBoxNrVin.Text = car_vin;
            form.ComboBoxLokalizacja.Text = lokal;
        }
    }
}
