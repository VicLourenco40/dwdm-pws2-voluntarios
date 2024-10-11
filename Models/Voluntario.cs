using System;
using System.ComponentModel.DataAnnotations;

namespace dwdm_pws2_voluntarios.Models;

public class Voluntario
{
    [Required]
    public int Id { get; set; }
    [Required]
    [StringLength(15)]
    public string Nome { get; set; }
    [Required]
    [StringLength(15)]
    public string Apelido { get; set; }
    [Required]
    public int Nif { get; set; }
    [Required]
    public string Armazem { get; set; }
}
