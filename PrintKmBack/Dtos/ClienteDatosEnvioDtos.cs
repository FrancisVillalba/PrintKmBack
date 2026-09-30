using System.ComponentModel.DataAnnotations;

namespace PrintKmBack.Dtos;

public record ClienteDatosEnvioDto(
    int Id,
    int ClienteId,
    int TransportadoraId,
    string? Transportadora,
    decimal MontoTransportadora,
    string NombreReceptor,
    string DocumentoReceptor,
    string TelefonoReceptor,
    int DepartamentoId,
    string? Departamento,
    int CiudadId,
    string? Ciudad,
    string Direccion,
    string? Observacion,
    bool Estado);

public record ClienteDatosEnvioRequest(
    int ClienteId,
    [Range(1, int.MaxValue)]
    int TransportadoraId,
    [Required] string NombreReceptor,
    [Required] string DocumentoReceptor,
    [Required] string TelefonoReceptor,
    [Range(1, int.MaxValue)]
    int DepartamentoId,
    [Range(1, int.MaxValue)]
    int CiudadId,
    [Required] string Direccion,
    string? Observacion,
    bool Estado);
