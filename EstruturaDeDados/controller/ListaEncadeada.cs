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
                Node n = PercorrerNo(node);
                n.prox = new Node(x);
                return n.prox.valor;
            }
        }
        public Node PercorrerNo(Node n)
        {
            while (n.prox != null)
            {
                n = node.prox;
            }
            return n;
        }
    }
}
