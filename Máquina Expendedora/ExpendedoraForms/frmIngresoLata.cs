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
    public partial class frmIngresoLata : Form
    {
        private Expendedora _expendedora;
        public frmIngresoLata(Expendedora e,Form formPropietario)
        {
            this._expendedora = e;
            this.Owner = formPropietario;
            this.Owner.Hide();
            InitializeComponent();
        }
        #region "Métodos"
        private void CargarListaLatas(List<Lata> latas)
        {
            lstLatasIngreso.DataSource = null;
            lstLatasIngreso.DataSource = latas;
        }
        private void CargarComboTipoCodigo()
        {
            List<String> tipos = new List<string>();
            tipos.Add("CO");
            tipos.Add("SP");
            tipos.Add("FA");
            cmbTipoCodigo.DataSource = tipos;
        }
        private void CargarComboTipoSabor()
        {
            List<String> tipos = new List<string>();
            tipos.Add("1");
            tipos.Add("2");
            cmbTipoSabor.DataSource = tipos;
        }
        private void CambiarlblMarca()
        {
            if (cmbTipoCodigo.SelectedValue.ToString() == "CO")
            {
                lblMarca.Text = "Marca: Coca Cola";
            }
            else if (cmbTipoCodigo.SelectedValue.ToString() == "SP")
            {
                lblMarca.Text = "Marca: Sprite";
            }
            else if (cmbTipoCodigo.SelectedValue.ToString() == "FA")
            {
                lblMarca.Text = "Marca: Fanta";
            }
        }
        private void CambiarlblSabor()
        {
            if (cmbTipoSabor.SelectedValue.ToString() == "1")
            {
                lblSabor.Text = "Sabor: Regular";
            }
            else if (cmbTipoSabor.SelectedValue.ToString() == "2")
            {
                lblSabor.Text = "Sabor: Zero";
            }
            CambiarlblPrecio();
        }
        private void CambiarlblPrecio()
        {
            if (cmbTipoCodigo.SelectedValue.ToString() == "CO")
            {
                if (cmbTipoSabor.SelectedValue.ToString() == "1")
                {
                    lblPrecio.Text = "Precio: $35";
                }
                else if(cmbTipoSabor.SelectedValue.ToString() == "2")
                {
                    lblPrecio.Text = "Precio: $45";
                }
            }else if(cmbTipoCodigo.SelectedValue.ToString() == "SP")
            {
                if (cmbTipoSabor.SelectedValue.ToString() == "1")
                {
                    lblPrecio.Text = "Precio: $33";
                }
                else if (cmbTipoSabor.SelectedValue.ToString() == "2")
                {
                    lblPrecio.Text = "Precio: $43";
                }
            }else if(cmbTipoCodigo.SelectedValue.ToString() == "FA")
            {
                if (cmbTipoSabor.SelectedValue.ToString() == "1")
                {
                    lblPrecio.Text = "Precio: $50";
                }
                else if (cmbTipoSabor.SelectedValue.ToString() == "2")
                {
                    lblPrecio.Text = "Precio: $60";
                }
            }
        }
        #endregion
        private void frmIngresoLata_Load(object sender, EventArgs e)
        {
            CargarListaLatas(_expendedora.Latas);
            CargarComboTipoCodigo();
            CargarComboTipoSabor();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarlblMarca();
        }

        private void cmbTipoSabor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarlblSabor();
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}
