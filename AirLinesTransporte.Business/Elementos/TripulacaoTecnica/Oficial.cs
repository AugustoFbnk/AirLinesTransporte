using AirLinesTransporte.Business.Elementos.TripulacaoCabine;
using System;
using System.Collections.Generic;

namespace AirLinesTransporte.Business.Elementos.TripulacaoTecnica
{
    public class Oficial : ElementoBase
    {
        public Oficial()
        {
            Elemento = typeof(Oficial);
        }
        protected override List<Type> NaoPodeFicarSozinhoCom => new List<Type> { typeof(ChefeDeServico) };
    }
}
