using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EVF1_U1.Models;

public partial class Cliente
{
    [Required]
    
    public int Id { get; set; }
    [Required]
    public string Nombre { get; set; } = null!;
    [Required]
    public string Apelido { get; set; } = null!;
    [Required]
    public string Rut { get; set; } = null!;
    [Required]
    public string Telefono { get; set; } = null!;
    [Required]
    public string Email { get; set; } = null!;
    [Required]
    public DateTime FechaHora { get; set; }
}
