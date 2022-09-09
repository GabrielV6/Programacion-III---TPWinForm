namespace WindowsFormsApp_TP
{
    partial class frmAltaArticulo
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
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbIdmarca = new System.Windows.Forms.Label();
            this.lbIdcategoria = new System.Windows.Forms.Label();
            this.lbURL = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbURL = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.cboIdmarca = new System.Windows.Forms.ComboBox();
            this.cboIdcategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(70, 73);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(51, 16);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Codigo";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(65, 115);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(56, 16);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(42, 153);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lbDescripcion.TabIndex = 2;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // lbIdmarca
            // 
            this.lbIdmarca.AutoSize = true;
            this.lbIdmarca.Location = new System.Drawing.Point(60, 193);
            this.lbIdmarca.Name = "lbIdmarca";
            this.lbIdmarca.Size = new System.Drawing.Size(61, 16);
            this.lbIdmarca.TabIndex = 3;
            this.lbIdmarca.Text = "ID Marca";
            // 
            // lbIdcategoria
            // 
            this.lbIdcategoria.AutoSize = true;
            this.lbIdcategoria.Location = new System.Drawing.Point(39, 231);
            this.lbIdcategoria.Name = "lbIdcategoria";
            this.lbIdcategoria.Size = new System.Drawing.Size(82, 16);
            this.lbIdcategoria.TabIndex = 4;
            this.lbIdcategoria.Text = "ID Categoria";
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(39, 270);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(82, 16);
            this.lbURL.TabIndex = 5;
            this.lbURL.Text = "URL Imagen";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(75, 307);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(46, 16);
            this.lbPrecio.TabIndex = 6;
            this.lbPrecio.Text = "Precio";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(146, 67);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(198, 22);
            this.txbCodigo.TabIndex = 7;
            this.txbCodigo.Tag = "";
            this.txbCodigo.Text = "EJ: SE01";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(146, 109);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(198, 22);
            this.txbNombre.TabIndex = 8;
            this.txbNombre.Text = "EJ: Apple watch";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(146, 150);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(198, 22);
            this.txbDescripcion.TabIndex = 9;
            // 
            // txbURL
            // 
            this.txbURL.Location = new System.Drawing.Point(146, 264);
            this.txbURL.Name = "txbURL";
            this.txbURL.Size = new System.Drawing.Size(198, 22);
            this.txbURL.TabIndex = 12;
            this.txbURL.Text = "EJ: https://th.bing.com/th/id/OIP.32sWvnVmrzuLUCb0FVqAjgHaHa?pid=ImgDet&rs=1";
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(146, 301);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(198, 22);
            this.txbPrecio.TabIndex = 13;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(146, 369);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(269, 369);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(128, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(216, 25);
            this.lbTitulo.TabIndex = 16;
            this.lbTitulo.Text = "ALTA DE ARTICULOS";
            // 
            // cboIdmarca
            // 
            this.cboIdmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdmarca.FormattingEnabled = true;
            this.cboIdmarca.Location = new System.Drawing.Point(146, 185);
            this.cboIdmarca.Name = "cboIdmarca";
            this.cboIdmarca.Size = new System.Drawing.Size(198, 24);
            this.cboIdmarca.TabIndex = 17;
            // 
            // cboIdcategoria
            // 
            this.cboIdcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdcategoria.FormattingEnabled = true;
            this.cboIdcategoria.Location = new System.Drawing.Point(146, 223);
            this.cboIdcategoria.Name = "cboIdcategoria";
            this.cboIdcategoria.Size = new System.Drawing.Size(198, 24);
            this.cboIdcategoria.TabIndex = 18;
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 410);
            this.Controls.Add(this.cboIdcategoria);
            this.Controls.Add(this.cboIdmarca);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbURL);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.lbIdcategoria);
            this.Controls.Add(this.lbIdmarca);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCodigo);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbIdmarca;
        private System.Windows.Forms.Label lbIdcategoria;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ComboBox cboIdmarca;
        private System.Windows.Forms.ComboBox cboIdcategoria;
    }
}