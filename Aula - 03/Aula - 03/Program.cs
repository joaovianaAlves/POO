using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___03
{
    internal class Program
    {
        //class Circle {

        //    private int raio; //Constructor

        //    public Circle()
        //    {
        //        raio = 2;
        //    }

        //    public double Area()
        //    {
        //        return (Math.PI * (raio * raio));
        //    }


        //}

        //class Circle
        //{

        //    private int raio; //Constructor

        //    public Circle()
        //    {
        //        raio = 0;
        //    }

        //    public Circle(int raioinicial) //Constructor overload
        //    {
        //        this.raio = raioinicial;
        //    }

        //    public double Area()
        //    {
        //        return (Math.PI * (raio * raio));
        //    }


        //}

        class Circle
        {

            private int raio; //Constructor

            public Circle()
            {
                raio = 0;
            }

            public Circle(int raioinicial) //Constructor overload
            {
                this.raio = raioinicial;
            }

            public double Area()
            {
                return (Math.PI * (raio * raio));
            }


        }


        static void Main(string[] args)
        {
            Circle c = new Circle(4); // com argumento ele chama o padrao, sem argumento ele chama o sobrecarregado
            double areadocirculo;

            areadocirculo = c.Area();
            Console.WriteLine(areadocirculo);
            Console.ReadKey();

            Circle d = new Circle(4);

            areadocirculo = d.Area();
            Console.WriteLine(areadocirculo);
            Console.ReadKey();
        }
    }
}
