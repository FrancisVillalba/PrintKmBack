namespace PrintKmBack.Dtos;

public record VentaImpresionOptionsDto(
    IEnumerable<ClienteDto> Clientes,
    IEnumerable<CatalogDto> FormasPago,
    IEnumerable<UsuarioDto> Vendedores,
    IEnumerable<CatalogDto> EstadosPago,
    IEnumerable<EstadoVentaOptionDto> EstadosVenta,
    IEnumerable<ProductoDto> Productos,
    IEnumerable<TipoMaquinaDto> Maquinas,
    int? UsuarioActualId,
    bool PuedeVerTodosPedidos,
    bool PuedeVerVentasUsuario,
    decimal MontoEnvioTransportadora,
    decimal CmPrecioMayorOMenor,
    decimal CompraMinimaCm);
