using AirLinesTransporte.Business.Dto;

namespace AirLinesTransporte.Business.Aeroporto
{
    public class DeslocamentoAoTerminal : Deslocamento
    {
        protected override RotasDto GetRota()
        {
            return new RotasDto { Destino = "Terminal", Origem = "Avião" };
        }
    }
}
