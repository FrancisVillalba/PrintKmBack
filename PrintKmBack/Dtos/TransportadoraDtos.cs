using System.ComponentModel.DataAnnotations;

namespace PrintKmBack.Dtos;

public record TransportadoraDto(int Id, string Nombre, string? Telefono, string? Direccion, string? Observacion, decimal Monto, bool Estado);

public record TransportadoraRequest([Required] string Nombre, string? Telefono, string? Direccion, string? Observacion, [Range(0, double.MaxValue)] decimal Monto, bool Estado);
