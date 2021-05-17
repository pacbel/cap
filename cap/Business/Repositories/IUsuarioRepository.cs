using cap.Business.Entities;
using cap.Models.Usuarios;

namespace cap.Business.Repositories
{
    public interface IUsuarioRepository
    {/// <summary>
     /// 
     /// </summary>
     /// <param name="usuario"></param>
        void Adicionar(Usuario usuario);
        /// <summary>
        /// 
        /// </summary>
        void Commit();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        Usuario ObterUsuario(string login);

        void Update(string login);
    }
}

