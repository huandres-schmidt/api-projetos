using Microsoft.EntityFrameworkCore;
using Sigma.Domain.Entities;
using Sigma.Domain.Enums;
using Sigma.Domain.Interfaces.Repositories;
using Sigma.Infra.Data.Context;

namespace Sigma.Infra.Data.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {
        private readonly SigmaContext _dbContext;

        public ProjetoRepository(SigmaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Inserir(Projeto entidade)
        {
           await _dbContext.Set<Projeto>().AddAsync(entidade);
           await _dbContext.SaveChangesAsync();
           return true;
        }

        public async Task<List<Projeto>> GetAll() 
        {
            return await _dbContext.Set<Projeto>().ToListAsync();
        }

        public async Task<bool> Add(Projeto entidade)
        {
            await _dbContext.Set<Projeto>().AddAsync(entidade);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Projeto> Find(string nome, StatusProjeto status)
        {
            var projeto = await _dbContext.FindAsync<Projeto>(nome, status);
            if (projeto == null)
            {
                throw new Exception("Projeto não encontrado");
            }
            return projeto;
        }

        public async Task<bool> Delete(Projeto entidade)
        {
            _dbContext.Set<Projeto>().Remove(entidade);
            var result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
