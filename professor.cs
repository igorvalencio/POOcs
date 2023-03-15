using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOcs
{
    public class professor : Pessoa
    {
        public double salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, e meu salario é {salario}");
        }

    } 

}

