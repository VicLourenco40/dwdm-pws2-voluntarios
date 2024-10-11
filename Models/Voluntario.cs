using System;
using System.ComponentModel.DataAnnotations;

namespace dwdm_pws2_voluntarios.Models;

public class Voluntario
{
    public int Id { get; set; }
    [StringLength(15)]
    [Required]
    public string? Nome { get; set; }
    [StringLength(15)]
    [Required]
    public string? Apelido { get; set; }
    [Required]
    public int Nif { get; set; }
    [Required]
    [StringLength(15)]
    public string? Armazem { get; set; }
}
