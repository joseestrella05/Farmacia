using System.ComponentModel.DataAnnotations;

namespace Farmacia.Models;

public class Clientes
{
    [Key]
    public int ClienteId { get; set; }
    [Required(ErrorMessage = "El campos de nombre es obligatorio")]
    [StringLength(100)]
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no admite números ni caractereres especiales")]
    public string? Nombre { get; set; }
    [Required(ErrorMessage = "Este campo es obligatorio")]
    [RegularExpression(@"^[A-Z0-9\d{2}]+$", ErrorMessage = "Solo se permiten Numero")]
    public string? Cedula { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string? Direccion { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [RegularExpression(@"^[A-Z0-9\d{2}]+$", ErrorMessage = "Solo se permiten Numero")]
    public string? Telefono { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    public DateTime FechaIngreso { get; set; } = DateTime.Now;
}
