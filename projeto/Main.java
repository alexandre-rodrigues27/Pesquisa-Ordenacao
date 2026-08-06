package projeto;

import projeto.view.ExibicaoView;
import projeto.controller.ListaController;
import java.util.List;
import java.util.ArrayList;

// ============================================
// MAIN - Ponto de partida do programa. Ela 
// apenas instancia o Controller e inicia o sistema.
// ============================================

public class Main {
    public static void main(String[] args) {
        List<Integer> listaAleatoria = new ArrayList<>();
        List<Integer> listaSequencial = new ArrayList<>();

        ListaController.executarRotinaAleatoria(listaAleatoria, 100000, 100, 100000);
        ListaController.executarRotinaSequencial(listaSequencial, 100000, 1, 100000);

        //Se quiser exibir as listas também:
        ExibicaoView.exibirLista(listaAleatoria, "Lista aleatoria");
        ExibicaoView.exibirLista(listaSequencial, "Lista sequencial");
    }
}
