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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.lblPropiedades = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblSabor = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
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
            this.btnApagarIngreso.Location = new System.Drawing.Point(272, 396);
            this.btnApagarIngreso.Name = "btnApagarIngreso";
            this.btnApagarIngreso.Size = new System.Drawing.Size(75, 32);
            this.btnApagarIngreso.TabIndex = 8;
            this.btnApagarIngreso.Text = "Apagar";
            this.btnApagarIngreso.UseVisualStyleBackColor = true;
            this.btnApagarIngreso.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 256);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(123, 17);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Seleccione código";
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(13, 294);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(112, 17);
            this.lblVolumen.TabIndex = 11;
            this.lblVolumen.Text = "Ingrese volumen";
            // 
            // txtVolumen
            // 
            this.txtVolumen.Location = new System.Drawing.Point(141, 294);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.Size = new System.Drawing.Size(205, 22);
            this.txtVolumen.TabIndex = 12;
            // 
            // lblPropiedades
            // 
            this.lblPropiedades.AutoSize = true;
            this.lblPropiedades.Location = new System.Drawing.Point(9, 333);
            this.lblPropiedades.Name = "lblPropiedades";
            this.lblPropiedades.Size = new System.Drawing.Size(179, 17);
            this.lblPropiedades.TabIndex = 13;
            this.lblPropiedades.Text = "Datos de la lata a ingresar:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(13, 360);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 17);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(96, 360);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 17);
            this.lblMarca.TabIndex = 15;
            this.lblMarca.Text = "Marca:";
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Location = new System.Drawing.Point(222, 360);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(50, 17);
            this.lblSabor.TabIndex = 16;
            this.lblSabor.Text = "Sabor:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(141, 396);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(85, 32);
            this.btnIngresar.TabIndex = 19;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 396);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 32);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(141, 256);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(205, 24);
            this.cmbCodigo.TabIndex = 10;
            this.cmbCodigo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCodigo_SelectedIndexChanged);
            // 
            // frmIngresoLata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 440);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblSabor);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPropiedades);
            this.Controls.Add(this.txtVolumen);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.cmbCodigo);
            this.Controls.Add(this.lblCodigo);
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
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.Label lblPropiedades;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cmbCodigo;
    }
}