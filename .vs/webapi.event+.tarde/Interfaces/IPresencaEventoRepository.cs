using webapi.event_.tarde.Domains;

namespace webapi.event_.tarde.Interfaces
{
    public interface IPresencaEventoRepository
    {
        void Deletar(Guid id);
        List<PresencaEventoDomain> Listar();
        PresencaEventoDomain BuscarPorId(Guid id);
        void Atualizar(Guid id, PresencaEventoDomain presencaEvento);
        List<PresencaEventoDomain> ListarMinhas(Guid id);
        void Inscrever(PresencaEventoDomain inscricao);
    }
}
