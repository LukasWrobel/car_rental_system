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
    public partial class Szczegoly : Form
    {
        private readonly Wypozyczenia _wyp;
        private readonly Historia _his;
        public Szczegoly(Wypozyczenia wyp)
        {
            InitializeComponent();
            _wyp = wyp;
        }

        public Szczegoly(Historia his)
        {
            InitializeComponent();
            _his = his;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
