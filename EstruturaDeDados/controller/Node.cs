﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados.controller
{
    class Node
    {
        public int valor;
        public Node prox;

        public Node(int valor)
        {
            this.valor = valor;
        }
    }
}