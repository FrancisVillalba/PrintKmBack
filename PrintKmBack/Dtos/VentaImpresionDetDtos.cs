using System.ComponentModel.DataAnnotations;

namespace PrintKmBack.Dtos;

public record VentaImpresionDetDto(
    int Id,
    int CabId,
    int ProductoId,
    string? Producto,
    int TipoMaquinaId,
    string? TipoMaquina,
    decimal Cantidad,
    decimal PrecioUnitario,
    decimal? PrecioExtra,
    decimal? PrecioTotal,
    string? ArchivoDisenio,
    string? ArchivoDisenioNombre,
    string? Observacion,
    string EstadoItem,
    string EstadoItemNombre,
    bool? CheckImpresion,
    DateTime FechaModificacion);

public record VentaImpresionDetRequest(
    int CabId,
    int ProductoId,
    int TipoMaquinaId,
    [Range(0.01, double.MaxValue)] decimal Cantidad,
    [Range(0, double.MaxValue)] decimal PrecioUnitario,
    [Range(0, double.MaxValue)] decimal? PrecioExtra,
    [StringLength(500)]
    string? ArchivoDisenio,
    [StringLength(255)]
    string? ArchivoDisenioNombre,
    [StringLength(500)]
    string? Observacion,
    [StringLength(2)]
    [Required] string EstadoItem,
    bool? CheckImpresion);

public record VentaImpresionDetalleCreateRequest(
    int ProductoId,
    int TipoMaquinaId,
    [Range(0.01, double.MaxValue)] decimal Cantidad,
    [Range(0, double.MaxValue)] decimal PrecioUnitario,
    [Range(0, double.MaxValue)] decimal? PrecioExtra,
    [StringLength(500)]
    string? ArchivoDisenio,
    [StringLength(255)]
    string? ArchivoDisenioNombre,
    [StringLength(500)]
    string? Observacion,
    [StringLength(2)]
    string? EstadoItem,
    bool? CheckImpresion);

public record VentaImpresionDetalleUpdateRequest(
    int? Id,
    int ProductoId,
    int TipoMaquinaId,
    [Range(0.01, double.MaxValue)] decimal Cantidad,
    [Range(0, double.MaxValue)] decimal PrecioUnitario,
    [Range(0, double.MaxValue)] decimal? PrecioExtra,
    [StringLength(500)]
    string? ArchivoDisenio,
    [StringLength(255)]
    string? ArchivoDisenioNombre,
    [StringLength(500)]
    string? Observacion,
    [StringLength(2)]
    string? EstadoItem,
    bool? CheckImpresion);
