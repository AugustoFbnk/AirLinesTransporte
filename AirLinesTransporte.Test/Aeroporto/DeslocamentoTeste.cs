using AirLinesTransporte.Business.Aeroporto;
using AirLinesTransporte.Business.Dto;
using AirLinesTransporte.Business.Elementos.TripulacaoCabine;
using AirLinesTransporte.Business.Elementos.TripulacaoTecnica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AirLinesTransporte.Test.Aeroporto
{
    [TestClass]
    public class DeslocamentoTeste
    {
        [TestMethod]
        public void Deve_validar_motorista_nao_pode_dirigir()
        {
            var deslocamento = new DeslocamentoAoAviao();
            deslocamento.RealizarTravessia(new Comissaria(), new Comissaria());
            var resultado = deslocamento.Mensagens.Exists(x => x == "O motorista não tem permissão para dirigir");
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Deve_validar_passageiro_nao_pode_ficar_sozinho_com()
        {
            var deslocamento = new DeslocamentoAoTerminal();
            deslocamento.RealizarTravessia(new Piloto(), new Comissaria());
            var resultado = deslocamento.Mensagens.Exists(x => x == "O passageiro Comissaria não pode ficar sozinho com Piloto");
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Deve_realizar_a_travessia_do_terminal_para_o_aviao()
        {
            var deslocamento = new DeslocamentoAoAviao();
            deslocamento.RealizarTravessia(new Piloto(), new Oficial());
            var resultado = deslocamento.Mensagens.Exists(x => x == "Deslocando o motorista: Piloto e o passageiro: Oficial do Terminal com destino ao Avião");
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Deve_realizar_a_travessia_do_aviao_para_o_terminal()
        {
            var deslocamento = new DeslocamentoAoTerminal();
            deslocamento.RealizarTravessia(new ChefeDeServico(), new Comissaria());
            var resultado = deslocamento.Mensagens.Exists(x => x == "Deslocando o motorista: ChefeDeServico e o passageiro: Comissaria do Avião com destino ao Terminal");
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Deve_realizar_a_travessia_do_terminal_para_o_aviao_sem_passageiro()
        {
            var deslocamento = new DeslocamentoAoAviao();
            deslocamento.RealizarTravessia(new ChefeDeServico());
            var resultado = deslocamento.Mensagens.Exists(x => x == "Deslocando o motorista: ChefeDeServico e o passageiro: Não há passageiro do Terminal com destino ao Avião");
            Assert.IsTrue(resultado);
        }
    }
}
