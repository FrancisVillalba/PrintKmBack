using System.ComponentModel.DataAnnotations;

namespace PrintKmBack.Dtos;

public record GrupoVentaDto(
    int Id,
    string Nombre,
    int TeamLeaderUsuarioId,
    string? TeamLeader,
    bool Estado,
    IEnumerable<GrupoVentaVendedorDto> Vendedores);

public record GrupoVentaRequest(
    [Required] string Nombre,
    [Range(1, int.MaxValue)] int TeamLeaderUsuarioId,
    bool Estado,
    IEnumerable<int>? VendedorUsuarioIds);
