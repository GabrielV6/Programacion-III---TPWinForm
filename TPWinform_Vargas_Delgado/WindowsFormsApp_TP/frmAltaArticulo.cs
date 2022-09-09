using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WindowsFormsApp_TP
{
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                articulo.Codigo = txbCodigo.Text;
                articulo.Nombre = txbNombre.Text;
                articulo.Descripcion = txbDescripcion.Text;

                articulo.marca = new Marca(); // Se crea el objeto.
                articulo.marca.Id = int.Parse(txbIdmarca.Text);

                articulo.categoria = new Categoria(); // Se crea el objeto.
                articulo.categoria.Id = int.Parse(txbIdcategoria.Text);
                
                articulo.ImagenUrl = txbURL.Text;
                articulo.Precio = Convert.ToDecimal(txbPrecio.Text);

                negocio.agregar(articulo);
                MessageBox.Show("Articulo agregado con exito");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
