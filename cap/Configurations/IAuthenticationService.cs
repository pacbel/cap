using cap.Models.Usuarios;

namespace cap.Configurations
{/// <summary>
/// 
/// </summary>
    public interface IAuthenticationService
    {/// <summary>
     /// 
     /// </summary>
     /// <param name="usuarioViewModelOutput"></param>
     /// <returns></returns>
        string GerarToken(UsuarioViewModelOutput usuarioViewModelOutput);
    }
}