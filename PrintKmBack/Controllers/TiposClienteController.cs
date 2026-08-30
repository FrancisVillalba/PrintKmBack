using PrintKmBack.Models;
using PrintKmBack.Services.Interfaces;

namespace PrintKmBack.Controllers;

public class TiposClienteController : CrudControllerBase<TipoCliente, string>
{
    public TiposClienteController(IGenericService<TipoCliente> service) : base(service)
    {
    }
}
