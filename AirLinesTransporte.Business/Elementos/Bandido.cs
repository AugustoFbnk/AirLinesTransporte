using AirLinesTransporte.Business.Elementos.TripulacaoCabine;
using AirLinesTransporte.Business.Elementos.TripulacaoTecnica;
using System;
using System.Collections.Generic;

namespace AirLinesTransporte.Business.Elementos
{
    public class Bandido : ElementoBase
    {
        public Bandido()
        {
            Elemento = typeof(Bandido);
        }
        protected override List<Type> NaoPodeFicarSozinhoCom => new List<Type> {
            typeof(ChefeDeServico),
            typeof(Comissaria),
            typeof(Oficial),
            typeof(Piloto) };
    }
}
