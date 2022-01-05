using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSharp
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine("Olá, meu nome é " + (nome) + " e sou um diretor ");

        }
    }
}
