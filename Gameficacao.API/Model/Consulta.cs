using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gameficacao.API.Model
{
    public class Consulta
    {
    [Key]
    public int ConsultaId { get; set; }

    [Required]
    public Medico ?Medico { get; set; }

    [Required]
    public Paciente ?Paciente { get; set; }

    public DateTime DataHora { get; set; }

    [Required(ErrorMessage = "O tipo de consulta é obrigatório.")]
    [StringLength(20, ErrorMessage = "O tipo de consulta não pode exceder 20 caracteres.")]
    public string ?TipoConsulta { get; set; }

    public string ?Observacoes { get; set; }
    }
}