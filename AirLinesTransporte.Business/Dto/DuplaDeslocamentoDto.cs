using AirLinesTransporte.Business.Elementos;

namespace AirLinesTransporte.Business.Dto
{
    public class DuplaDeslocamentoDto
    {
        public ElementoBase Motorista { get; set; }
        public ElementoBase Passageiro { get; set; }
    }
}
