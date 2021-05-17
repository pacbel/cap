using cap.Business.Entities;
using cap.Repositories;
using System.Collections.Generic;

namespace cap.Business.Repositories
{
    public interface IPessoaJuridicaRepository
    {
        bool Insert(PessoaJuridica pessoa);
        bool Delete(int codigo);
        bool Update(PessoaJuridica pessoa);
        void Commit();
        IList<PessoaJuridica> Select(int codigo);
    }
}
