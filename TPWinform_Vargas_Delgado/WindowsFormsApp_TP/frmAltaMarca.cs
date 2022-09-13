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
    public partial class frmAltaMarca : Form
    {
        public frmAltaMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                marca.DescripcionMarca = txbDescripcionmarca.Text;
                
                if (marca.DescripcionMarca == "" || marca.DescripcionMarca == null)
                {
                    MessageBox.Show("Debe ingresar una marca");
                    throw new Exception();
                }
                else
                {
                    negocio.agregar(marca);
                    MessageBox.Show("Marca agregada");
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

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                cboIdmarcaexistente.DataSource = negocio.listar();
                cboIdmarcaexistente.ValueMember = "Id";
                cboIdmarcaexistente.DisplayMember = "DescripcionMarca";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
