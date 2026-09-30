using System.ComponentModel.DataAnnotations;

namespace PrintKmBack.Dtos;

public record ImpresionArchivoDto(
    int DetalleId,
    int PedidoId,
    DateTime FechaCarga,
    DateTime? FechaEntrega,
    string Cliente,
    string Vendedor,
    int TipoMaquinaId,
    string TipoMaquina,
    string Producto,
    decimal Cantidad,
    string? ArchivoDisenioNombre,
    string EstadoVenta,
    bool Impreso);

public record ImpresionMarcarDto(
    int DetalleId,
    int PedidoId,
    bool DetalleImpreso,
    bool PedidoCompleto,
    string EstadoVentaId,
    string? EstadoVenta);

public record ImpresionDevolverRequest(
    [Required]
    [StringLength(500)]
    string Observacion);

public record ImpresionDevolverDto(
    int DetalleId,
    int PedidoId,
    string EstadoVentaId,
    string? EstadoVenta,
    string Observacion);
