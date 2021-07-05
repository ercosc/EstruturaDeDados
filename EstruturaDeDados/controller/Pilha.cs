using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados.controller
{
    class Pilha
    {
        private int contador;
        private int[] dados;
        private int tamanho;
        public Pilha(int[] dados)
        {
            contador = 0;
            tamanho = dados.Length;
            this.dados = dados;
        }

        public string Save(int x)
        {
            if (contador == tamanho)
            {
                return $"A Pilha está cheia!";
            }
            else
            {
                dados[contador++] = x;
                return $"Número {x} adicionado na Pilha na posição {contador}"
            }
        }
    }
}
