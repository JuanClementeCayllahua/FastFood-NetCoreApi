using ApiRestFastFood.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestFastFood.Persistencia
{
    public class ClienteDAO
    {
        private string cadenaconexion = "Data Source=(local);Initial Catalog=BDClientes;Integrated Security=SSPI;";

        public Cliente Agregar(Cliente cliente)
        {

            Cliente clientecreado = null;
            string sentencia = "";



            return cliente;
        }
        public Cliente obtener(int IdCliente)
        {
            Cliente clienteEncontrado = null;
            string sentencia = "SELECT * FROM Cliente where IdCliente = @IdCliente";
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {

                    comando.Parameters.Add(new SqlParameter("@IdCliente", IdCliente));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            clienteEncontrado = new Cliente
                            {
                                IdCliente = (int)resultado["IdCliente"],
                                Nombres = (string)resultado["Nombres"],
                                Apellidos = (string)resultado["Apellidos"],
                                TipoDocId = (string)resultado["TipoDocId"],
                                FechaNac = (DateTime?)resultado["FechaNac"],
                                Numerocelular = (string)resultado["Numerocelular"],
                                Email = (string)resultado["Email"],
                                Contrasenia = (string)resultado["Contrasenia"],
                                IdDepartamento = (string)resultado["IdDepartamento"],
                                IdProvincia = (string)resultado["IdProvincia"],
                                IdDistrito = (string)resultado["IdDistrito"],
                                Direccion = (string)resultado["Direccion"],
                                IndAutorizaDato = (string)resultado["IndAutorizaDato"],
                                FechaCreacion = (DateTime?)resultado["FechaCreacion"],
                                UsuarioCreacion = (string)resultado["UsuarioCreacion"],
                                FechaModifacion = (DateTime?)resultado["FechaModifacion"],
                                UsuarioModificacion = (string)resultado["UsuarioModificacion"],
                                numerodoc = (string)resultado["numerodoc"],
                                estado = (string)resultado["estado"]
                            };
                        }
                    }
                }

                return clienteEncontrado;
            }
        }
    }
}
//public Cliente Modificar(Cliente clienteMod)
//{


//    return clienteMod;
//}
//public void Eliminar(int IdCliente)
//{

//}
//public List<Cliente> Listar()
//{
//    List<Cliente> clientes = null;


//    return clientes;

//} 

