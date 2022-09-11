using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ApiRestFastFood.Errores
{
    [DataContract]
    public class DuplicadoException
    {
        [DataMember]
        public int codigo { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}
