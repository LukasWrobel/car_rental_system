using car_rental.Views;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_rental
{
    public partial class Menu : Form
    {
        
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        private readonly Start _parent;
        public string pracID, userRole;
        public Menu(Start parent)
        {
            InitializeComponent();
            _parent = parent;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 70);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = Color.White;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
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
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelChildForm.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            labelChildForm.Text = "Home";
        }
        private void logout_iconButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Start start = new Start();
            start.Show();
        }

        private void car_iconButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Samochody form;
            form = new Samochody(this);
            form.userrola = userRole;
            OpenChildForm(form);
        }

        private void clients_iconButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Klienci form;
            form = new Klienci(this);
            form.userROLA = userRole;
            OpenChildForm(form);
        }

        private void rent_iconButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Wypozyczenia form;
            form = new Wypozyczenia(this);
            form.IDpracownika = pracID;
            OpenChildForm(form);
        }

        private void booking_iconButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            //OpenChildForm(new Rezerwacje());
            Rezerwacje form;
            form = new Rezerwacje(this);
            form.idprac = pracID;
            OpenChildForm(form);
        }

        private void employee_iconButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Pracownicy());
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void history_iconButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Historia());
        }

        private void lokalizacje_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Lokalizacje());
        }

        private void raport_iconButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Raporty());
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            PanelWynikow form;
            form = new PanelWynikow(this);
            form.pracownikID = pracID;
            if(userRole == "administrator")
            {
                employee_iconButton.Visible = true;
                employee_iconButton.Enabled = true;
                lokalizacje.Visible = true;
                lokalizacje.Enabled = true;
            } else if(userRole == "użytkownik")
            {
                employee_iconButton.Visible = false;
                employee_iconButton.Enabled = false;
                lokalizacje.Visible = false;
                lokalizacje.Enabled = false;
            }
            OpenChildForm(form);
        }
    }
}
