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
            toAviao.Mensagens.ForEach(Console.WriteLine);

            toTerminal.RealizarTravessia(policial);
            toTerminal.Mensagens.ForEach(Console.WriteLine);

            toAviao.RealizarTravessia(piloto, policial);
            toAviao.Mensagens.ForEach(Console.WriteLine);

            toTerminal.RealizarTravessia(piloto);
            toTerminal.Mensagens.ForEach(Console.WriteLine);

            toAviao.RealizarTravessia(piloto, oficialI);
            toAviao.Mensagens.ForEach(Console.WriteLine);

            toTerminal.RealizarTravessia(piloto);
            toTerminal.Mensagens.ForEach(Console.WriteLine);

            toAviao.RealizarTravessia(chefeDeServico, comissariaI);
            toAviao.Mensagens.ForEach(Console.WriteLine);

            toTerminal.RealizarTravessia(chefeDeServico);
            toTerminal.Mensagens.ForEach(Console.WriteLine);

            toAviao.RealizarTravessia(piloto, oficialII);
            toAviao.Mensagens.ForEach(Console.WriteLine);

            toTerminal.RealizarTravessia(piloto);
            toTerminal.Mensagens.ForEach(Console.WriteLine);

            toAviao.RealizarTravessia(chefeDeServico, comissariaII);
            toAviao.Mensagens.ForEach(Console.WriteLine);

            toTerminal.RealizarTravessia(chefeDeServico);
            toTerminal.Mensagens.ForEach(Console.WriteLine);

            toAviao.RealizarTravessia(chefeDeServico, piloto);
            toAviao.Mensagens.ForEach(Console.WriteLine);

            Console.ReadKey();
        }

        static void ShowMessages(object sender, EventArgs e)
        {
            List<string> lista = (List<string>)sender;
            lista.ForEach(Console.WriteLine);
        }
    }
}