package projeto.controller;

import projeto.model.UtilidadesModel;
import projeto.view.ExibicaoView;
import java.util.List;

// ============================================
// CONTROLLER - é o intermediário. Ele dita o fluxo da 
// aplicação: chama o Model para processar os dados, calcula o 
// tempo e envia o resultado para a View exibir.
// ============================================

public class ListaController {
    public static void executarRotinaAleatoria(List<Integer> lista, long quantidadeNumeros, int inicio, int fim) {
        long tempoInicio = System.nanoTime();
        UtilidadesModel.popularLista(lista, quantidadeNumeros, inicio, fim, true);
        long tempoFim = System.nanoTime();

        ExibicaoView.exibirTempo("rotina 1", (tempoFim - tempoInicio) / 1000000);
    }

    public static void executarRotinaSequencial(List<Integer> lista, long quantidadeNumeros, int inicio, int fim) {
        long tempoInicio = System.nanoTime();
        UtilidadesModel.popularLista(lista, quantidadeNumeros, inicio, fim, false);
        long tempoFim = System.nanoTime();

        ExibicaoView.exibirTempo("rotina 2", (tempoFim - tempoInicio) / 1000000);
    }
}
