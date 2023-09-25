using webapi.event_.tarde.Domains;

namespace webapi.event_.tarde.Interfaces
{
    public interface IInstituicaoRepository
    {
        void Deletar(Guid id);
        List<InstituicaoDomain> Listar();
        InstituicaoDomain BuscarPorId(Guid id);
        void Atualizar(Guid id, InstituicaoDomain instituicao);
        void Inscrever(InstituicaoDomain instituicao);
    }
}
