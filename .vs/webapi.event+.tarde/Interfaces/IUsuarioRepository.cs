using webapi.event_.tarde.Domains;

namespace webapi.event_.tarde.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(UsuarioDomain usuario);

        UsuarioDomain BuscarPorId(Guid id);

        UsuarioDomain BuscarPorEmailESenha(string email, string senha);
    }
}
