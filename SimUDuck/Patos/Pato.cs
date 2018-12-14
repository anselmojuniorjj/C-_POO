using System;

namespace SimUDuck.Patos
{
    public abstract class Pato
    {
        private string nome;

        public string Nome {
            get { return nome; }
            set {nome = value; } }

        public void Grasnar()
        {
            Console.WriteLine("Grasnando");
        }

        public virtual void Voar()
        {
            Console.WriteLine("Voando");
        }

        public void Nadar()
        {
            Console.WriteLine("Nadanando");
        }

        public void Nadar(string nome)
        {
            Console.WriteLine(nome + " esta Nadanando");
        }
    }
}
