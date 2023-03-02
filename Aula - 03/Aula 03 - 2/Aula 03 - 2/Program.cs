using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03___2
{
    internal class Program
    {  
        class Point 
        { 
            
            private int x,y;
            public Point() 
            {
                Console.WriteLine("Metodo Construtor chamado");
            }

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                Console.WriteLine("Os valores das variaveis sao {0} e {1}" + this.x, this.y);
            }  
        }
        static void Main(string[] args)
        {
            Point num = new Point();
            Console.ReadKey();
            Console.Clear();
            num = new Point(4,5);
            Console.ReadKey();
        }
    }
}
