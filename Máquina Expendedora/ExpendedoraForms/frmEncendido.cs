using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpendedoraForms
{
    public partial class frmEncendido : Form
    {
        public frmEncendido()
        {
            InitializeComponent();
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            Expendedora appExpendedora = new Expendedora("FCE", 50);
            frmExpendedora fexp = new frmExpendedora(appExpendedora);
            fexp.Owner = this;
            fexp.Show();
            this.Hide();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEncendido_Load(object sender, EventArgs e)
        {

        }
    }
}
