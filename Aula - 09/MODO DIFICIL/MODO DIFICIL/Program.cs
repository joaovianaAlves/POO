using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODO_DIFICIL
{
    class Program
    {
        class Animal
        {
            //Jeito dificil
            private string nome;

            public string SettaNome
            {
                set
                {
                    nome = value;
                }
            }

            public string GettaNome
            {

                get
                {
                    return nome;
                }

            }

            public void Comer(string info)
            {
                Console.WriteLine("{0} esta comendo", info);
                Console.ReadKey();


            }
            static void Main(string[] args)
            {
                Animal animal = new Animal();
                animal.SettaNome = "dog";
                animal.Comer(animal.GettaNome);
            }
        }
    }
}
