using AirLinesTransporte.Business.Aeroporto;
using AirLinesTransporte.Business.Elementos;
using AirLinesTransporte.Business.Elementos.TripulacaoCabine;
using AirLinesTransporte.Business.Elementos.TripulacaoTecnica;
using System;
using System.Collections.Generic;

namespace AirLinesTrasnporte
{
    class Program
    {
        static void Main(string[] args)
        {
            #region instance
            var piloto = new Piloto();
            var chefeDeServico = new ChefeDeServico();
            var comissariaI = new Comissaria();
            var comissariaII = new Comissaria();
            var oficialI = new Oficial();
            var oficialII = new Oficial();
            var policial = new Policial();
            var bandido = new Bandido();
            var toAviao = new DeslocamentoAoAviao();
            var toTerminal = new DeslocamentoAoTerminal();
            #endregion

            toAviao.ShowMessages += ShowMessages;
            toTerminal.ShowMessages += ShowMessages;
            toAviao.RealizarTravessia(policial, bandido);
            toTerminal.RealizarTravessia(policial);
            toAviao.RealizarTravessia(piloto, policial);
            toTerminal.RealizarTravessia(piloto);
            toAviao.RealizarTravessia(piloto, oficialI);
            toTerminal.RealizarTravessia(piloto);
            toAviao.RealizarTravessia(chefeDeServico, comissariaI);
            toTerminal.RealizarTravessia(chefeDeServico);
            toAviao.RealizarTravessia(piloto, oficialII);
            toTerminal.RealizarTravessia(piloto);
            toAviao.RealizarTravessia(chefeDeServico, comissariaII);
            toTerminal.RealizarTravessia(chefeDeServico);
            toAviao.RealizarTravessia(chefeDeServico, piloto);

            Console.ReadKey();
        }

        static void ShowMessages(object sender, EventArgs e)
        {
            List<string> lista = (List<string>)sender;
            lista.ForEach(Console.WriteLine);
        }
    }
}