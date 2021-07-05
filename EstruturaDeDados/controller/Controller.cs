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
            Fila f = new Fila(new int[2]);
            Console.WriteLine(f.Save(int.Parse(Console.ReadLine())));
            Console.WriteLine(f.Save(int.Parse(Console.ReadLine())));
            Console.WriteLine(f.Listar());
            Console.WriteLine(f.Remove());
            Console.WriteLine(f.Listar());
            Console.WriteLine(f.Save(int.Parse(Console.ReadLine())));
            Console.WriteLine(f.Listar());
            Console.WriteLine(f.Save(int.Parse(Console.ReadLine())));

        }

    }
}
