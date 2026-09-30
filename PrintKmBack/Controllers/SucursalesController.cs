using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrintKmBack.Data;
using PrintKmBack.Dtos;
using PrintKmBack.Models;

namespace PrintKmBack.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SucursalesController(EvaluSystemDbContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<SucursalDto>>> GetAll() =>
        Ok(await context.Sucursales.AsNoTracking().OrderBy(x => x.Nombre)
            .Select(x => new SucursalDto(x.Id, x.Nombre, x.Direccion, x.Estado)).ToListAsync());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<SucursalDto>> GetById(int id)
    {
        var item = await context.Sucursales.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return item is null ? NotFound() : Ok(ToDto(item));
    }

    [HttpPost]
    public async Task<ActionResult<SucursalDto>> Create(SucursalRequest request)
    {
        var item = new Sucursal { Nombre = request.Nombre.Trim(), Direccion = request.Direccion?.Trim(), Estado = request.Estado };
        context.Sucursales.Add(item);
        await context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = item.Id }, ToDto(item));
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, SucursalRequest request)
    {
        var item = await context.Sucursales.FindAsync(id);
        if (item is null) return NotFound();
        item.Nombre = request.Nombre.Trim();
        item.Direccion = request.Direccion?.Trim();
        item.Estado = request.Estado;
        await context.SaveChangesAsync();
        return NoContent();
    }

    // Deactivate instead of deleting branches referenced by users and historical sales.
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var item = await context.Sucursales.FindAsync(id);
        if (item is null) return NotFound();
        item.Estado = false;
        await context.SaveChangesAsync();
        return NoContent();
    }

    private static SucursalDto ToDto(Sucursal item) => new(item.Id, item.Nombre, item.Direccion, item.Estado);
}
