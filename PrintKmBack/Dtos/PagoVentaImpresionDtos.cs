using System.ComponentModel.DataAnnotations;

namespace PrintKmBack.Dtos;

public record PagoVentaImpresionDto(
    int Id,
    int VentaImpresionId,
    DateTime FechaHora,
    int UsuarioId,
    string FormaPagoId,
    decimal Monto,
    string? RutaComprobante,
    string? NombreComprobante);

public record PagoVentaImpresionRequest(
    int VentaImpresionId,
    string FormaPagoId,
    decimal Monto,
    string? RutaComprobante,
    string? NombreComprobante);

public record ActualizarPagoVentaRequest(
    [Required]
    [StringLength(1)]
    string FormaPagoId,
    decimal? MontoPagado,
    [StringLength(50)]
    string? EstadoPagadoId,
    [StringLength(5000)]
    string? ComprobantePago,
    [StringLength(255)]
    string? ComprobantePagoNombre);
