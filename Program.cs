using POOcs;
using System;
namespace ExemploPOO
{
    class program
    {
        static void Main(string[] args)
        {
          /* Pessoa p1 = new Pessoa();
           p1.Nome = "Igor";
           p1.Idade = 24;
           p1.Cidade = "São Paulo";
           p1.Apresentar(); */

            retangulo r = new retangulo();
            r.DefinirMedidas(30,1567 );
            Console.WriteLine($"Área: {r.ObterArea()}");

        }
    }
}