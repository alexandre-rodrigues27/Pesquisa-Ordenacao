package projeto.model;

import java.util.List;
import java.util.Random;

// ============================================
// MODEL - a lógica de gerar/popular os números (a regra de negócio) 
// e a medição de tempo associada a cada rotina
// ============================================

public class UtilidadesModel {
    /**
     * método de classe que popula lista ou com números aleatorios e de forma sequencial dentro de uma faixa
     * @param lista
     * @param quantidadeNumeros
     * @param inicio
     * @param fim
     * @param aleatorio - se true os números devem ser aleatórios
     */
    public static void popularLista(List<Integer> lista, long quantidadeNumeros, int inicio, int fim, boolean aleatorio) {
        Random gerador = new Random();

        if (aleatorio) {
            for (long i = 0; i < quantidadeNumeros; i++) {
                lista.add( gerador.nextInt(inicio, fim) );
            }
        }else {
            for (long i = 0; i < quantidadeNumeros; i++) {
                lista.add((int) (inicio + i));
            }
        }
    }
}
