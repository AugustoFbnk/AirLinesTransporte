using AirLinesTransporte.Business.Elementos.TripulacaoCabine;
using AirLinesTransporte.Business.Elementos.TripulacaoTecnica;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirLinesTransporte.Business.Elementos
{
    public abstract class ElementoBase
    {
        private readonly List<Type> PodemDirigir = new List<Type> { typeof(Piloto), typeof(Policial), typeof(ChefeDeServico) };
        protected Type Elemento;
        protected virtual List<Type> NaoPodeFicarSozinhoCom => new List<Type>();

        public bool VerificarPodeDirigir()
        {
            return PodemDirigir.Any(x => x == Elemento);
        }
        public bool VerificarPodeFicarSozinho(Type elemento)
        {
            return NaoPodeFicarSozinhoCom.All(x => x != elemento);
        }
    }
}
