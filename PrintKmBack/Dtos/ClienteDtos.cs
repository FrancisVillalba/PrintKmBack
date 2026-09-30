using System.ComponentModel.DataAnnotations;

namespace PrintKmBack.Dtos;

public record ClienteDto(
    int Id,
    string? Nombre,
    string? Documento,
    string TipoDocumentoId,
    string TipoClienteId,
    string? Email,
    string? NroTelefono,
    string? Direccion,
    int? DepartamentoId,
    string? Departamento,
    int? CiudadId,
    string? Ciudad,
    bool? Estado,
    ClienteDatosEnvioDto? DatosEnvio);

public record ClienteRequest(
    [Required] string? Nombre,
    string? Documento,
    string? TipoDocumentoId,
    [Required] string TipoClienteId,
    [EmailAddress] 
    string? Email,
    [Required] string? NroTelefono,
    string? Direccion,
    int? DepartamentoId,
    int? CiudadId,
    bool? Estado);
