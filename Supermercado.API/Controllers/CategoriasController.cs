namespace Supermercado.API.Controllers
{
    [Route("/api/[controller]")]
    public class CategoriasController : Controller
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriasController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }
        [HttpGet]
        public async Task<IEnumerable<Categoria>> GetAllAsync()
        {
            var categorias = await _categoriaService.ListAsync();
            return categorias;
        }
    }
}