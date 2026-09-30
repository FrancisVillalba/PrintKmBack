namespace PrintKmBack.Dtos;

public record GrupoVentaEquipoDto(
    DateTime FechaDesde,
    DateTime FechaHasta,
    IEnumerable<GrupoVentaResumenVendedorDto> Resumen,
    IEnumerable<GrupoVentaVentaDto> Ventas,
    IEnumerable<GrupoVentaFiltroVendedorDto> Vendedores,
    bool PuedeFiltrarVendedores);

public record GrupoVentaFiltroVendedorDto(
    int VendedorId,
    string Vendedor);

public record GrupoVentaResumenVendedorDto(
    int VendedorId,
    string Vendedor,
    int CantidadPedidos,
    decimal TotalVenta,
    decimal TotalMetros,
    decimal TotalComision);

public record GrupoVentaVentaDto(
    int PedidoId,
    DateTime Fecha,
    int VendedorId,
    string Vendedor,
    string Cliente,
    string Estado,
    decimal TotalVenta,
    decimal TotalPagado,
    decimal TotalMetros,
    decimal TotalComision,
    string? UsuarioEntrega,
    bool Reposicion,
    IEnumerable<GrupoVentaDetalleEstadoDto> Detalles);

public record GrupoVentaDetalleEstadoDto(
    int DetalleId,
    string Producto,
    string EstadoItem,
    string EstadoItemNombre);
