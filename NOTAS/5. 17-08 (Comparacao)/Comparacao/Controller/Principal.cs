using System.Collections.Generic;
using System.Diagnostics;
using projeto.model;
using ViewUtil = projeto.view.Util;

namespace projeto.controller
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            int quantidade = 10000;

            // gera uma unica massa de dados e clona para cada algoritmo,
            // garantindo que todos ordenem exatamente os mesmos numeros
            List<int> listaOriginal = new List<int>();
            Util.popular(listaOriginal, quantidade);

            List<int> listaBolha = new List<int>(listaOriginal);
            List<int> listaSelecao = new List<int>(listaOriginal);
            List<int> listaInsercao = new List<int>(listaOriginal);
            List<int> listaAgitacao = new List<int>(listaOriginal);
            List<int> listaSort = new List<int>(listaOriginal);

            Stopwatch sw = new Stopwatch();
            int qtdComparacoes, qtdTrocas;

            sw.Start();
            Ordenacao.bolha(listaBolha, out qtdComparacoes, out qtdTrocas);
            sw.Stop();
            ViewUtil.exibirTempo(sw, "Ordenacao por bolha");
            ViewUtil.exibirContadores("Ordenacao por bolha", qtdComparacoes, qtdTrocas);
            sw.Reset();

            sw.Start();
            Ordenacao.selecao(listaSelecao, out qtdComparacoes, out qtdTrocas);
            sw.Stop();
            ViewUtil.exibirTempo(sw, "Ordenacao por selecao");
            ViewUtil.exibirContadores("Ordenacao por selecao", qtdComparacoes, qtdTrocas);
            sw.Reset();

            sw.Start();
            Ordenacao.insercao(listaInsercao, out qtdComparacoes, out qtdTrocas);
            sw.Stop();
            ViewUtil.exibirTempo(sw, "Ordenacao por insercao");
            ViewUtil.exibirContadores("Ordenacao por insercao", qtdComparacoes, qtdTrocas);
            sw.Reset();

            sw.Start();
            Ordenacao.agitacao(listaAgitacao, out qtdComparacoes, out qtdTrocas);
            sw.Stop();
            ViewUtil.exibirTempo(sw, "Ordenacao por agitacao");
            ViewUtil.exibirContadores("Ordenacao por agitacao", qtdComparacoes, qtdTrocas);
            sw.Reset();

            sw.Start();
            listaSort.Sort();
            sw.Stop();
            ViewUtil.exibirTempo(sw, "Ordenacao por sort nativo");
            sw.Reset();

            //ViewUtil.exibir(listaBolha);
        }
    }
}
