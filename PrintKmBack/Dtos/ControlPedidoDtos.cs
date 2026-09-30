namespace PrintKmBack.Dtos;

public record ControlPedidoDto(
    int Id,
    DateTime FechaCreacion,
    DateTime? FechaEntrega,
    string Cliente,
    string Vendedor,
    string EstadoVentaId,
    string? EstadoVenta,
    string? MetodoEntregaId,
    string? MetodoEntrega,
    decimal TotalVenta,
    IEnumerable<ControlPedidoDetalleDto> Detalles);

public record ControlPedidoDetalleDto(
    int Id,
    int PedidoId,
    int TipoMaquinaId,
    string TipoMaquina,
    string Producto,
    decimal Cantidad,
    string? ArchivoDisenioNombre,
    string? Observacion,
    string EstadoItem,
    bool Impreso);
