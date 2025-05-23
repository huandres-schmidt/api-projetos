using Sigma.Domain.Entities;
using Sigma.Domain.Enums;

namespace Sigma.Domain.Interfaces.Repositories
{
    public interface IProjetoRepository
    {
        Task<bool> Inserir(Projeto entidade);

        Task<bool> Add(Projeto entidade);

        Task<List<Projeto>> GetAll();

        Task<Projeto> Find(String nome, StatusProjeto status);

        Task<bool> Delete(Projeto entidade);
    }
}
