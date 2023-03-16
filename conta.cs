using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOcs
{
    public abstract class conta
    {
        protected double saldo;
        public  abstract void Creditar(double valor);
        public void ExibirConta()
        {
            Console.WriteLine("Seu saldo é: " + saldo);
        }
    }
}
 