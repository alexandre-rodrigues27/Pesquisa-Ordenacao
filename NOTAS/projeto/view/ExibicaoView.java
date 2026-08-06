package projeto.view;

import java.util.List;

// ============================================
// VIEW - responsável pela interface com o 
// usuário (neste caso, a saída no console). Apenas
// exibe o que recebe sem processar dadosSS
// ============================================

public class ExibicaoView {
    /**
     * método de classe que exibe conteúdo de uma lista de inteiros
     * @param lista
     * @param frase - para exibir no início do método
     */
    public static void exibirLista(List<Integer> lista, String frase) {
        System.out.println(frase);
        for (Object item : lista) {
            System.out.println(item);
        }
        System.out.println("--------------------------");
        System.out.println("Total de registros: " + lista.size());
    }

    public static void exibirTempo(String nomeRotina, long tempoMilissegundos) {
        System.out.println("Tempo (ms) " + nomeRotina + ": " + tempoMilissegundos);
    }
}
