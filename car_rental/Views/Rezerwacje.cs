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
using car_rental.Views;

namespace car_rental.Views
{
    public partial class Rezerwacje : Form
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
        private readonly Edit_Rez _editR;
        string idrent, idauto, idklient, lokoddID, lokodbID, termin1, termin2, terminRez, terminWyp, PracRez, PracWyp, cena, chooseClientID;
        DateTime data1, data2;
        public string idprac;
        public Rezerwacje(Menu parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public Rezerwacje(Edit_Rez editR)
        {
            InitializeComponent();
            _editR = editR;
        }

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
                ComboBoxKlient.Items.Add(sqlRd["idklienci"].ToString() + " " + sqlRd["imie"].ToString() + " " + sqlRd["nazw"].ToString());
                ComboBoxKlient.DisplayMember = sqlRd["imie"].ToString() + " " + sqlRd["nazw"].ToString();
                ComboBoxKlient.ValueMember = sqlRd["idklienci"].ToString();
            }
            sqlRd.Close();
            sqlConn.Close();
        }

        private void ChooseClientTable()
        {
            sqlQuery = "SELECT * FROM baza1.`rezerwacje/wypozyczenia` WHERE status  = 'rezerwacja' and klienci_idklienci  = '" + chooseClientID + "'";
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
            sqlQuery = "SELECT * FROM baza1.`rezerwacje/wypozyczenia` WHERE status  = 'rezerwacja'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Czy napewno anulować wypożyczenie?", "Anuluj", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            {
                Auto();
                //Anuluj();
                Delete(idrent);
            }
            if (dR == DialogResult.No)
            {

            }
        }

        private void Auto()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "UPDATE `baza1`.`auta` SET `dostęp` = 'tak' WHERE(`idAuta` = '" + idauto + "') and(`lokalizacja_idlokalizacja` = '" + lokodbID + "');";
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

        private void Delete(string id)
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlQuery = "DELETE FROM baza1.`rezerwacje/wypozyczenia` WHERE idrezerwacje = @id";

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

        private void label1_Click(object sender, EventArgs e)
        {

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
                "password=" + password + ";" + "database=" + database + ";" + "Convert Zero Datetime=True";

            sqlQuery = "SELECT * FROM baza1.`rezerwacje/wypozyczenia` WHERE status  = 'rezerwacja'";
            sqlConn.Open();
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            DtA = new MySqlDataAdapter(sqlCmd);
            sqlDt = new DataTable();
            DtA.Fill(sqlDt);
            rents_dataGridView.DataSource = sqlDt;
            sqlConn.Close();
        }

        private void Wypozycz()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "UPDATE `baza1`.`rezerwacje/wypozyczenia` SET `godz_odb` = sysdate(), `status` = 'wypożyczony', `pracownik_wyp` = '" + idprac + "' WHERE(`idrezerwacje` = '" + idrent + "') and(`klienci_idklienci` = '" + idklient + "') and(`auta_idAuta` = '" + idauto + "');";
            try
            {
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
            upLoadData();
        }

        private void Anuluj()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "UPDATE `baza1`.`rezerwacje/wypozyczenia` SET `status` = 'anulowany' WHERE(`idrezerwacje` = '" + idrent + "') and(`klienci_idklienci` = '" + idklient + "') and(`auta_idAuta` = '" + idauto + "');";
            try
            {
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
            upLoadData();
        }

        private void rents_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idrent = rents_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                termin1 = rents_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                termin2 = rents_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                data1 = DateTime.ParseExact(termin1, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
                data2 = DateTime.ParseExact(termin2, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
                terminRez = rents_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                terminWyp = rents_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                PracRez = rents_dataGridView.SelectedRows[0].Cells[8].Value.ToString();
                PracWyp = rents_dataGridView.SelectedRows[0].Cells[9].Value.ToString();
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

        private void rent_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Czy napewno dokonać wypożyczenia?", "Wypożyczenie", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            {
                Wypozycz();
            }
            if (dR == DialogResult.No)
            {

            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Edit_Rez form;
            form = new Edit_Rez(this);
            form.pracownikID = idprac;
            form.idRent = idrent;
            form.idKlient = idklient;
            form.idAuto = idauto;
            form.idAutZm = idauto;
            form.idAutZmLok = dataGridViewLok1.Rows[0].Cells[0].Value.ToString();
            form.kl_imie.Text = dataGridViewClient.Rows[0].Cells[1].Value.ToString();
            form.kl_nazw.Text = dataGridViewClient.Rows[0].Cells[2].Value.ToString();
            form.kl_pesel.Text = dataGridViewClient.Rows[0].Cells[3].Value.ToString();
            form.kl_dow.Text = dataGridViewClient.Rows[0].Cells[4].Value.ToString();
            form.kl_mail.Text = dataGridViewClient.Rows[0].Cells[6].Value.ToString();
            form.kl_tel.Text = dataGridViewClient.Rows[0].Cells[5].Value.ToString();
            form.dateTimePicker1.Value = data1;
            form.dateTimePicker2.Value = data2;
            //form.wyp_cena.Text = cena;
            form.ComboBoxLokalizacja.Text = dataGridViewLok1.Rows[0].Cells[1].Value.ToString();
            form.Lokalizacja1.Text = dataGridViewLok2.Rows[0].Cells[1].Value.ToString();
            form.upLoadData();
            /*form.aut_mar.Text = dataGridViewCar.Rows[0].Cells[1].Value.ToString();
            form.aut_mod.Text = dataGridViewCar.Rows[0].Cells[2].Value.ToString();
            form.aut_rok.Text = dataGridViewCar.Rows[0].Cells[3].Value.ToString();
            form.aut_drzwi.Text = dataGridViewCar.Rows[0].Cells[4].Value.ToString();
            form.aut_miej.Text = dataGridViewCar.Rows[0].Cells[5].Value.ToString();
            form.aut_klima.Text = dataGridViewCar.Rows[0].Cells[6].Value.ToString();
            form.aut_skrz.Text = dataGridViewCar.Rows[0].Cells[7].Value.ToString();
            form.aut_cena.Text = dataGridViewCar.Rows[0].Cells[9].Value.ToString();
            form.cena = Int32.Parse(dataGridViewCar.Rows[0].Cells[9].Value.ToString());
            form.aut_klasa.Text = dataGridViewCar.Rows[0].Cells[10].Value.ToString();*/
            OpenChildForm(form);
            //OpenChildForm(new Edit_Rez());
        }

        private void Rezerwacje_Load(object sender, EventArgs e)
        {
            Fillcombobox();
            upLoadData();
        }

        private void new_rent_Click(object sender, EventArgs e)
        {
            PanelWynikow form;
            form = new PanelWynikow(this);
            form.pracownikID = idprac;
            OpenChildForm(form);

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
    }

}
