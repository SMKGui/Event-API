using Microsoft.Data.SqlClient;
using webapi.event_.tarde.Contexts;
using webapi.event_.tarde.Domains;
using webapi.event_.tarde.Interfaces;

namespace webapi.event_.tarde.Repositories
{
    public class EventoRepository : IEventoRepository
    {

        private readonly EventContext ctx;

        public EventoRepository() {
         ctx = new EventContext();
        }

        public void Atualizar(Guid id, EventoDomain evento)
        {
            EventoDomain eventoBuscado = ctx.EventoDomain.Find(id);
            if (eventoBuscado != null)
            {
                eventoBuscado.DataEvento = evento.DataEvento;
                eventoBuscado.NomeEvento = evento.NomeEvento;
                eventoBuscado.Descricao = evento.Descricao;                
            }

            ctx.Update(eventoBuscado);
            ctx.SaveChanges();
        }

        public EventoDomain BuscarPorId(Guid id)
        {
            try
            {
                EventoDomain EventoBuscado = ctx.EventoDomain.FirstOrDefault(a => a.IdEvento == id);
                return EventoBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(EventoDomain novoEvento)
        {
            try
            {
                ctx.EventoDomain.Add(novoEvento);
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
                EventoDomain evento = ctx.EventoDomain.Find(id);

                if (evento != null)
                {
                    ctx.EventoDomain.Remove(evento);
                }
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<EventoDomain> ListarTodos()
        {
            try
            {
                return ctx.EventoDomain.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

