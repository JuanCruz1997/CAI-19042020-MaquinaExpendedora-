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
        private void CargarComboCodigo()
        {
            List<String> tipos = new List<string>();
            tipos.Add("(Elija una opción)");
            tipos.Add("CO1");
            tipos.Add("CO2");
            tipos.Add("SP1");
            tipos.Add("SP2");
            tipos.Add("FA1");
            tipos.Add("FA2");
            cmbCodigo.DataSource = tipos;
        }
        private void Cambiarlbl()
        {
            if (cmbCodigo.SelectedValue.ToString() == "CO1")
            {
                lblPrecio.Text = "Precio: $35";
                lblMarca.Text = "Marca: Coca Cola";
                lblSabor.Text = "Sabor: Regular";
            }
            else if (cmbCodigo.SelectedValue.ToString() == "CO2")
            {
                lblPrecio.Text = "Precio: $45";
                lblMarca.Text = "Marca: Coca Cola";
                lblSabor.Text = "Sabor: Zero";
            }
            else if (cmbCodigo.SelectedValue.ToString() == "SP1")
            {
                lblPrecio.Text = "Precio: $33";
                lblMarca.Text = "Marca: Sprite";
                lblSabor.Text = "Sabor: Regular";
            }
            else if (cmbCodigo.SelectedValue.ToString() == "SP2")
            {
                lblPrecio.Text = "Precio: $43";
                lblMarca.Text = "Marca: Sprite";
                lblSabor.Text = "Sabor: Zero";
            }
            else if (cmbCodigo.SelectedValue.ToString() == "FA1")
            {
                lblPrecio.Text = "Precio: $50";
                lblMarca.Text = "Marca: Fanta";
                lblSabor.Text = "Sabor: Regular";
            }
            else if (cmbCodigo.SelectedValue.ToString() == "FA2")
            {
                lblPrecio.Text = "Precio: $60";
                lblMarca.Text = "Marca: Fanta";
                lblSabor.Text = "Sabor: Zero";
            }
        }
        private Boolean ValidarCampos()
        {
            bool valido = true;
            string msg = string.Empty;
            if(cmbCodigo.SelectedValue.ToString()=="(Elija una opción)")
            {
                msg = "Debe seleccionar un tipo\n";
            }
            if (msg != string.Empty)
            {
                valido = false;
                MessageBox.Show(msg);
            }
            return valido;
        }
        #endregion
        private void frmIngresoLata_Load(object sender, EventArgs e)
        {
            CargarListaLatas(_expendedora.Latas);
            CargarComboCodigo();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void cmbTipoCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cambiarlbl();
        }
        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtVolumen.Text != String.Empty)
            {
                MessageBox.Show("Para agregar una nueva lata debe limpiar el formulario primero.");
            }
            else
            {
                try
                {
                    if (ValidarCampos())
                    {
                        Lata lataAIngresar = new Lata(cmbCodigo.SelectedValue.ToString(), txtVolumen.Text.ToñDo);
                    }
                }
                catch(Exception e)
                {

                }
            }
        }
    }
}
