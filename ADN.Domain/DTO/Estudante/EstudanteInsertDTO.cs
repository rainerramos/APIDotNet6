using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADN.Domain.DTO.Estudante
{
    public class EstudanteInsertDTO
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(30, ErrorMessage = "{0} deve ter no máximo {1} de caracteres")]
        [MinLength(3, ErrorMessage = "{0} deve ter no mínimo {1} de caracteres")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataNascimento { get; set; }
    }
}
