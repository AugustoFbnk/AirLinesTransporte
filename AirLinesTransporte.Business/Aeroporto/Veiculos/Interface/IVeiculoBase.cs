using AirLinesTransporte.Business.Dto;
using System.Text;

namespace AirLinesTransporte.Business.Aeroporto.Veiculos.Interface
{
    public interface IVeiculoBase
    {
        string Travel(DeslocamentoDto deslocamentp);
    }
}
