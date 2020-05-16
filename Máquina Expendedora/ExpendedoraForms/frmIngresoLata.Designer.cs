namespace ExpendedoraForms
{
    partial class frmIngresoLata
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIngresar = new System.Windows.Forms.Label();
            this.lstLatasIngreso = new System.Windows.Forms.ListBox();
            this.btnApagarIngreso = new System.Windows.Forms.Button();
            this.lblCodigoMarca = new System.Windows.Forms.Label();
            this.cmbTipoCodigo = new System.Windows.Forms.ComboBox();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.lblPropiedades = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblSabor = new System.Windows.Forms.Label();
            this.lblCodigoSabor = new System.Windows.Forms.Label();
            this.cmbTipoSabor = new System.Windows.Forms.ComboBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar.Location = new System.Drawing.Point(93, 9);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(168, 33);
            this.lblIngresar.TabIndex = 2;
            this.lblIngresar.Text = "Ingresar Lata";
            this.lblIngresar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstLatasIngreso
            // 
            this.lstLatasIngreso.FormattingEnabled = true;
            this.lstLatasIngreso.HorizontalScrollbar = true;
            this.lstLatasIngreso.ItemHeight = 16;
            this.lstLatasIngreso.Location = new System.Drawing.Point(12, 55);
            this.lstLatasIngreso.Name = "lstLatasIngreso";
            this.lstLatasIngreso.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstLatasIngreso.Size = new System.Drawing.Size(334, 180);
            this.lstLatasIngreso.TabIndex = 3;
            // 
            // btnApagarIngreso
            // 
            this.btnApagarIngreso.Location = new System.Drawing.Point(272, 439);
            this.btnApagarIngreso.Name = "btnApagarIngreso";
            this.btnApagarIngreso.Size = new System.Drawing.Size(75, 32);
            this.btnApagarIngreso.TabIndex = 8;
            this.btnApagarIngreso.Text = "Apagar";
            this.btnApagarIngreso.UseVisualStyleBackColor = true;
            this.btnApagarIngreso.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblCodigoMarca
            // 
            this.lblCodigoMarca.AutoSize = true;
            this.lblCodigoMarca.Location = new System.Drawing.Point(12, 256);
            this.lblCodigoMarca.Name = "lblCodigoMarca";
            this.lblCodigoMarca.Size = new System.Drawing.Size(186, 17);
            this.lblCodigoMarca.TabIndex = 9;
            this.lblCodigoMarca.Text = "Seleccione código de marca";
            // 
            // cmbTipoCodigo
            // 
            this.cmbTipoCodigo.FormattingEnabled = true;
            this.cmbTipoCodigo.Location = new System.Drawing.Point(200, 256);
            this.cmbTipoCodigo.Name = "cmbTipoCodigo";
            this.cmbTipoCodigo.Size = new System.Drawing.Size(146, 24);
            this.cmbTipoCodigo.TabIndex = 10;
            this.cmbTipoCodigo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCodigo_SelectedIndexChanged);
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(12, 328);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(112, 17);
            this.lblVolumen.TabIndex = 11;
            this.lblVolumen.Text = "Ingrese volumen";
            // 
            // txtVolumen
            // 
            this.txtVolumen.Location = new System.Drawing.Point(142, 328);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.Size = new System.Drawing.Size(205, 22);
            this.txtVolumen.TabIndex = 12;
            // 
            // lblPropiedades
            // 
            this.lblPropiedades.AutoSize = true;
            this.lblPropiedades.Location = new System.Drawing.Point(9, 369);
            this.lblPropiedades.Name = "lblPropiedades";
            this.lblPropiedades.Size = new System.Drawing.Size(179, 17);
            this.lblPropiedades.TabIndex = 13;
            this.lblPropiedades.Text = "Datos de la lata a ingresar:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(13, 399);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 17);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(105, 399);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 17);
            this.lblMarca.TabIndex = 15;
            this.lblMarca.Text = "Marca:";
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Location = new System.Drawing.Point(231, 399);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(50, 17);
            this.lblSabor.TabIndex = 16;
            this.lblSabor.Text = "Sabor:";
            // 
            // lblCodigoSabor
            // 
            this.lblCodigoSabor.AutoSize = true;
            this.lblCodigoSabor.Location = new System.Drawing.Point(12, 293);
            this.lblCodigoSabor.Name = "lblCodigoSabor";
            this.lblCodigoSabor.Size = new System.Drawing.Size(183, 17);
            this.lblCodigoSabor.TabIndex = 17;
            this.lblCodigoSabor.Text = "Seleccione código de sabor";
            this.lblCodigoSabor.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbTipoSabor
            // 
            this.cmbTipoSabor.FormattingEnabled = true;
            this.cmbTipoSabor.Location = new System.Drawing.Point(202, 293);
            this.cmbTipoSabor.Name = "cmbTipoSabor";
            this.cmbTipoSabor.Size = new System.Drawing.Size(144, 24);
            this.cmbTipoSabor.TabIndex = 18;
            this.cmbTipoSabor.SelectedIndexChanged += new System.EventHandler(this.cmbTipoSabor_SelectedIndexChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(132, 439);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(85, 32);
            this.btnIngresar.TabIndex = 19;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 439);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 32);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // frmIngresoLata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 480);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.cmbTipoSabor);
            this.Controls.Add(this.lblCodigoSabor);
            this.Controls.Add(this.lblSabor);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPropiedades);
            this.Controls.Add(this.txtVolumen);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.cmbTipoCodigo);
            this.Controls.Add(this.lblCodigoMarca);
            this.Controls.Add(this.btnApagarIngreso);
            this.Controls.Add(this.lstLatasIngreso);
            this.Controls.Add(this.lblIngresar);
            this.Name = "frmIngresoLata";
            this.Text = "Expendedora";
            this.Load += new System.EventHandler(this.frmIngresoLata_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.ListBox lstLatasIngreso;
        private System.Windows.Forms.Button btnApagarIngreso;
        private System.Windows.Forms.Label lblCodigoMarca;
        private System.Windows.Forms.ComboBox cmbTipoCodigo;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.Label lblPropiedades;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.Label lblCodigoSabor;
        private System.Windows.Forms.ComboBox cmbTipoSabor;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnVolver;
    }
}