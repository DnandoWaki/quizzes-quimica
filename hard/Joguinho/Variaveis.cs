using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joguinho
{
    public class Variaveis
    {
        public int Erros;
        public int calcular()
        {
            this.Erros = 10 - Global.Acerto;
            return this.Erros;
        }
    }
}
