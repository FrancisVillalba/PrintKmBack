using System.ComponentModel.DataAnnotations;

namespace PrintKmBack.Dtos;

public record DepartamentoDto(int Id, string Nombre, bool Estado);

public record DepartamentoRequest(int? Id, [Required] string Nombre, bool Estado);
