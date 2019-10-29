using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SinteWeb.Models
{
    public class Equipamento
    {
        public int Id { get; set; }
        [Required]
        public TipoEquipamento TipoEquipamento  { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "O campo deve recebe no maximo 50 caracteres")]
        public string Modelo { get; set; }
        public ICollection<OrdemDeServico> OrdemDeServicos { get; set; }
    }
    public enum TipoEquipamento
    {
        lavadora,
        geladeira,
        microondas,
        outros
    }
}
