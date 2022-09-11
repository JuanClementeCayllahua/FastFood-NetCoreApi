using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestFastFood.Dominio;
using ApiRestFastFood.Persistencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiRestFastFood.Controllers
{
    [Route("api/v1/products")]
    [ApiController]
    public class FastProductosController : ControllerBase
    {

        private ProductosProveedorDAO proveedorDAO = new ProductosProveedorDAO();

        // GET: api/FastProductos
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/FastProductos/5
        [HttpGet("{id}", Name = "GetProducto")]
        public List<ProductosProveedor> Get(int id)
        {
            List<ProductosProveedor> productosProveedors = proveedorDAO.obtener(id);

            return productosProveedors;
        }

        // POST: api/FastProductos
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/FastProductos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
