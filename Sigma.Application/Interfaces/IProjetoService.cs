using Sigma.Application.Dtos;
using Sigma.Domain.Dtos;
using Sigma.Domain.Enums;

namespace Sigma.Application.Interfaces
{
    public interface IProjetoService
    {
        Task<bool> Inserir(ProjetoNovoDto model);

        Task<List<ProjetoDto>> GetAll();

        Task<bool> Add(ProjetoDto model);

    }
}
