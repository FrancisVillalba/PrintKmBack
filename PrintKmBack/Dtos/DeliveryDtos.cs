namespace PrintKmBack.Dtos;

public record DeliveryPedidoDto(
    int Id,
    DateTime FechaCreacion,
    DateTime? FechaEntrega,
    string Cliente,
    string? Telefono,
    string? Direccion,
    string? Departamento,
    string? Ciudad,
    string EstadoVentaId,
    string? EstadoVenta,
    string Vendedor,
    decimal TotalVenta,
    string MetodoEntregaId,
    string MetodoEntrega,
    int? DeliveryUsuarioId,
    string? DeliveryUsuario,
    DateTime? FechaTomaDelivery,
    string Productos,
    string? Transportadora,
    string FormaPagoId,
    string? FormaPago,
    bool EsPagoEfectivo,
    decimal MontoDeuda);

public record DeliveryResumenDto(
    int UsuarioId,
    string Delivery,
    int CantidadPedidos,
    decimal TotalPedidos,
    string Ciudades,
    string MetodosEnvio);
