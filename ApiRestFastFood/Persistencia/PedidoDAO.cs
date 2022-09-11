using ApiRestFastFood.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestFastFood.Persistencia
{
    public class PedidoDAO
    {

        private string cadenaconexion = "Data Source=LIM-BNFPPQ2\\SQLEXPRESS;initial catalog=BDPedidosFastFood;integrated security=True;";

        public Pedido Agregar(Pedido PedidoFastFood)
        {

            Pedido Pedidocreado = null;
            string sentencia = "Insert into PedidoFastFood (CodigoPedido,IdProveedor,IdCliente,ImporteTot,FechaPedido ,FechaEntrega,IdEstadoPedido)values(@CodigoPedido,@IdProveedor,@IdCliente,@ImporteTot,@FechaPedido ,@FechaEntrega,@IdEstadoPedido)";
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {

                    comando.Parameters.Add(new SqlParameter("@CodigoPedido", PedidoFastFood.CodigoPedido));
                    comando.Parameters.Add(new SqlParameter("@IdProveedor", PedidoFastFood.IdProveedor));
                    comando.Parameters.Add(new SqlParameter("@IdCliente", PedidoFastFood.IdCliente));
                    comando.Parameters.Add(new SqlParameter("@ImporteTot", PedidoFastFood.ImporteTot));
                    comando.Parameters.Add(new SqlParameter("@FechaPedido", PedidoFastFood.FechaPedido));
                    comando.Parameters.Add(new SqlParameter("@FechaEntrega", PedidoFastFood.FechaEntrega));
                    comando.Parameters.Add(new SqlParameter("@IdEstadoPedido", PedidoFastFood.IdEstadoPedido));
                    comando.ExecuteNonQuery();
                }
            }
            Pedidocreado = obtener(PedidoFastFood.CodigoPedido);


            return Pedidocreado;
        }
        public Pedido Modificar(Pedido PedidoFastFood)
        {
            Pedido pedidoModificado = null;
            string sentencia = "Update PedidoFastFood " +
                "set IdCliente=@IdCliente," +
                "ImporteTot=@ImporteTot," +
                "FechaPedido =@FechaPedido ," +
                "FechaEntrega=@FechaEntrega," +
                "IdEstadoPedido=@IdEstadoPedido" +
                "where IdProveedor=@IdProveedor";

            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {

                    comando.Parameters.Add(new SqlParameter("@CodigoPedido", PedidoFastFood.CodigoPedido));
                    comando.Parameters.Add(new SqlParameter("@IdProveedor", PedidoFastFood.IdProveedor));
                    comando.Parameters.Add(new SqlParameter("@IdCliente", PedidoFastFood.IdCliente));
                    comando.Parameters.Add(new SqlParameter("@ImporteTot", PedidoFastFood.ImporteTot));
                    comando.Parameters.Add(new SqlParameter("@FechaPedido", PedidoFastFood.FechaPedido));
                    comando.Parameters.Add(new SqlParameter("@FechaEntrega", PedidoFastFood.FechaEntrega));
                    comando.Parameters.Add(new SqlParameter("@IdEstadoPedido", PedidoFastFood.IdEstadoPedido));
                    comando.ExecuteNonQuery();
                }
            }
            pedidoModificado = obtener(pedidoModificado.CodigoPedido);
            return pedidoModificado;

        }
        public Pedido obtener(string IdPedido)
        {
            Pedido PedidoEncontrado = null;
            string sentencia = "SELECT * FROM PedidoFastFood where CodigoPedido = @CodigoPedido";
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {

                    comando.Parameters.Add(new SqlParameter("@CodigoPedido", IdPedido));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            PedidoEncontrado = new Pedido
                            {
                                CodigoPedido = (string)resultado["CodigoPedido"],
                                IdProveedor = (int)resultado["IdProveedor"],
                                IdCliente = (int)resultado["IdCliente"],
                                ImporteTot = (decimal)resultado["ImporteTot"],
                                FechaPedido = (DateTime)resultado["FechaPedido"],
                                FechaEntrega = (DateTime?)resultado["FechaEntrega"],
                                IdEstadoPedido = (string)resultado["IdEstadoPedido"]
                            };
                        }
                    }
                }


            }
            return PedidoEncontrado;
        }
        public void Eliminar(string codigo)
        {
            string sentencia1 = "DELETE FROM Pedido where CodigoPedido = @CodigoPedido";
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sentencia1, conexion))
                {

                    comando.Parameters.Add(new SqlParameter("@CodigoPedido", codigo));
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
