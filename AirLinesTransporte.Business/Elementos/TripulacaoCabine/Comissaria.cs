using AirLinesTransporte.Business.Elementos.TripulacaoTecnica;
using System;
using System.Collections.Generic;

namespace AirLinesTransporte.Business.Elementos.TripulacaoCabine
{
    public class Comissaria : ElementoBase
    {
        public Comissaria()
        {
            Elemento = typeof(Comissaria);
        }
        protected override List<Type> NaoPodeFicarSozinhoCom => new List<Type> { typeof(Piloto) };
    }
}