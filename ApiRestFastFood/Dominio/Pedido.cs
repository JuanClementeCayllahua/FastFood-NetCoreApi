using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ApiRestFastFood.Dominio
{
    [DataContract]
    public class Pedido
    {
        [DataMember] public string CodigoPedido { get; set; }
        [DataMember] public int IdProveedor { get; set; }
        [DataMember] public int IdCliente { get; set; }
        [DataMember] public decimal ImporteTot { get; set; }
        [DataMember] public DateTime FechaPedido { get; set; }
        [DataMember] public DateTime? FechaEntrega { get; set; }
        [DataMember] public string IdEstadoPedido { get; set; }
    }
}
