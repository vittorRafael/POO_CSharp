using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesBank
{
    public class Assistente : Funcionario
    {
        public string area;
        public string caixaResponsavel;
        public override double salarioTotal()
        {
            Salario = base.Salario + (base.Salario * 0.5);
            return Salario;
        }

        public override string ToString()
        {
            return "Assistente-> " + base.id + " " +
                "\n     Nome: " + base.Nome +
                " " + base.Sobrenome + " \n     CPF: " + base.Cpf
                + " \n     Idade: " + base.Idade + " \n     Salario: " +
                salarioTotal() + " \n     Area: " + this.area +
                " \n     Caixas: ( " + this.caixaResponsavel +
                " ) \n ";
        }
    }
}
