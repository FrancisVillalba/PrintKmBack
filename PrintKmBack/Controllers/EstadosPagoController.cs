using PrintKmBack.Models;
using PrintKmBack.Services.Interfaces;

namespace PrintKmBack.Controllers;

public class EstadosPagoController : CrudControllerBase<EstadoPago, string>
{
    public EstadosPagoController(IGenericService<EstadoPago> service) : base(service)
    {
    }
}
