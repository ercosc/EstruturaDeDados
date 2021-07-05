using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados.controller
{
    class Fila
    {
        private int[] dados;
        private int contador;
        private int tamanho;
        public Fila(int[] dados)
        {
            tamanho = dados.Length;
            contador = 0;
            this.dados = dados;
        }

        public string Save(int x)
        {
            if(contador < tamanho)
            {
            dados[contador++] = x;
            return $"O numero {x} foi adicionado na fila na posição {contador - 1}";
            } else
            {
                return $"A fila está cheia!";
            }
        }

        public string Remove()
        {
            if(contador == 0)
            {
                return $"A Fila já está vazia!";
            } else
            {
                for(int i = 0; i < contador-1; i++)
                {
                    dados[i] = dados[i + 1];
                }
                dados[--contador] = 0;
                return $"elemento removido";
            }
        }
        public string Listar()
        {
            string retorno = "";
            for(int i = 0; i < contador ;i++)
            {
                retorno += $"{i + 1} - {dados[i]}\n";
            }
            return retorno;
        }
    }
}
