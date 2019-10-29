using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SinteWeb.Models
{
    public class Endereco
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "O campo deve recebe no maximo 50 caracteres")]
        public string Logradouro { get; set; }

        [Required]
        [MaxLength(6, ErrorMessage = "O campo deve recebe no maximo 6 caracteres")]
        public int Numero { get; set; }

        [MaxLength(50, ErrorMessage = "O campo deve recebe no maximo 50 caracteres")]
        public string Bairro { get; set; }

        
        [MaxLength(250, ErrorMessage = "O campo deve recebe no maximo 250 caracteres")]
        public string Complemento { get; set; }

        [MaxLength(25, ErrorMessage = "O campo deve recebe no maximo 25 caracteres")]
        public string Cidade { get; set; }
        public Cliente Cliente { get; set; }
    }
}
