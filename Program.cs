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
             p1.Apresentar(); 

              retangulo retangulo = new retangulo();
              retangulo.DefinirMedidas(30,1567 );
              Console.WriteLine($"Área: {retangulo.ObterArea()}"); 

            aluno aluno1 = new aluno();
            aluno1.Nota = 3;
            aluno1.Nome = "Igor";
            aluno1.Apresentar();

            professor professor1 = new professor();
            professor1.salario = 2000;
            professor1.Nome = "Jonathas";
            professor1.Idade = 30; */

            Calduladora calculadora1 = new Calduladora();
            Console.WriteLine("Soma da primeira conta: " + calculadora1.Somar(10, 10));
            Console.WriteLine("Soma da segunda conta: " + calculadora1.Somar(30, 120, 360));



        }
    }
}