using System.ComponentModel.DataAnnotations;

namespace PrintKmBack.Dtos;

public record ProductoComisionDto(
    int Id,
    int ProductoId,
    string? Producto,
    int PerfilId,
    string? Perfil,
    decimal Porcentaje,
    bool Estado);

public record ProductoComisionRequest(
    [Range(1, int.MaxValue)] int ProductoId,
    [Range(1, int.MaxValue)] int PerfilId,
    [Range(0, 100)] decimal Porcentaje,
    bool Estado);
