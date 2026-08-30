using PrintKmBack.Dtos;
using PrintKmBack.Models;

namespace PrintKmBack.Services.Interfaces;

public interface IPedidoFlujoService
{
    Task RegistrarAsync(
        VentaImpresionCab pedido,
        string accion,
        string? estadoAnteriorId,
        string? estadoNuevoId,
        string? comentario = null,
        int? detalleId = null,
        int? usuarioId = null,
        CancellationToken cancellationToken = default,
        string? producto = null);

    IReadOnlyList<PedidoFlujoEventoDto> Obtener(VentaImpresionCab pedido);
}