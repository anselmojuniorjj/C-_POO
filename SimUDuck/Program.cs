using SimUDuck.Fabrica;
using SimUDuck.Interfaces;
using SimUDuck.Patos;
using System;
using System.Collections.Generic;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<PatoSelvagem> patos = new List<PatoSelvagem>();

            Simulador simulador = new Simulador();
            FabricaPatos fabrica = new FabricaPatos();
            List<IPato> patos = fabrica.ObterPatos();
            foreach (var item in patos)
                simulador.Executar(item);
    

            
            //simulador.Executar(new PatoSelvagem());
            //simulador.Executar(new PatoCabecaVermelha());

            //Console.WriteLine("Pato Selvagem");
            //IPato patoSelvagem = new PatoSelvagem();
            //patoSelvagem.Grasnar();
            //patoSelvagem.Voar();
            //patoSelvagem.Nadar("Jose");

            //Console.WriteLine("Pato Cabeca Vermelha");
            //IPato patoCabecaVermelha = new PatoCabecaVermelha();
            //patoCabecaVermelha.Grasnar();
            //patoCabecaVermelha.Voar();
            //patoCabecaVermelha.Nadar();

            Console.ReadLine();
        }
    }
}
