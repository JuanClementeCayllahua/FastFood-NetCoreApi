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
    //[Route("api/[controller]")]
    [Route("api/v1/providers")]
    [ApiController]
    public class ProveedoresController : ControllerBase
    {
        private ProveedorDAO proveedorDao = new ProveedorDAO();
        // GET: api/Proveedores
        //[HttpGet]
        public List<Proveedor> Get()
        {

            List<Proveedor> proveedores = proveedorDao.listar();


            return proveedores;
        }

        // GET: api/Proveedores/5
        [HttpGet("{id}", Name = "GetProveedores")]

        public IEnumerable<string> GetProveedores(int id)
        {
            return new string[] { "value1", "value2" };
        }

        // POST: api/Proveedores
        [HttpPost]
        public void pPost([FromBody] string value)
        {
        }

        // PUT: api/Proveedores/5
        //[HttpPut("{id}")]
        //public void pPut(int id, [FromBody] string value)
        //{
        //}

        // DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void pDelete(int id)
        //{
        //}
    }
}
