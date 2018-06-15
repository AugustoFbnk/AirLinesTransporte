using AirLinesTransporte.Business.Aeroporto.Veiculos.Interface;
using AirLinesTransporte.Business.Dto;

namespace AirLinesTransporte.Business.Aeroporto.Veiculos
{
    public class SmartFortwo : IVeiculoBase
    {
        public string Travel(DeslocamentoDto deslocamento)
        {
            var mensagem = $"Deslocando o motorista: {deslocamento.Motorista} e o passageiro: {deslocamento.Passageiro} do " +
                $"{deslocamento.Rota.Origem} com destino ao {deslocamento.Rota.Destino}";
            return mensagem;
        }
    }
}