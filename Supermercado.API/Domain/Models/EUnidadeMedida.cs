using System.ComponentModel;

namespace Supermercado.API.Domain.Models
{
    public enum EUnidadeMedida : byte
    {
        [Description("UN")]
        Unidade = 1,

        [Description("MG")]
        Miligrama = 2,

        [Description("G")]
        Grama = 3,

        [Description("KG")]
        Kilograma = 4,

        [Description("L")]
        Litro = 5

    }
}
