using System.Collections.Generic;

namespace projeto.model
{
    class Ordenacao
    {
        public static void bolha(List<int> lista, out int qtdComparacoes, out int qtdTrocas)
        {
            qtdComparacoes = 0;
            qtdTrocas = 0;
            int tmp;

            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = 0; j < lista.Count - 1 - i; j++)
                {
                    qtdComparacoes++;
                    if (lista[j] > lista[j + 1])
                    {
                        qtdTrocas++;
                        tmp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = tmp;
                    }
                }
            }
        }

        public static void selecao(List<int> lista, out int qtdComparacoes, out int qtdTrocas)
        {
            qtdComparacoes = 0;
            qtdTrocas = 0;
            int tmp;

            for (int i = 0; i < lista.Count - 1; i++)
            {
                int menor = i;
                for (int j = i + 1; j < lista.Count; j++)
                {
                    qtdComparacoes++;
                    if (lista[j] < lista[menor])
                    {
                        menor = j;
                    }
                }

                if (menor != i)
                {
                    qtdTrocas++;
                    tmp = lista[i];
                    lista[i] = lista[menor];
                    lista[menor] = tmp;
                }
            }
        }

        public static void insercao(List<int> lista, out int qtdComparacoes, out int qtdTrocas)
        {
            qtdComparacoes = 0;
            qtdTrocas = 0;

            for (int i = 1; i < lista.Count; i++)
            {
                int atual = lista[i];
                int j = i - 1;

                while (j >= 0)
                {
                    qtdComparacoes++;
                    if (lista[j] > atual)
                    {
                        qtdTrocas++;
                        lista[j + 1] = lista[j];
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
                lista[j + 1] = atual;
            }
        }

        public static void agitacao(List<int> lista, out int qtdComparacoes, out int qtdTrocas)
        {
            qtdComparacoes = 0;
            qtdTrocas = 0;

            bool houveTroca;
            int tmp;
            int ini = 0;
            int fim = lista.Count;

            do
            {
                houveTroca = false;
                for (int i = ini; i < fim - 1; i++)
                {
                    qtdComparacoes++;
                    if (lista[i] > lista[i + 1])
                    {
                        qtdTrocas++;
                        houveTroca = true;
                        tmp = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = tmp;
                    }
                }

                if (!houveTroca)
                {
                    break;
                }
                fim--;

                houveTroca = false;
                for (int i = fim; i >= ini + 1; i--)
                {
                    qtdComparacoes++;
                    if (lista[i] < lista[i - 1])
                    {
                        qtdTrocas++;
                        houveTroca = true;
                        tmp = lista[i];
                        lista[i] = lista[i - 1];
                        lista[i - 1] = tmp;
                    }
                }
                ini++;

            } while (houveTroca);
        }
    }
}
