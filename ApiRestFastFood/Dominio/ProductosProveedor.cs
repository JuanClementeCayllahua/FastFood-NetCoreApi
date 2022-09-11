using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ApiRestFastFood.Dominio
{
    [DataContract]
    public class ProductosProveedor
    {
        [DataMember] public int IdProducto { get; set; }
        [DataMember] public int IdProveedor { get; set; }
        [DataMember] public string NombreProducto { get; set; }
        [DataMember] public string DescrProducto { get; set; }
        [DataMember] public decimal precio { get; set; }
        [DataMember] public int cantidadproducto { get; set; }
        [DataMember] public string EstadoReg { get; set; }
        [DataMember] public string urlimg { get; set; }
    }
}
