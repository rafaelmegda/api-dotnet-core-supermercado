using System.Collections.Generic;

namespace Supermercado.API.Domain.Models
{
    public class Categorias
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public IList<Produto> Produtos {get; set;} = new List<Produto>();
    }
}