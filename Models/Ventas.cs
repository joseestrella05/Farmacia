using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farmacia.Models;

public class Ventas
{
    public int VentaId { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Now;
    public decimal Total { get; set; }
    public string? TipoPago { get; set; }
    public string? ClienteId { get; set; }
    [ForeignKey("ClienteId")]
    public Clientes? Clientes { get; set; }
    public List<VentasDetalle> Detalles { get; set; }
}