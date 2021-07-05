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
    }
}
