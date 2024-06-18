using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pap
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void btnPageQueixa_Click(object sender, EventArgs e)
        {
            QueixaForm queixaForm = new QueixaForm();
            queixaForm.Show();
            this.Hide();
        }

        private void btnPageBusca_Click(object sender, EventArgs e)
        {
            BuscarForm buscarForm = new BuscarForm();
            buscarForm.Show();
            this.Hide();
        }

        private void btnPageInsercao_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
