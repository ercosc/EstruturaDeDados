using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados.controller
{
    class ListaEncadeada
    {
        private Node inicio;
        private Node node;
        
        public ListaEncadeada()
        {
            inicio = null;
        }

        public int Add(int x)
        {
            node = new Node(x);
            node.prox = inicio;
            inicio = node;
            return node.valor;
        }
        public string Listar()
        {
            Node n = node;
            string retorno = "";
            int contador = 1;
            if(node == null)
            {
                retorno += $"A lista está vazia.";
            } else
            {
                while (n != null)
                {
                    retorno += $"{contador++} - {n.valor}\n";
                    n = n.prox;
                }
            }
            return retorno;
        }
    }
}
