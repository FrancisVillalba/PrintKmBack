using System.ComponentModel.DataAnnotations;

namespace PrintKmBack.Dtos;

public record TipoMaquinaDto(int Id, string Nombre, decimal MetaMensual, bool Estado);

public record TipoMaquinaRequest(
    [Required] string Nombre,
    [Range(0, double.MaxValue)] decimal MetaMensual,
    bool Estado);
