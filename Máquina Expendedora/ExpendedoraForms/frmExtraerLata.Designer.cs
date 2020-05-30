namespace ExpendedoraForms
{
    partial class frmExtraerLata
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
            this.lblExtraerLata = new System.Windows.Forms.Label();
            this.lstExtraerLata = new System.Windows.Forms.ListBox();
            this.lblCodigoEx = new System.Windows.Forms.Label();
            this.cmbCodigoEx = new System.Windows.Forms.ComboBox();
            this.lblDinero = new System.Windows.Forms.Label();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnVolverEx = new System.Windows.Forms.Button();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.lblSaborEx = new System.Windows.Forms.Label();
            this.lblMarcaEx = new System.Windows.Forms.Label();
            this.lblPrecioEx = new System.Windows.Forms.Label();
            this.btnApagarEx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExtraerLata
            // 
            this.lblExtraerLata.AutoSize = true;
            this.lblExtraerLata.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraerLata.Location = new System.Drawing.Point(96, 9);
            this.lblExtraerLata.Name = "lblExtraerLata";
            this.lblExtraerLata.Size = new System.Drawing.Size(155, 33);
            this.lblExtraerLata.TabIndex = 2;
            this.lblExtraerLata.Text = "Extraer Lata";
            this.lblExtraerLata.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstExtraerLata
            // 
            this.lstExtraerLata.FormattingEnabled = true;
            this.lstExtraerLata.HorizontalScrollbar = true;
            this.lstExtraerLata.ItemHeight = 16;
            this.lstExtraerLata.Location = new System.Drawing.Point(12, 55);
            this.lstExtraerLata.Name = "lstExtraerLata";
            this.lstExtraerLata.Size = new System.Drawing.Size(334, 180);
            this.lstExtraerLata.TabIndex = 3;
            this.lstExtraerLata.SelectedIndexChanged += new System.EventHandler(this.lstExtraerLata_SelectedIndexChanged);
            // 
            // lblCodigoEx
            // 
            this.lblCodigoEx.AutoSize = true;
            this.lblCodigoEx.Location = new System.Drawing.Point(12, 258);
            this.lblCodigoEx.Name = "lblCodigoEx";
            this.lblCodigoEx.Size = new System.Drawing.Size(123, 17);
            this.lblCodigoEx.TabIndex = 4;
            this.lblCodigoEx.Text = "Seleccione código";
            // 
            // cmbCodigoEx
            // 
            this.cmbCodigoEx.FormattingEnabled = true;
            this.cmbCodigoEx.Location = new System.Drawing.Point(142, 258);
            this.cmbCodigoEx.Name = "cmbCodigoEx";
            this.cmbCodigoEx.Size = new System.Drawing.Size(204, 24);
            this.cmbCodigoEx.TabIndex = 5;
            this.cmbCodigoEx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Location = new System.Drawing.Point(12, 292);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(115, 17);
            this.lblDinero.TabIndex = 6;
            this.lblDinero.Text = "Ingrese dinero: $";
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(142, 292);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(204, 22);
            this.txtDinero.TabIndex = 7;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(12, 330);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(96, 17);
            this.lblDatos.TabIndex = 14;
            this.lblDatos.Text = "Lata a extraer";
            // 
            // btnVolverEx
            // 
            this.btnVolverEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverEx.Location = new System.Drawing.Point(11, 404);
            this.btnVolverEx.Name = "btnVolverEx";
            this.btnVolverEx.Size = new System.Drawing.Size(75, 32);
            this.btnVolverEx.TabIndex = 26;
            this.btnVolverEx.Text = "< Volver";
            this.btnVolverEx.UseVisualStyleBackColor = true;
            this.btnVolverEx.Click += new System.EventHandler(this.btnVolverEx_Click);
            // 
            // btnExtraer
            // 
            this.btnExtraer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraer.Location = new System.Drawing.Point(131, 404);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(85, 32);
            this.btnExtraer.TabIndex = 25;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // lblSaborEx
            // 
            this.lblSaborEx.AutoSize = true;
            this.lblSaborEx.Location = new System.Drawing.Point(221, 359);
            this.lblSaborEx.Name = "lblSaborEx";
            this.lblSaborEx.Size = new System.Drawing.Size(50, 17);
            this.lblSaborEx.TabIndex = 24;
            this.lblSaborEx.Text = "Sabor:";
            // 
            // lblMarcaEx
            // 
            this.lblMarcaEx.AutoSize = true;
            this.lblMarcaEx.Location = new System.Drawing.Point(99, 359);
            this.lblMarcaEx.Name = "lblMarcaEx";
            this.lblMarcaEx.Size = new System.Drawing.Size(51, 17);
            this.lblMarcaEx.TabIndex = 23;
            this.lblMarcaEx.Text = "Marca:";
            // 
            // lblPrecioEx
            // 
            this.lblPrecioEx.AutoSize = true;
            this.lblPrecioEx.Location = new System.Drawing.Point(12, 359);
            this.lblPrecioEx.Name = "lblPrecioEx";
            this.lblPrecioEx.Size = new System.Drawing.Size(52, 17);
            this.lblPrecioEx.TabIndex = 22;
            this.lblPrecioEx.Text = "Precio:";
            // 
            // btnApagarEx
            // 
            this.btnApagarEx.Location = new System.Drawing.Point(271, 404);
            this.btnApagarEx.Name = "btnApagarEx";
            this.btnApagarEx.Size = new System.Drawing.Size(75, 32);
            this.btnApagarEx.TabIndex = 21;
            this.btnApagarEx.Text = "Apagar";
            this.btnApagarEx.UseVisualStyleBackColor = true;
            this.btnApagarEx.Click += new System.EventHandler(this.btnApagarEx_Click);
            // 
            // frmExtraerLata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.btnVolverEx);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.lblSaborEx);
            this.Controls.Add(this.lblMarcaEx);
            this.Controls.Add(this.lblPrecioEx);
            this.Controls.Add(this.btnApagarEx);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.txtDinero);
            this.Controls.Add(this.lblDinero);
            this.Controls.Add(this.cmbCodigoEx);
            this.Controls.Add(this.lblCodigoEx);
            this.Controls.Add(this.lstExtraerLata);
            this.Controls.Add(this.lblExtraerLata);
            this.Name = "frmExtraerLata";
            this.Text = "Expendedora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExtraerLata_FormClosing);
            this.Load += new System.EventHandler(this.frmExtraerLata_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExtraerLata;
        private System.Windows.Forms.ListBox lstExtraerLata;
        private System.Windows.Forms.Label lblCodigoEx;
        private System.Windows.Forms.ComboBox cmbCodigoEx;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnVolverEx;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Label lblSaborEx;
        private System.Windows.Forms.Label lblMarcaEx;
        private System.Windows.Forms.Label lblPrecioEx;
        private System.Windows.Forms.Button btnApagarEx;
    }
}