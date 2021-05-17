using cap.Business.Entities;
using cap.Business.Repositories;
using cap.Data;
using cap.Models.Usuarios;
using System.Linq;

namespace cap.Infraestruture.Data.Repositories
{/// <summary>
/// 
/// </summary>
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly CapDBContext _contexto;

        public UsuarioRepository(CapDBContext contexto)
        {
            _contexto = contexto;
        }
        public void Adicionar(Usuario usuario)
        {
            _contexto.Usuario.Add(usuario);
        }

        public void Commit()
        {
            _contexto.SaveChanges();
        }

        public Usuario ObterUsuario(string login)
        {
            return _contexto.Usuario.FirstOrDefault(u => u.Login == login);
        }

        public void Update(string login)
        {
            var _usuario =  _contexto.Usuario.FirstOrDefault(u => u.Login == login);
            _contexto.Update(_usuario);
        }
    }
}
