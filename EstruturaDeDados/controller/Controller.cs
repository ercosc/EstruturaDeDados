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

            le.AddFinal(10);
            Console.WriteLine(le.Listar());
            le.AddFinal(20);
            le.AddFinal(30);
            Console.WriteLine(le.Listar());
            le.AddInicio(5);
            Console.WriteLine(le.Listar());
            //le.AddInicio(10);
            //le.AddInicio(20);
            //le.AddInicio(30);
            //Console.WriteLine(le.Listar()); 
            //le.AddFinal(40);
            //le.AddInicio(50);
            //Console.WriteLine(le.Listar());
            //le.AddInicio(60);
            //Console.WriteLine(le.Listar());
        }

    }
}
