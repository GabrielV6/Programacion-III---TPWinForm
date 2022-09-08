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

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            

            try
            {
                conexion.ConnectionString = "Data Source = .; Initial Catalog=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Codigo, A.Nombre Telefono, A.Descripcion,A.Precio,A.ImagenUrl, M.Descripcion Modelo , C.Descripcion Tipo FROM ARTICULOS A, MARCAS M , CATEGORIAS C WHERE A.IdMarca = M.id AND A.IdCategoria = C.Id";
                comando.Connection = conexion;
                
                conexion.Open();
                lector = comando.ExecuteReader();
                
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    //aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Telefono"];
                    aux.Descripcion = (string)lector["Descripcion"];              
                    aux.Precio = (decimal)lector["Precio"];
                    aux.ImagenUrl = (string)lector["ImagenURL"];

                    aux.marca = new Marca();
                    aux.marca.DescripcionMarca = (string)lector["Modelo"];

                    aux.categoria = new Categoria();
                    aux.categoria.Descripcion = (string)lector["Tipo"];

                    

                    lista.Add(aux);
                    

                }


                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            
        }
    }
}
