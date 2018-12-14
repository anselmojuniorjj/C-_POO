using SimUDuck.Interfaces;
using System;

namespace SimUDuck.Patos
{
    class PatoCabecaVermelha : IPato
    {
        public void Grasnar()
        {
            Console.WriteLine("Pato Cabeca Vermelha esta grasnando");
        }

        public void Nadar()
        {
            Console.WriteLine("Pato Cabeca Vermelha esta nadando");
        }

        public void Nadar(string nome)
        {
            Console.WriteLine("Pato Cabeca Vermelha " + nome + " esta nadando");
        }

        public void Voar()
        {
            Console.WriteLine("Pato Cabeca Vermelha esta voando");
        }
    }
}
