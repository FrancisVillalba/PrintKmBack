using PrintKmBack.Models;
using PrintKmBack.Services.Interfaces;

namespace PrintKmBack.Controllers;

public class TiposDocumentoController : CrudControllerBase<TipoDocumento, string>
{
    public TiposDocumentoController(IGenericService<TipoDocumento> service) : base(service)
    {
    }
}
