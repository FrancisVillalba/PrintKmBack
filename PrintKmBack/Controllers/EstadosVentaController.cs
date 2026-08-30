using PrintKmBack.Models;
using PrintKmBack.Services.Interfaces;

namespace PrintKmBack.Controllers;

public class EstadosVentaController : CrudControllerBase<EstadoVenta, string>
{
    public EstadosVentaController(IGenericService<EstadoVenta> service) : base(service)
    {
    }
}
