using System.ComponentModel.DataAnnotations;

namespace SinteWeb.Models
{
    public class OrdemDeServico
    {
        public int Id { get; set; }

        [Required]
        public TipoOrdemServico TipoOrdemServico  { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "O campo deve recebe no maximo 250 caracteres")]
        public string DescricaoProblema { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "O campo deve recebe no maximo 250 caracteres")]
        public string DescricaoTrabalho { get; set; }

        [Required]
        public float MaoDeObra { get; set; }
        
        public float Orcamento { get; set; }
        [Required]
        public FormaPagamento FormaPagamento { get; set; }
        
        [MaxLength(250, ErrorMessage = "O campo deve recebe no maximo 250 caracteres")]
        public string Obsercacao { get; set; }

        

        public Cliente Cliente { get; set; }
        public Status Status  { get; set; }
        public Equipamento Equipamento  { get; set; }

    }

    public enum TipoOrdemServico
    {
        retorno,
        garantia,
        outros
    }
    public enum FormaPagamento
    {
        avista,
        cartao,
        outros
    }
}
