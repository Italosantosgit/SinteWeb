using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SinteWeb.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo Obrigatorio!")]
        [MaxLength(50, ErrorMessage = "O campo deve recebe no maximo 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [MaxLength(15, ErrorMessage = "O campo deve recebe no maximo 15 caracteres")]
        public int Telefone { get; set; }

        public Endereco Endereco { get; set; }
        public ICollection<OrdemDeServico> OrdemDeServicos  { get; set; }
    }
}
