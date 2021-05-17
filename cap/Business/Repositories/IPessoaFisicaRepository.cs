using cap.Business.Entities;
using cap.Repositories;
using System.Collections.Generic;

namespace cap.Business.Repositories
{
    public interface IPessoaFisicaRepository
    {
        bool Insert(PessoaFisica pessoa);
        bool Delete(int codigo);
        bool Update(PessoaFisica pessoa);
        void Commit();
        IList<PessoaFisica> Select(int codigo);
    }
}
