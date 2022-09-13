namespace WindowsFormsApp_TP
{
    partial class frmAltaCategoria
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
            this.cboIdcategoriaexistente = new System.Windows.Forms.ComboBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txbDescripcioncategoria = new System.Windows.Forms.TextBox();
            this.lbIdcategoriaExistente = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboIdcategoriaexistente
            // 
            this.cboIdcategoriaexistente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdcategoriaexistente.FormattingEnabled = true;
            this.cboIdcategoriaexistente.Location = new System.Drawing.Point(651, 72);
            this.cboIdcategoriaexistente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboIdcategoriaexistente.Name = "cboIdcategoriaexistente";
            this.cboIdcategoriaexistente.Size = new System.Drawing.Size(199, 24);
            this.cboIdcategoriaexistente.TabIndex = 36;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTitulo.Location = new System.Drawing.Point(4, 17);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(160, 31);
            this.lbTitulo.TabIndex = 40;
            this.lbTitulo.Text = "Registration";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(375, 127);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 31);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(259, 127);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 31);
            this.btnAceptar.TabIndex = 38;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txbDescripcioncategoria
            // 
            this.txbDescripcioncategoria.Location = new System.Drawing.Point(261, 74);
            this.txbDescripcioncategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDescripcioncategoria.Name = "txbDescripcioncategoria";
            this.txbDescripcioncategoria.Size = new System.Drawing.Size(199, 22);
            this.txbDescripcioncategoria.TabIndex = 35;
            this.txbDescripcioncategoria.Tag = "";
            // 
            // lbIdcategoriaExistente
            // 
            this.lbIdcategoriaExistente.AutoSize = true;
            this.lbIdcategoriaExistente.Location = new System.Drawing.Point(491, 80);
            this.lbIdcategoriaExistente.Name = "lbIdcategoriaExistente";
            this.lbIdcategoriaExistente.Size = new System.Drawing.Size(137, 16);
            this.lbIdcategoriaExistente.TabIndex = 37;
            this.lbIdcategoriaExistente.Text = "Categorias Existentes";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(33, 81);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(214, 16);
            this.lblDescripcion.TabIndex = 34;
            this.lblDescripcion.Text = "Descripcion de la nueva Categoria";
            // 
            // frmAltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 186);
            this.Controls.Add(this.cboIdcategoriaexistente);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txbDescripcioncategoria);
            this.Controls.Add(this.lbIdcategoriaExistente);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "frmAltaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altas de Categorias";
            this.Load += new System.EventHandler(this.frmAltaCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboIdcategoriaexistente;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txbDescripcioncategoria;
        private System.Windows.Forms.Label lbIdcategoriaExistente;
        private System.Windows.Forms.Label lblDescripcion;
    }
}