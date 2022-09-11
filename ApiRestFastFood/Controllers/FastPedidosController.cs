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
    [Route("api/[controller]")]
    [ApiController]
    public class FastPedidosController : ControllerBase
    {

        private PedidoDAO pedidoDAO = new PedidoDAO();
        // GET: api/FastPedidos
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/FastPedidos/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/FastPedidos
        [HttpPost]
        public Pedido Post([FromBody] Pedido pedido)
        {
            Pedido objnew = new Pedido();
            objnew = pedido;
            objnew.FechaEntrega = DateTime.Now;
            objnew.FechaPedido = DateTime.Now;

            Pedido obj = pedidoDAO.Agregar(pedido);


            return obj;
        }
        // PUT: api/FastPedidos/5
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
