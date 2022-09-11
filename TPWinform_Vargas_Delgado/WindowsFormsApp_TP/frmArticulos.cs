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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp_TP
{
    public partial class frmArticulo : Form
    {
        private List<Articulo> listaArticulos;
        
        public frmArticulo()
        {
            InitializeComponent();
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            dgvArticulo.DataSource = listaArticulos;
            dgvArticulo.Columns["ImagenURL"].Visible = false; // para no ver la URL
            dgvArticulo.Columns["Id"].Visible = false;
            cargarImagen(listaArticulos[0].ImagenUrl);
            
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
        }

        //metodo para imagenes sin url
        
        private void cargarImagen(string imagen)
        {
            try
            {
                pbArticulos.Load(imagen);
            }
            catch (Exception)
            {

                pbArticulos.Load("https://th.bing.com/th/id/R.5f8b98acd656c6d261777d035c50a112?rik=9e0Xk%2brW5WO0Yg&riu=http%3a%2f%2fimg2.wikia.nocookie.net%2f__cb20140518072131%2ftowerofsaviors%2fimages%2f4%2f47%2fPlaceholder.png&ehk=CZAAxtW4x95yvm5bFj%2fqN8pJu9M9F1JW8H5KVFRhKnk%3d&risl=&pid=ImgRaw&r=0");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            //cargar();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Confirma la eliminacion del articulo seleccionado? ", "Eliminando articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes) 
                {
                    seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    // cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
