using System.ComponentModel.DataAnnotations;

namespace PrintKmBack.Dtos;

public record UsuarioDto(
    int Id,
    string? NombreUsuario,
    int? PersonaId,
    string? Persona,
    int? PerfilId,
    string? Perfil,
    IEnumerable<int> PerfilIds,
    string? Perfiles,
    bool? Estado,
    int? SucursalId = null,
    string? Sucursal = null);

public record UsuarioRequest([Required] string? NombreUsuario, string? Pass, int? PersonaId, IEnumerable<int>? PerfilIds, bool? Estado, [Range(1, int.MaxValue)] int? SucursalId = null);
