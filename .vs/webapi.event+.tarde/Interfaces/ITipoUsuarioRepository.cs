using webapi.event_.tarde.Domains;

namespace webapi.event_.tarde.Interfaces
{
    public interface ITipoUsuarioRepository
    {
        void Cadastrar(TipoUsuarioDomain tipoUsuario);

        void Deletar(Guid id);

        List<TipoUsuarioDomain> Listar();

        TipoUsuarioDomain BuscarPorId(Guid id);

        void Atualizar(Guid id, TipoUsuarioDomain tipoUsuario);
    }
}
