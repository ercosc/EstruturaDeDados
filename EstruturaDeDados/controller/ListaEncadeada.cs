using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados.controller
{
    class ListaEncadeada
    {
        private Node inicio, fim, no;
        private int tamanho;
        public ListaEncadeada()
        {
            inicio = new Node();
            tamanho = 0;
            fim = inicio;
        }
        public void AddInicio(int x)
        {
            if(tamanho == 0)
            {
                no = new Node();
                no.valor = x;
                inicio = no;
                fim = no;
            } else
            {
                no = new Node();
                no.valor = x;
                no.prox = inicio;
                inicio = no;
            }
            tamanho++;
        }
        public void AddFim(int x)
        {

        }
        public string listar()
        {
            string resultado = "";
            return resultado;
        }

    }
}
