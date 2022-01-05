using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSharp
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine("Olá, meu nome é " + (nome) + " e sou um professor com um salario de R$" + (Salario) + ",00");

        }
    }
}
