using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados.controller
{
    class Controller
    {
        public Controller()
        {
            //Fila f = new Fila(new int[20]);
            //Console.WriteLine(f.Save(int.Parse(Console.ReadLine())));
            //Console.WriteLine(f.Save(int.Parse(Console.ReadLine())));
            //Console.WriteLine(f.Listar());
            //Console.WriteLine(f.Save(int.Parse(Console.ReadLine())));
            //Console.WriteLine(f.Listar());
            //Console.WriteLine(f.Save(int.Parse(Console.ReadLine())));
            //Console.WriteLine(f.Remove());
            //Console.WriteLine(f.Listar());

            //Pilha p = new Pilha(new int[3]);
            //Console.WriteLine(p.Save(2));
            //Console.WriteLine(p.Save(20));          
            //Console.WriteLine(p.Pop());
            //Console.WriteLine(p.Save(24));
            //Console.WriteLine(p.Save(2));
            //Console.WriteLine(p.Listar());

            ListaEncadeada le = new ListaEncadeada();

            Console.WriteLine(le.Listar());
            le.AddInicio(5);
            le.AddInicio(10);
            le.AddInicio(15);
            le.AddInicio(20);
            Console.WriteLine(le.Listar());
            le.AddFim(100);
            le.AddFim(200);
            le.AddFim(300);
            Console.WriteLine(le.Listar());

        }

    }
}
