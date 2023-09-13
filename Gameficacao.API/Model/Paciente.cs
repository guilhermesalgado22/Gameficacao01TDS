using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gameficacao.API.Model
{//
    public class Paciente
    {
         [Key]
    public int PacienteId { get; set; }

    [Required(ErrorMessage = "O nome do paciente é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome do paciente não pode exceder 100 caracteres.")]
    public string ?Nome { get; set; }

    [Required(ErrorMessage = "O sobrenome do paciente é obrigatório.")]
    [StringLength(100, ErrorMessage = "O sobrenome do paciente não pode exceder 100 caracteres.")]
    public string ?Sobrenome { get; set; }

    [Required(ErrorMessage = "O número de identificação é obrigatório.")]
    public string ?NumeroIdentificacao { get; set; }

    [StringLength(1000, ErrorMessage = "O histórico médico não pode exceder 1000 caracteres.")]
    public string ?HistoricoMedico { get; set; }
    public List<Consulta> Consultas { get; set; } = new List<Consulta>();
    }
}