namespace PrintKmBack.Dtos;

public record VentaUsuarioResumenDto(
    DateTime FechaDesde,
    DateTime FechaHasta,
    bool PuedeVerVentasUsuario,
    VentaUsuarioTotalesDto Totales,
    IEnumerable<VentaUsuarioItemDto> Ventas);

public record VentaUsuarioTotalesDto(
    int CantidadPedidos,
    decimal TotalVenta,
    decimal TotalMetros,
    decimal TotalComision);

public record VentaUsuarioItemDto(
    int PedidoId,
    DateTime Fecha,
    string Cliente,
    string Estado,
    decimal TotalVenta,
    decimal TotalMetros,
    decimal TotalComision);
