using cap.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cap.Business.Entities
{
    public abstract class Contato
    {
        public ContatoTipo TipoContato { get; set; }
        public string Valor { get; set; }
    }
}
