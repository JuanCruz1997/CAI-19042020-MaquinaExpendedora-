using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpendedoraForms
{
    public partial class frmExpendedora : Form
    {
        private Expendedora _expendedora;
        public Expendedora Expendedora
        {
            get
            {
                return _expendedora;
            }
        }
        public frmExpendedora(Expendedora exp)
        {
            _expendedora = exp;
            InitializeComponent();
        }
        #region "Métodos"
        private void CargarListaLatas(List<Lata> latas)
        {
            lstLatas.DataSource = null;
            lstLatas.DataSource = latas;
        }
        #endregion
        #region "Eventos"
        private void frmExpendedora_Load(object sender, EventArgs e)
        {
            CargarListaLatas(_expendedora.Latas);
        }
        private void lstLatas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }        
        private void btnIngresarLata_Click(object sender, EventArgs e)
        {
            frmIngresoLata fexp = new frmIngresoLata(_expendedora, this);
            fexp.Owner = this;
            fexp.Show();
            this.Hide();
        }
        private void btnExtraerLata_Click(object sender, EventArgs e)
        {
            frmExtraerLata fexp = new frmExtraerLata(_expendedora, this);
            fexp.Owner = this;
            fexp.Show();
            this.Hide();
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
