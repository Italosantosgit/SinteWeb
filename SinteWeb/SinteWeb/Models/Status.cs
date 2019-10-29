using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SinteWeb.Models
{
    public class Status
    {
        public int Id { get; set; }

        [Required]
        public TipoStatus TipoStatus { get; set; }
        public ICollection<OrdemDeServico> OrdemDeServicos { get; set; }
    }
    public enum TipoStatus
    {
        pendente,
        cancelado,
        finalizado
    }
}
