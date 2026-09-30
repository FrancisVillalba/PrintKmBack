using System.ComponentModel.DataAnnotations;

namespace PrintKmBack.Dtos;

public record VentaImpresionCabDto(
    int Id,
    int ClienteId,
    string? Cliente,
    string FormaPagoId,
    string? FormaPago,
    decimal TotalVenta,
    decimal MontoEnvioTransportadora,
    string EstadoVentaId,
    string? EstadoVenta,
    int VendedorId,
    decimal? MontoPagado,
    string? EstadoPagadoId,
    string? EstadoPagado,
    DateTime FechaCreacion,
    DateTime FechaModificacion,
    DateTime? FechaEntrega,
    string? ComprobantePago,
    string? ComprobantePagoNombre,
    string? Observacion,
    string? MetodoEntrega,
    string? MetodoEntregaNombre,
    bool Reposicion,
    int? DeliveryUsuarioId,
    string? DeliveryUsuario,
    DateTime? FechaTomaDelivery,
    IEnumerable<VentaImpresionDetDto> Detalles,
    int? SucursalId = null,
    string? Sucursal = null);

public record VentaImpresionCabRequest(
    int ClienteId,
    [Required]
    [StringLength(1)]
    string FormaPagoId,
    [Range(0, double.MaxValue)] decimal TotalVenta,
    [Required]
    [StringLength(2)]
    string EstadoVentaId,
    int VendedorId,
    decimal? MontoPagado,
    [StringLength(50)]
    string? EstadoPagadoId,
    DateTime? FechaEntrega,
    [StringLength(5000)]
    string? ComprobantePago,
    [StringLength(255)]
    string? ComprobantePagoNombre,
    [StringLength(500)]
    string? Observacion,
    [StringLength(30)]
    string? MetodoEntrega,
    bool Reposicion);

public record EliminarVentaImpresionRequest(
    [Required]
    [StringLength(500)]
    string Observacion);

public record VentaImpresionCompletaRequest(
    int ClienteId,
    [Required]
    [StringLength(1)]
    string FormaPagoId,
    int VendedorId,
    decimal? MontoPagado,
    [StringLength(50)]
    string? EstadoPagadoId,
    DateTime? FechaEntrega,
    [StringLength(5000)]
    string? ComprobantePago,
    [StringLength(255)]
    string? ComprobantePagoNombre,
    [StringLength(500)]
    string? Observacion,
    [StringLength(30)]
    string? MetodoEntrega,
    bool Reposicion,
    [StringLength(2)]
    string? EstadoVentaId,
    [Required] IEnumerable<VentaImpresionDetalleCreateRequest> Detalles);

public record VentaImpresionCompletaUpdateRequest(
    int ClienteId,
    [Required]
    [StringLength(1)]
    string FormaPagoId,
    int VendedorId,
    decimal? MontoPagado,
    [StringLength(50)]
    string? EstadoPagadoId,
    DateTime? FechaEntrega,
    [StringLength(5000)]
    string? ComprobantePago,
    [StringLength(255)]
    string? ComprobantePagoNombre,
    [StringLength(500)]
    string? Observacion,
    [StringLength(30)]
    string? MetodoEntrega,
    bool Reposicion,
    [StringLength(2)]
    string? EstadoVentaId,
    DateTime? FechaModificacion,
    bool CambiarEstado,
    [Required] IEnumerable<VentaImpresionDetalleUpdateRequest> Detalles);
