using ApiRestFastFood.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestFastFood.Persistencia
{
    public class ProductosProveedorDAO
    {
        private string cadenaconexion = "Data Source=LIM-BNFPPQ2\\SQLEXPRESS;initial catalog=BDProveedores;integrated security=True;";

        //public ProductosProveedor Agregar(ProductosProveedor ProductosProveedorFastFood)
        //{

        //    ProductosProveedor ProductosProveedorcreado = null;
        //    string sentencia = "Insert into ProductosProveedor (IdProducto,IdProveedor,NombreProducto,DescrProducto,precio,cantidadproducto,EstadoReg,urlimg)values(@IdProducto,@IdProveedor,@NombreProducto,@DescrProducto,@precio,@cantidadproducto,@EstadoReg,@urlimg)";
        //    using (SqlConnection conexion = new SqlConnection(cadenaconexion))
        //    {
        //        conexion.Open();
        //        using (SqlCommand comando = new SqlCommand(sentencia, conexion))
        //        {

        //            comando.Parameters.Add(new SqlParameter("@IdProducto", ProductosProveedorFastFood.IdProducto));
        //            comando.Parameters.Add(new SqlParameter("@IdProveedor", ProductosProveedorFastFood.IdProveedor));
        //            comando.Parameters.Add(new SqlParameter("@NombreProducto", ProductosProveedorFastFood.NombreProducto));
        //            comando.Parameters.Add(new SqlParameter("@DescrProducto", ProductosProveedorFastFood.DescrProducto));
        //            comando.Parameters.Add(new SqlParameter("@precio", ProductosProveedorFastFood.precio));
        //            comando.Parameters.Add(new SqlParameter("@cantidadproducto", ProductosProveedorFastFood.cantidadproducto));
        //            comando.Parameters.Add(new SqlParameter("@EstadoReg", ProductosProveedorFastFood.EstadoReg));
        //            comando.Parameters.Add(new SqlParameter("@urlimg", ProductosProveedorFastFood.urlimg));
        //            comando.ExecuteNonQuery();
        //        }
        //    }
        //    ProductosProveedorcreado = obtener(ProductosProveedorFastFood.IdProducto);


        //    return ProductosProveedorcreado;
        //}
        //public ProductosProveedor Modificar(ProductosProveedor ProductosProveedorFastFood)
        //{
        //    ProductosProveedor ProductosProveedorModificado = null;
        //    string sentencia = "Update ProductosProveedorFastFood " +
        //        "set IdCliente=@IdCliente," +
        //        "ImporteTot=@ImporteTot," +
        //        "FechaProductosProveedor =@FechaProductosProveedor ," +
        //        "FechaEntrega=@FechaEntrega," +
        //        "IdEstadoProductosProveedor=@IdEstadoProductosProveedor" +
        //        "where IdProveedor=@IdProveedor";

        //    using (SqlConnection conexion = new SqlConnection(cadenaconexion))
        //    {
        //        conexion.Open();
        //        using (SqlCommand comando = new SqlCommand(sentencia, conexion))
        //        {

        //            comando.Parameters.Add(new SqlParameter("@IdProducto", ProductosProveedorFastFood.IdProducto));
        //            comando.Parameters.Add(new SqlParameter("@IdProveedor", ProductosProveedorFastFood.IdProveedor));
        //            comando.Parameters.Add(new SqlParameter("@NombreProducto", ProductosProveedorFastFood.NombreProducto));
        //            comando.Parameters.Add(new SqlParameter("@DescrProducto", ProductosProveedorFastFood.DescrProducto));
        //            comando.Parameters.Add(new SqlParameter("@precio", ProductosProveedorFastFood.precio));
        //            comando.Parameters.Add(new SqlParameter("@cantidadproducto", ProductosProveedorFastFood.cantidadproducto));
        //            comando.Parameters.Add(new SqlParameter("@EstadoReg", ProductosProveedorFastFood.EstadoReg));
        //            comando.Parameters.Add(new SqlParameter("@urlimg", ProductosProveedorFastFood.urlimg));
        //            comando.ExecuteNonQuery();
        //        }
        //    }
        //    ProductosProveedorModificado = obtener(ProductosProveedorModificado.IdProducto);
        //    return ProductosProveedorModificado;

        //}

        public List<ProductosProveedor> listarproductoxProveedor(int idProveedor, int idProducto)
        {
            List<ProductosProveedor> productosProveedors = obtener(idProveedor);
            productosProveedors = productosProveedors.Where(x => x.IdProducto == idProducto).ToList();


            return productosProveedors;
        }

        public List<ProductosProveedor> obtener(int idProveedor)
        {
            List<ProductosProveedor> productosProveedors = new List<ProductosProveedor>();
            ProductosProveedor productosencontrados = null;
            string sentencia = "SELECT * FROM ProductosProveedor where IdProveedor = @idProveedor";
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {

                    comando.Parameters.Add(new SqlParameter("@idProveedor", idProveedor));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            productosencontrados = new ProductosProveedor
                            {
                                IdProducto = (int)resultado["IdProducto"],
                                IdProveedor = (int)resultado["IdProveedor"],
                                NombreProducto = (string)resultado["NombreProducto"],
                                DescrProducto = (string)resultado["DescrProducto"],
                                precio = (decimal)resultado["precio"],
                                cantidadproducto = (int)resultado["cantidadproducto"],
                                EstadoReg = (string)resultado["EstadoReg"],
                                urlimg = (string)resultado["urlimg"],
                            };

                            productosProveedors.Add(productosencontrados);
                        }
                    }
                }


            }
            return productosProveedors;
        }
        public void Eliminar(string codigo)
        {
            string sentencia1 = "DELETE FROM ProductosProveedor where CodigoProductosProveedor = @CodigoProductosProveedor";
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sentencia1, conexion))
                {

                    comando.Parameters.Add(new SqlParameter("@CodigoProductosProveedor", codigo));
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
