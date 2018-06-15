using AirLinesTransporte.Business.Dto;
using AirLinesTransporte.Business.Aeroporto.Veiculos;
using AirLinesTransporte.Business.Elementos;
using System.Collections.Generic;
using System;

namespace AirLinesTransporte.Business.Aeroporto
{
    public abstract class Deslocamento
    {
        public event EventHandler ShowMessages;
        protected virtual void OnShowMessages(EventArgs e)
        {
            EventHandler handler = ShowMessages;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        private DuplaDeslocamentoDto dupla;
        protected abstract RotasDto GetRota();
        private const string ViagemSemPassageiro = "Não há passageiro";
        public List<string> Mensagens = new List<string>();

        public void RealizarTravessia(ElementoBase motorista, ElementoBase passageiro = null)
        {
            dupla = MontarDupla(motorista, passageiro);
            var deslocamento = MontarDeslocamento();
            if (Validar())
                Mensagens.Add(new SmartFortwo().Travel(deslocamento));
            ShowMessages.Invoke(Mensagens, new EventArgs());
            LimparMensagens();
        }

        private void LimparMensagens()
        {
            Mensagens = new List<string>();
        }

        #region Build
        private DuplaDeslocamentoDto MontarDupla(ElementoBase motorista, ElementoBase passageiro = null)
        {
            return passageiro == null ? new DuplaDeslocamentoDto() { Motorista = motorista } :
                new DuplaDeslocamentoDto() { Motorista = motorista, Passageiro = passageiro };
        }

        private DeslocamentoDto MontarDeslocamento()
        {
            return new DeslocamentoDto()
            {
                Rota = GetRota(),
                Motorista = dupla.Motorista.GetType().Name,
                Passageiro = dupla.Passageiro != null ? dupla.Passageiro.GetType().Name : ViagemSemPassageiro
            };
        }
        #endregion

        #region Validate
        private bool Validar()
        {
            ValidarMotorista();
            ValidarPassageiro();
            return Mensagens.Count == 0;
        }

        private void ValidarPassageiro()
        {
            var validado = dupla.Passageiro == null || dupla.Passageiro.VerificarPodeFicarSozinho(dupla.Motorista.GetType());
            if (!validado)
                Mensagens.Add($"O passageiro {dupla.Passageiro.GetType().Name} não pode ficar sozinho com {dupla.Motorista.GetType().Name}");
        }

        private void ValidarMotorista()
        {
            var validado = dupla.Motorista.VerificarPodeDirigir();
            if (!validado)
                Mensagens.Add($"O motorista não tem permissão para dirigir");
        }
        #endregion
    }
}