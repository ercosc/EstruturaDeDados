using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados.controller
{
    class ListaEncadeada
    {
        private Node node;

        public int Add(int x)
        {
            if (node == null)
            {
                node = new Node(x);
                return node.valor;
            }
            else
            {
                return AddProx(x, node);
            }
        }

        private int AddProx(int x, Node node)
        {
            if (node.prox == null)
            {
                node.prox = new Node(x);
            }
            else
            {
                AddProx(x, node.prox);
            }
            return node.prox.valor;
        }
        public string Listar()
        {
            string retorno = "";
            int contador = 1;
            Node n = node;
            if(n == null)
            {
                retorno += $"A lista está vazia;";
            } else
            {
                do
                {
                    retorno += $"{contador++} - {node.valor}\n";
                    n = n.prox;
                } while (n == null);
            }
            return retorno;
        }
    }
}
