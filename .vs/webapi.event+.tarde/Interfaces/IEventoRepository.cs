using webapi.event_.tarde.Domains;

namespace webapi.event_.tarde.Interfaces
{
    public interface IEventoRepository
    {
        void Cadastrar(EventoDomain novoEvento);

        List<EventoDomain> ListarTodos();

        EventoDomain BuscarPorId(Guid id);

        void Atualizar(Guid Id, EventoDomain evento);

        void Deletar(Guid id);
    }
}
