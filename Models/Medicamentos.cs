using System.ComponentModel.DataAnnotations;

namespace Farmacia.Models;

public class Medicamentos
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir un nombre.")]
    public string? Nombre { get; set; }
    [Required(ErrorMessage = "Es obligatorio introducir el codigo de barra.")]
    public string? CodigoBarras { get; set; }
    public string? PrincipioActivo { get; set; }
    [Required(ErrorMessage = "Es obligatorio introducir el Lote.")]
    public string? Lote { get; set; }
    [Required(ErrorMessage = "Es obligatorio introducir la fecha de caducidad.")]
    public DateTime FechaCaducidad { get; set; }
    [Required(ErrorMessage = "Es obligatorio introducir el precio.")]
    public decimal Precio { get; set; }
    [Required(ErrorMessage = "Es obligatorio introducir el stock.")]
    public int Stock { get; set; }

    public bool EsControlado { get; set; } // Medicamento controlado
}
