namespace PrintKmBack.Dtos;

public record PedidoFlujoEventoDto(
    DateTime FechaHora,
    int? UsuarioId,
    string Usuario,
    string Accion,
    string EstadoAnteriorId,
    string EstadoAnterior,
    string EstadoNuevoId,
    string EstadoNuevo,
    string? Comentario,
    int? DetalleId,
    string? Producto);
