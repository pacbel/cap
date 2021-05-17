
using cap.Business.Entities;
using cap.Business.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace cap.Data.Repositories
{
    public class PessoaFisicaRepository : IPessoaFisicaRepository
    {
        private readonly CapDBContext _contexto;

        public PessoaFisicaRepository(CapDBContext contexto)
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
                var pessoa = _contexto.PessoaFisica.First(a => a.Codigo == codigo);
                _contexto.Remove(pessoa);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Insert(PessoaFisica pessoa)
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

        public IList<PessoaFisica> Select(int codigo)
        {
            return _contexto.PessoaFisica.Include(i => i.Codigo).Where(w => w.Codigo == codigo).ToList();
        }

        public bool Update(PessoaFisica pessoa)
        {
            try
            {
                _contexto.PessoaFisica.Update(pessoa);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
