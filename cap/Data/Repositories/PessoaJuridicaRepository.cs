using cap.Business.Entities;
using cap.Business.Repositories;
using cap.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cap.Data.Repositories
{
    public class PessoaJuridicaRepository : IPessoaJuridicaRepository
    {

        private readonly CapDBContext _contexto;

        public PessoaJuridicaRepository(CapDBContext contexto)
        {
            _contexto = contexto;
        }

        public void Commit()
        {
            _contexto.SaveChanges();
        }

        public bool Delete(int codigo)
        {
            try
            {
                var pessoa = _contexto.PessoaJuridica.First(a => a.Codigo == codigo);
                _contexto.Remove(pessoa);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Insert(PessoaJuridica pessoa)
        {
            try
            {
                _contexto.Add(pessoa);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IList<PessoaJuridica> Select(int codigo)
        {
            return _contexto.PessoaJuridica.Include(i => i.Codigo).Where(w => w.Codigo == codigo).ToList();
        }

        public bool Update(PessoaJuridica pessoa)
        {
            try
            {
                _contexto.PessoaJuridica.Update(pessoa);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
