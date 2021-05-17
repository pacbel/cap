using cap.Models;
using cap.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cap.Business.Repositories
{
    public interface ICompraRepository
    {
        bool Insert(Compra compra);
        bool Delete(ICodigo codigo);
        bool Update(Compra compra);

        void Commit();
        IList<Compra> Select(int codigo);
    }
}
