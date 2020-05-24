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
    public partial class frmExtraerLata : Form
    {
        private Expendedora _expendedora;
        public frmExtraerLata(Expendedora e,Form formPropietario)
        {
            this._expendedora = e;
            this.Owner = formPropietario;
            this.Owner.Hide();
            InitializeComponent();
        }
        #region "Métodos"
        private void CargarComboCodigoEx()
        {
            List<String> tipos = new List<string>();
            tipos.Add("(Elija una opción)");
            tipos.Add("CO1");
            tipos.Add("CO2");
            tipos.Add("SP1");
            tipos.Add("SP2");
            tipos.Add("FA1");
            tipos.Add("FA2");
            cmbCodigoEx.DataSource = tipos;
        }
        private void CargarListaLatas(List<Lata> latas)
        {
            lstExtraerLata.DataSource = null;
            lstExtraerLata.DataSource = latas;
            LimpiarCampos();
        }
        private void Cambiarlbl()
        {
            string codigo = cmbCodigoEx.Text;
            switch (codigo)
            {
                case "CO1":
                    lblPrecioEx.Text = "Precio: $35";
                    lblMarcaEx.Text = "Marca: Coca Cola";
                    lblSaborEx.Text = "Sabor: Regular";
                    break;
                case "CO2":
                    lblPrecioEx.Text = "Precio: $45";
                    lblMarcaEx.Text = "Marca: Coca Cola";
                    lblSaborEx.Text = "Sabor: Zero";
                    break;
                case "SP1":
                    lblPrecioEx.Text = "Precio: $33";
                    lblMarcaEx.Text = "Marca: Sprite";
                    lblSaborEx.Text = "Sabor: Regular";
                    break;
                case "SP2":
                    lblPrecioEx.Text = "Precio: $43";
                    lblMarcaEx.Text = "Marca: Sprite";
                    lblSaborEx.Text = "Sabor: Zero";
                    break;
                case "FA1":
                    lblPrecioEx.Text = "Precio: $50";
                    lblMarcaEx.Text = "Marca: Fanta";
                    lblSaborEx.Text = "Sabor: Regular";
                    break;
                case "FA2":
                    lblPrecioEx.Text = "Precio: $60";
                    lblMarcaEx.Text = "Marca: Fanta";
                    lblSaborEx.Text = "Sabor: Zero";
                    break;
                default:
                    lblPrecioEx.Text = "Precio:";
                    lblMarcaEx.Text = "Marca:";
                    lblSaborEx.Text = "Sabor:";
                    break;
            }
        }
        private Boolean ValidarCampos()
        {
            bool valido = true;
            string msg = string.Empty;
            if (cmbCodigoEx.SelectedValue.ToString() == "(Elija una opción)")
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
        private void LimpiarCampos()
        {
            txtDinero.Text = string.Empty;
            cmbCodigoEx.SelectedIndex = 0;
        }
        private string TraerTipoSeleccionado()
        {
            string codigo = cmbCodigoEx.Text;
            switch (codigo)
            {
                case "CO1":
                    return "CO1";
                case "CO2":
                    return "CO2";
                case "SP1":
                    return "SP1";
                case "SP2":
                    return "SP2";
                case "FA1":
                    return "FA1";
                case "FA2":
                    return "FA2";
                default:
                    return "";
            }
        }
        private void CompletarFormulario(Lata seleccionada)
        {
            switch (seleccionada.Codigo)
            {
                case "CO1":
                    cmbCodigoEx.SelectedIndex = 1;
                    break;
                case "CO2":
                    cmbCodigoEx.SelectedIndex = 2;
                    break;
                case "SP1":
                    cmbCodigoEx.SelectedIndex = 3;
                    break;
                case "SP2":
                    cmbCodigoEx.SelectedIndex = 4;
                    break;
                case "FA1":
                    cmbCodigoEx.SelectedIndex = 5;
                    break;
                case "FA2":
                    cmbCodigoEx.SelectedIndex = 6;
                    break;
                default:
                    cmbCodigoEx.SelectedIndex = 0;
                    break;
            }
            txtDinero.Text = seleccionada.Precio.ToString();
        }
        #endregion

        private void frmExtraerLata_Load(object sender, EventArgs e)
        {
            CargarComboCodigoEx();
            CargarListaLatas(_expendedora.Latas);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cambiarlbl();
        }
        private void btnApagarEx_Click(object sender, EventArgs e)
        {
            if (cmbCodigoEx.SelectedIndex != 0 || txtDinero.Text != String.Empty)
            {
                DialogResult pregunta = MessageBox.Show("Se perderán los datos ingresados. ¿Está seguro de cerrar la aplicación?", "Salir", MessageBoxButtons.YesNo);
                if (pregunta.ToString() == "Yes")
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }
        private void btnVolverEx_Click(object sender, EventArgs e)
        {
            if (cmbCodigoEx.SelectedIndex != 0 || txtDinero.Text != String.Empty)
            {
                DialogResult pregunta = MessageBox.Show("Se perderán los datos ingresados. ¿Está seguro de volver al menú principal?", "Atención", MessageBoxButtons.YesNo);
                if (pregunta.ToString() == "Yes")
                {
                    this.Owner.ShowReload();
                    this.Dispose();
                }
            }
            else
            {
                this.Owner.ShowReload();
                this.Dispose();
            }
        }
        private void btnExtraer_Click(object sender, EventArgs e)
        {
            if (txtDinero.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar el dinero para comprar la lata.");
            }
            else
            {
                try
                {
                    if (ValidarCampos())
                    {
                        Lata lataExtraida = _expendedora.ExtraerLata(TraerTipoSeleccionado(), Convert.ToDouble(txtDinero.Text));
                        if (Convert.ToDouble(txtDinero.Text) > lataExtraida.Precio)
                        {
                            MessageBox.Show("Ha comprado la lata: " + lataExtraida.Nombre + " sabor " + lataExtraida.Sabor + "\nSu vuelto: $" + (Convert.ToDouble(txtDinero.Text) - lataExtraida.Precio).ToString());
                        }
                        else if(Convert.ToDouble(txtDinero.Text) == lataExtraida.Precio)
                        {
                            MessageBox.Show("Ha comprado la lata: " + lataExtraida.Nombre + " sabor " + lataExtraida.Sabor);
                        }
                        CargarListaLatas(_expendedora.Latas);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void lstExtraerLata_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lata seleccionada = (Lata)lstExtraerLata.SelectedItem;
            if (seleccionada != null)
            {
                CompletarFormulario(seleccionada);
            }
        }
        private void frmExtraerLata_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
