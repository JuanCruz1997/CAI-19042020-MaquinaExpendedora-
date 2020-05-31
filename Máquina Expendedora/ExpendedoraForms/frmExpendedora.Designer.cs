namespace ExpendedoraForms
{
    partial class frmExpendedora
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
            this.lblTituloOpciones = new System.Windows.Forms.Label();
            this.lstLatas = new System.Windows.Forms.ListBox();
            this.btnIngresarLata = new System.Windows.Forms.Button();
            this.btnExtraerLata = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloOpciones
            // 
            this.lblTituloOpciones.AutoSize = true;
            this.lblTituloOpciones.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloOpciones.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloOpciones.ForeColor = System.Drawing.Color.White;
            this.lblTituloOpciones.Location = new System.Drawing.Point(55, 9);
            this.lblTituloOpciones.Name = "lblTituloOpciones";
            this.lblTituloOpciones.Size = new System.Drawing.Size(234, 35);
            this.lblTituloOpciones.TabIndex = 1;
            this.lblTituloOpciones.Text = "¿Qué desea hacer?";
            this.lblTituloOpciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstLatas
            // 
            this.lstLatas.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLatas.FormattingEnabled = true;
            this.lstLatas.HorizontalScrollbar = true;
            this.lstLatas.ItemHeight = 21;
            this.lstLatas.Location = new System.Drawing.Point(12, 55);
            this.lstLatas.Name = "lstLatas";
            this.lstLatas.Size = new System.Drawing.Size(334, 172);
            this.lstLatas.TabIndex = 2;
            this.lstLatas.SelectedIndexChanged += new System.EventHandler(this.lstLatas_SelectedIndexChanged);
            // 
            // btnIngresarLata
            // 
            this.btnIngresarLata.BackColor = System.Drawing.Color.White;
            this.btnIngresarLata.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarLata.ForeColor = System.Drawing.Color.Red;
            this.btnIngresarLata.Location = new System.Drawing.Point(13, 241);
            this.btnIngresarLata.Name = "btnIngresarLata";
            this.btnIngresarLata.Size = new System.Drawing.Size(333, 35);
            this.btnIngresarLata.TabIndex = 3;
            this.btnIngresarLata.Text = "Ingresar Lata";
            this.btnIngresarLata.UseVisualStyleBackColor = false;
            this.btnIngresarLata.Click += new System.EventHandler(this.btnIngresarLata_Click);
            // 
            // btnExtraerLata
            // 
            this.btnExtraerLata.BackColor = System.Drawing.Color.White;
            this.btnExtraerLata.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraerLata.ForeColor = System.Drawing.Color.Red;
            this.btnExtraerLata.Location = new System.Drawing.Point(12, 282);
            this.btnExtraerLata.Name = "btnExtraerLata";
            this.btnExtraerLata.Size = new System.Drawing.Size(333, 35);
            this.btnExtraerLata.TabIndex = 4;
            this.btnExtraerLata.Text = "Extraer Lata";
            this.btnExtraerLata.UseVisualStyleBackColor = false;
            this.btnExtraerLata.Click += new System.EventHandler(this.btnExtraerLata_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.BackColor = System.Drawing.Color.White;
            this.btnBalance.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.ForeColor = System.Drawing.Color.Red;
            this.btnBalance.Location = new System.Drawing.Point(12, 323);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(333, 35);
            this.btnBalance.TabIndex = 5;
            this.btnBalance.Text = "Ver Balance";
            this.btnBalance.UseVisualStyleBackColor = false;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.White;
            this.btnStock.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.Red;
            this.btnStock.Location = new System.Drawing.Point(12, 364);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(333, 35);
            this.btnStock.TabIndex = 6;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.White;
            this.btnApagar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(13, 406);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 32);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // frmExpendedora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExpendedoraForms.Properties.Resources.unnamed__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnExtraerLata);
            this.Controls.Add(this.btnIngresarLata);
            this.Controls.Add(this.lstLatas);
            this.Controls.Add(this.lblTituloOpciones);
            this.Name = "frmExpendedora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expendedora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExpendedora_FormClosing);
            this.Load += new System.EventHandler(this.frmExpendedora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloOpciones;
        private System.Windows.Forms.ListBox lstLatas;
        private System.Windows.Forms.Button btnIngresarLata;
        private System.Windows.Forms.Button btnExtraerLata;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnApagar;
    }
}