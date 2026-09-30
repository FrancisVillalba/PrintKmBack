namespace PrintKmBack.Dtos;

public record DeliveryRutaDto(
    int Id,
    string NumeroLote,
    int UsuarioDeliveryId,
    string UsuarioDelivery,
    DateTime FechaGeneracion,
    string Estado,
    int CantidadPedidos,
    string Ciudades,
    string MetodosEnvio,
    IEnumerable<DeliveryPedidoDto> Pedidos);
