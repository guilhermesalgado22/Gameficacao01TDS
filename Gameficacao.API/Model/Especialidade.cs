using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gameficacao.API.Model
{//
    public class Especialidade
    {

    [Key]
    public long ?EspecialidadeId { get; set; }

    [Required(ErrorMessage = "O nome da especialidade é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome da especialidade não pode exceder 100 caracteres.")]
    public string ?NomeEspecialidade { get; set; }

    [Required(ErrorMessage = "A descrição é obrigatória.")]
    [StringLength(500, ErrorMessage = "A descrição não pode exceder 500 caracteres.")]
    public string ?Descricao { get; set; }
}
    }
