using SimUDuck.Interfaces;
using System;

namespace SimUDuck.Patos
{
    class PatoSelvagem : IPato
    {
        public void Grasnar()
        {
            Console.WriteLine("Pato Selvagem esta grasnando");
        }

        public void Nadar()
        {
            Console.WriteLine("Pato Selvagem esta nadando");
        }

        public void Nadar(string nome)
        {
            Console.WriteLine("Pato Selvagem " + nome + " esta nadando");
        }

        public void Voar()
        {
            Console.WriteLine("Pato Selvagem esta voando");
        }
    }
}
