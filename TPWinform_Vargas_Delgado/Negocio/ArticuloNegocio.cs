using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using Dominio; //se referencia el proyecto

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            

            try
            {
                datos.setearConsulta("SELECT A.Codigo, A.Nombre Telefono, A.Descripcion,A.Precio,A.ImagenUrl, M.Descripcion Modelo , C.Descripcion Tipo FROM ARTICULOS A, MARCAS M , CATEGORIAS C WHERE A.IdMarca = M.id AND A.IdCategoria = C.Id");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    //aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Telefono"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];              
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenURL"];

                    aux.marca = new Marca();
                    aux.marca.DescripcionMarca = (string)datos.Lector["Modelo"];

                    aux.categoria = new Categoria();
                    aux.categoria.Descripcion = (string)datos.Lector["Tipo"];


                    lista.Add(aux);
                    

                }
              
                return lista;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            
        }

        // Posee la sentencia SQL para generar el INSERT desde el metodo alojado en la clase AccesoDatos
        public void agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                string valores = "values('" + articulo.Codigo + "','" + articulo.Nombre + "','" + articulo.Descripcion + "'," + articulo.Precio + ",'" + articulo.ImagenUrl + " ', " + articulo.marca.Id + ", " + articulo.categoria.Id + ")";
                datos.setearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,Precio,ImagenURL, IdMarca, IdCategoria) " + valores);
                

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
          
            
        }

        public void modificar(Articulo articulo)
        {

        }
    }
}


