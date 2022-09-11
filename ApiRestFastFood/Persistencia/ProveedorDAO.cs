using ApiRestFastFood.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestFastFood.Persistencia
{
    public class ProveedorDAO
    {
        private string cadenaconexion = "Data Source=LIM-BNFPPQ2\\SQLEXPRESS;initial catalog=BDProveedores;integrated security=True;";


        public List<Proveedor> listar()
        {
            List<Proveedor> ProveedorEncontrado = new List<Proveedor>();
            Proveedor proveedor = null;
            string sentencia = "SELECT * FROM Proveedor ";
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                { 
                    //ejecuta en la base de datos
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        //itera para recuperar el resultado
                        while (resultado.Read())
                        {
                            proveedor = new Proveedor
                            {
                                IdProveedor = (int)resultado["IdProveedor"],
                                Ruc = (string)resultado["Ruc"],
                                Razonsocial = (string)resultado["Razonsocial"],
                                DescripcionProductos = (string)resultado["DescripcionProductos"],
                                IdDepartamento = (string)resultado["IdDepartamento"],
                                IdProvincia = (string)resultado["IdProvincia"],
                                IdDistrito = (string)resultado["IdDistrito"],
                                IdSedeProveedor = (string)resultado["IdSedeProveedor"],
                                Direccion = (string)resultado["Direccion"],
                                RepNombre = (string)resultado["RepNombre"],
                                RepApellido = (string)resultado["RepApellido"],
                                UsuarioAtencion = (string)resultado["UsuarioAtencion"],
                                contrasenia = (string)resultado["contrasenia"],
                                Numerocelular = (string)resultado["Numerocelular"],
                                Email = (string)resultado["Email"],
                                IndAutorizaDato = (string)resultado["IndAutorizaDato"],
                                FechaCreacion = (DateTime?)resultado["FechaCreacion"],
                                UsuarioCreacion = (string)resultado["UsuarioCreacion"],
                                FechaModifacion = (DateTime?)resultado["FechaModifacion"],
                                UsuarioModificacion = (string)resultado["UsuarioModificacion"],
                                urlimg = (string)resultado["urlimg"],
                            };
                            ProveedorEncontrado.Add(proveedor);

                        }
                    }
                }


            }
            return ProveedorEncontrado;
        }

    }
}