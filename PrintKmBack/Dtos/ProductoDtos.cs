using System.ComponentModel.DataAnnotations;

namespace PrintKmBack.Dtos;

public record ProductoDto(int Id, string Nombre, decimal PrecioBase, decimal PrecioMenor, decimal CompraMinimaCm, int? MaquinaId, string? Maquina, bool Estado);

public record ProductoRequest([Required] string Nombre, [Range(0, double.MaxValue)] decimal PrecioBase, [Range(0, double.MaxValue)] decimal PrecioMenor, [Range(0.01, double.MaxValue)] decimal CompraMinimaCm, int? MaquinaId, bool Estado);
