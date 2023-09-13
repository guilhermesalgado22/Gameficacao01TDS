using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gameficacao.API.Model
{//
    public class Recepcionista
    {
          [Key]
    public int RecepcionistaId { get; set; }

    [Required(ErrorMessage = "O nome do recepcionista é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome do recepcionista não pode exceder 100 caracteres.")]
    public string ?Nome { get; set; }

    [Required(ErrorMessage = "O sobrenome do recepcionista é obrigatório.")]
    [StringLength(100, ErrorMessage = "O sobrenome do recepcionista não pode exceder 100 caracteres.")]
    public string ?Sobrenome { get; set; }

    [Required(ErrorMessage = "O número de identificação é obrigatório.")]
    public string ?NumeroIdentificacao { get; set; }

    [Required(ErrorMessage = "O número de telefone é obrigatório.")]
    public string ?NumeroTelefone { get; set; }
    }
}