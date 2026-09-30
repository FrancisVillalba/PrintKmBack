using System.ComponentModel.DataAnnotations;

namespace PrintKmBack.Dtos;

public record PerfilDto(int Id, string Nombre, string? Descripcion, bool Estado);

public record PerfilRequest([Required] string Nombre, string? Descripcion, bool Estado);
