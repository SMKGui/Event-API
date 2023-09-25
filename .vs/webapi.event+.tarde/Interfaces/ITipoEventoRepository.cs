using webapi.event_.tarde.Domains;

namespace webapi.event_.tarde.Interfaces
{
    public interface ITipoEventoRepository
    {
        void Cadastrar(TipoEventoDomain tipoEvento);

        void Deletar(Guid id);

        List<TipoEventoDomain> Listar();

        TipoEventoDomain BuscarPorId(Guid id);

        void Atualizar(Guid id, TipoEventoDomain tipoEvento);
    }
}
