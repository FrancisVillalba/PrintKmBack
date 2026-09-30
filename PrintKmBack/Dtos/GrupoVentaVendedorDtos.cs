namespace PrintKmBack.Dtos;

public record GrupoVentaVendedorDto(
    int Id,
    int VendedorUsuarioId,
    string? Vendedor,
    bool Estado);
