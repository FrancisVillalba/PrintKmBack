using System.ComponentModel.DataAnnotations;

namespace PrintKmBack.Dtos;

public record CiudadDto(int Id, int DepartamentoId, string? Departamento, int CodigoDistrito, string Nombre, bool Estado);

public record CiudadRequest(
    [Range(1, int.MaxValue)] int DepartamentoId,
    int? CodigoDistrito,
    [Required] string Nombre,
    bool Estado);
