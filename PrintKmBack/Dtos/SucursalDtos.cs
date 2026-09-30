using System.ComponentModel.DataAnnotations;

namespace PrintKmBack.Dtos;

public record SucursalDto(int Id, string Nombre, string? Direccion, bool Estado);

public record SucursalRequest([Required, StringLength(100)] string Nombre, [StringLength(250)] string? Direccion, bool Estado);
