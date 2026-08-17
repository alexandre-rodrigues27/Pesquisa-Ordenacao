using System;
using System.Collections.Generic;

namespace projeto.model
{
    class Util
    {
        public static void popular(List<int> lista, int quantidade)
        {
            Random gerador = new Random();
            for (int i = 0; i < quantidade; i++)
            {
                lista.Add(gerador.Next(100000));
            }
        }
    }
}
