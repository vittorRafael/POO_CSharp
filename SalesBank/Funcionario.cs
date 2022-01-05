using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesBank
{
    public abstract class Funcionario
    {
        public int id;
        public string Nome;
        public string Sobrenome;
        public string Cpf;
        public int Idade;
        protected double Salario = 1100;

        public abstract double salarioTotal();


    }
}
