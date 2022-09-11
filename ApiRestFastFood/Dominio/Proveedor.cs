using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ApiRestFastFood.Dominio
{
    [DataContract]
    public class Proveedor
    {
        [DataMember] public int IdProveedor { get; set; }
        [DataMember] public string Ruc { get; set; }
        [DataMember] public string Razonsocial { get; set; }
        [DataMember] public string DescripcionProductos { get; set; }
        [DataMember] public string IdDepartamento { get; set; }
        [DataMember] public string IdProvincia { get; set; }
        [DataMember] public string IdDistrito { get; set; }
        [DataMember] public string IdSedeProveedor { get; set; }
        [DataMember] public string Direccion { get; set; }
        [DataMember] public string RepNombre { get; set; }
        [DataMember] public string RepApellido { get; set; }
        [DataMember] public string UsuarioAtencion { get; set; }
        [DataMember] public string contrasenia { get; set; }
        [DataMember] public string Numerocelular { get; set; }
        [DataMember] public string Email { get; set; }
        [DataMember] public string IndAutorizaDato { get; set; }
        [DataMember] public DateTime? FechaCreacion { get; set; }
        [DataMember] public string UsuarioCreacion { get; set; }
        [DataMember] public DateTime? FechaModifacion { get; set; }
        [DataMember] public string UsuarioModificacion { get; set; }
        [DataMember] public string urlimg { get; set; }
    }
}
