using cap.Business.Entities;
using cap.Business.Repositories;
using cap.Enums;
using cap.Models;
using cap.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cap.Data.Repositories
{
    public class ContaPagarRepository : IContaPagarRepository
    {
        public void Commit()
        {
            throw new NotImplementedException();
        }

        public bool Delete(ICodigo codigo)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ContaPagar conta)
        {
            throw new NotImplementedException();
        }

        public IList<ContaPagar> Select(int codigo)
        {
            throw new NotImplementedException();
        }

        public bool Update(ContaPagar conta)
        {
            throw new NotImplementedException();
        }
    }
}
