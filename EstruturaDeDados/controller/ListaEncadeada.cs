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
        
        public ListaEncadeada()
        {
            inicio = null;
        }

        public void Add(int x)
        {
            Node n = new Node(x);
            n.prox = inicio;
            inicio = n;
        }
        public string Listar()
        {
            string retorno = "";
            int contador = 1;
            Node n = inicio;
            if (n == null)
            {
                retorno += $"A lista está vazia;";
            }
            else
            {
                do
                {
                    retorno += $"{contador++} - {n.valor}\n";
                    n = n.prox;
                } while (n == null);
            }
            return retorno;
        }
    }
}
