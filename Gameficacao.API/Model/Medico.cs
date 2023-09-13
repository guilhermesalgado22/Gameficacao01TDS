using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gameficacao.API.Model
{//
    public class Medico
    {
    [Key]
    public int MedicoId { get; set; }

    [Required(ErrorMessage = "O nome do médico é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome do médico não pode exceder 100 caracteres.")]
    public string? Nome { get; set; }

    [Required]
    public Especialidade ?Especialidade { get; set; }

    [Required(ErrorMessage = "O número de registro é obrigatório.")]
    public string ?NumeroRegistroProfissional { get; set; }

    public List<DateTime> HorariosDisponiveis { get; set; } = new List<DateTime>();
    public List<Consulta> Consultas { get; set; } = new List<Consulta>();
    }
}