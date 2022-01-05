﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesBank
{
    public class Gerente : Funcionario
    {
        public string area;
        public override double salarioTotal()
        {
            Salario = base.Salario + (base.Salario * 1.5);
            return Salario;
        }

        public override string ToString()
        {
            return "Gerente-> " + base.id + " " +
                "\n     Nome: " + base.Nome +
                " " + base.Sobrenome + " \n     CPF: " + base.Cpf
                + " \n     Idade: " + base.Idade + " \n     Salario: " +
                salarioTotal() + " \n     Area: " + this.area +
                " \n  ";
        }
    }
}
