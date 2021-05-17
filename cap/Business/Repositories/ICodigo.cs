using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cap.Repositories
{
    public class ICodigo
    {
        public Guid GerarCodigo()
        {
            return Guid.NewGuid();
        }
    }
}
