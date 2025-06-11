using System.ComponentModel.DataAnnotations;

namespace Farmacia.Models;

public class VentasDetalle
{
    [Key]
    public int DetalleId { get; set; }
    public int VentaId { get; set; }
    public int MedicamentoId { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }
    public decimal Descuento { get; set; } 
    public bool RequiereReceta { get; set; }
}
