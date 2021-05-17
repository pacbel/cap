using cap.Business.Entities;
using cap.Enums;
using cap.Models;
using cap.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cap.Business.Repositories
{
    public interface IContaPagarRepository
    {
        bool Insert(ContaPagar conta);
        bool Delete(ICodigo codigo);
        bool Update(ContaPagar conta);
        void Commit();
        IList<ContaPagar> Select(int codigo);
    }
}
