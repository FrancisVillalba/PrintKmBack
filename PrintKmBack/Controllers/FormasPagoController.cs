using PrintKmBack.Models;
using PrintKmBack.Services.Interfaces;

namespace PrintKmBack.Controllers;

public class FormasPagoController : CrudControllerBase<FormaPago, string>
{
    public FormasPagoController(IGenericService<FormaPago> service) : base(service)
    {
    }
}
