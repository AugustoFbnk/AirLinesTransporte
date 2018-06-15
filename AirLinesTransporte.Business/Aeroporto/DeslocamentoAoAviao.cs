using AirLinesTransporte.Business.Dto;

namespace AirLinesTransporte.Business.Aeroporto
{
    public class DeslocamentoAoAviao : Deslocamento
    {
        protected override RotasDto GetRota()
        {
            return new RotasDto { Destino = "Avião", Origem = "Terminal" };
        }
    }
}
