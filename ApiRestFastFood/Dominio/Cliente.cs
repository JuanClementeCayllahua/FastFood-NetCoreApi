using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ApiRestFastFood.Dominio
{
    [DataContract]
    public class Cliente
    {
        [DataMember] public int IdCliente { get; set; }
        [DataMember] public string Nombres { get; set; }
        [DataMember] public string Apellidos { get; set; }
        [DataMember] public string TipoDocId { get; set; }
        [DataMember] public DateTime? FechaNac { get; set; }
        [DataMember] public string Numerocelular { get; set; }
        [DataMember] public string Email { get; set; }
        [DataMember] public string Contrasenia { get; set; }
        [DataMember] public string IdDepartamento { get; set; }
        [DataMember] public string IdProvincia { get; set; }
        [DataMember] public string IdDistrito { get; set; }
        [DataMember] public string Direccion { get; set; }
        [DataMember] public string IndAutorizaDato { get; set; }
        [DataMember] public DateTime? FechaCreacion { get; set; }
        [DataMember] public string UsuarioCreacion { get; set; }
        [DataMember] public DateTime? FechaModifacion { get; set; }
        [DataMember] public string UsuarioModificacion { get; set; }
        [DataMember] public string numerodoc { get; set; }
        [DataMember] public string estado { get; set; }
    }
}
