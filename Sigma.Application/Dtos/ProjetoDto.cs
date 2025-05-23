using Sigma.Domain.Enums;

namespace Sigma.Application.Dtos
{
    public class ProjetoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime PrevisaoTermino { get; set; }
        public decimal OrcamentoTotal { get; set; }
        public ClassificacaoRisco classificacao { get; set; }
        public StatusProjeto status{ get; set; }
    }
}
