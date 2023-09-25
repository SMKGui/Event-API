using webapi.event_.tarde.Contexts;
using webapi.event_.tarde.Domains;
using webapi.event_.tarde.Interfaces;

namespace webapi.event_.tarde.Repositories
{
    public class InstituicaoRepository : IInstituicaoRepository
    {
        private readonly EventContext ctx;
        public InstituicaoRepository()
        {
            ctx = new EventContext();
        }

        public void Atualizar(Guid id, InstituicaoDomain instituicao)
        {
            InstituicaoDomain instBuscado = ctx.InstituicaoDomain.Find(id);
            if (instBuscado != null)
            {
                instBuscado.NomeFantasia = instituicao.NomeFantasia;
                instBuscado.CNPJ = instituicao.CNPJ;
                instBuscado.Endereco = instituicao.Endereco;
            }

            ctx.Update(instBuscado);
            ctx.SaveChanges();
        }

        public InstituicaoDomain BuscarPorId(Guid id)
        {
            try
            {
                InstituicaoDomain instBuscado = ctx.InstituicaoDomain.FirstOrDefault(a => a.IdInstituicao == id);
                return instBuscado;
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
                InstituicaoDomain instituicao = ctx.InstituicaoDomain.Find(id);

                if (instituicao != null)
                {
                    ctx.InstituicaoDomain.Remove(instituicao);
                }
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }         
        }

        public void Inscrever(InstituicaoDomain instituicao)
        {
            try
            {
                ctx.InstituicaoDomain.Add(instituicao);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<InstituicaoDomain> Listar()
        {
            try
            {
                return ctx.InstituicaoDomain.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
