using Microsoft.Data.SqlClient;
using webapi.event_.tarde.Contexts;
using webapi.event_.tarde.Domains;
using webapi.event_.tarde.Interfaces;

namespace webapi.event_.tarde.Repositories
{
    public class PresencaEventoRepository : IPresencaEventoRepository
    {
        private readonly EventContext ctx;
        public PresencaEventoRepository()
        {
            ctx = new EventContext();
        }

        public void Atualizar(Guid id, PresencaEventoDomain presencaEvento)
        {
            throw new NotImplementedException();
        }

        public PresencaEventoDomain BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Inscrever(PresencaEventoDomain inscricao)
        {
            throw new NotImplementedException();
        }

        public List<PresencaEventoDomain> Listar()
        {
            try
            {
                return ctx.PresencaEventoDomain.ToList();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<PresencaEventoDomain> ListarMinhas(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
