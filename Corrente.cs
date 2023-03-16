using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOcs
{
    public class Corrente : conta
    {
        public override void Creditar(double valor)
        {
            base.saldo = valor;
        }
    }
}
