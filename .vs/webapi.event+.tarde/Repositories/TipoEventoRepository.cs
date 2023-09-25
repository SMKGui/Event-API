using webapi.event_.tarde.Contexts;
using webapi.event_.tarde.Domains;
using webapi.event_.tarde.Interfaces;

namespace webapi.event_.tarde.Repositories
{
    public class TipoEventoRepository : ITipoEventoRepository
    {

        private readonly EventContext ctx;
        public TipoEventoRepository()
        {
            ctx = new EventContext();
        }

        public void Atualizar(Guid id, TipoEventoDomain tipoEvento)
        {
            throw new NotImplementedException();
        }

        public TipoEventoDomain BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TipoEventoDomain novoTipoEvento)
        {
            try
            {
                ctx.TipoEventoDomain.Add(novoTipoEvento);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                TipoEventoDomain tipoEvento = ctx.TipoEventoDomain.Find(id);

                if (tipoEvento != null)
                {
                    ctx.TipoEventoDomain.Remove(tipoEvento);
                }
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TipoEventoDomain> Listar()
        {
            try
            {
                return ctx.TipoEventoDomain.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
