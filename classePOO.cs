using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOcs
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} anos e moro em {Cidade}.");
        }
    }
}
