using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cap.Models
{
    public abstract class Padroes
    {
        public Guid Id { get; private set; }
        public int Codigo { get; private set; }
        public DateTime DataHoraModificacao { get; private set; }
    }
}
