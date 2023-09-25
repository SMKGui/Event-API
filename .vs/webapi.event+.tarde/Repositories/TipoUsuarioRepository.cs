using webapi.event_.tarde.Contexts;
using webapi.event_.tarde.Domains;
using webapi.event_.tarde.Interfaces;

namespace webapi.event_.tarde.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {

        private readonly EventContext ctx;

        public TipoUsuarioRepository()
        {
            ctx = new EventContext();
        }

        public void Atualizar(Guid id, TipoUsuarioDomain tipoUsuario)
        {
            throw new NotImplementedException();
        }

        public TipoUsuarioDomain BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TipoUsuarioDomain tipoUsuario)
        {
            try
            {
                ctx.TipoUsuarioDomain.Add(tipoUsuario);

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<TipoUsuarioDomain> Listar()
        {
            try
            {
                return ctx.TipoUsuarioDomain.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
