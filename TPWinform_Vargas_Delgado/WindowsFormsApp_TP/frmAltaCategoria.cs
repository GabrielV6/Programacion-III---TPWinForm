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
    public partial class frmAltaCategoria : Form
    {
        public frmAltaCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();
            
            try
            {
                categoria.Descripcion = txbDescripcioncategoria.Text;
                
                if (categoria.Descripcion == "" || categoria.Descripcion == null)
                {
                    MessageBox.Show("Debe ingresar una Categoria");
                    throw new Exception();
                }
                else
                {
                    negocio.agregar(categoria);
                    MessageBox.Show("Categoria Agregada");
                    this.Close();
                }

                Close();

            }
            catch (Exception ex)
            {
                DialogResult respuesta = MessageBox.Show("¿Desea intentar de nuevo?", "No es posible la operacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.No)
                {
                    Close();
                }
            }
        }

        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                cboIdcategoriaexistente.DataSource = negocio.listar();
                cboIdcategoriaexistente.ValueMember = "Id";
                cboIdcategoriaexistente.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

     
    }
}
