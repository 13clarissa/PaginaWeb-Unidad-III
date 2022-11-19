using Modelos;

namespace Blazor_Proyecto.Interfaces
{
    public interface ILoginServicio
    {
        Task<bool> ValidarUsuario(Login login);
    }
}
