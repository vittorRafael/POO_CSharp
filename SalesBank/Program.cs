
using System;
using SalesBank;
using System.Collections.Generic;


namespace SalesBank
{
    class Program
    {
        static void Main(string[] args)
        {
           Seguranca s1 = new Seguranca();
            s1.id = 1;
            s1.Nome = "Rafael";
            s1.Sobrenome = "Sales";
            s1.Cpf = "62263164383";
            s1.Idade = 19;
            s1.area = "Externo";
            s1.turno = "Noite";
           
           Assistente a1 = new Assistente();
            a1.id = 1;
            a1.Nome = "Rafael";
            a1.Sobrenome = "Sales";
            a1.Cpf = "62263164383";
            a1.Idade = 19;
            a1.area = "Interno";
            a1.caixaResponsavel = "1 - 2 - 3 - 4";

           Gerente g1 = new Gerente();
            g1.id = 1;
            g1.Nome = "Rafael";
            g1.Sobrenome = "Sales";
            g1.Cpf = "62263164383";
            g1.Idade = 19;
            g1.area = "Financeiro";



            Console.WriteLine(s1);
            Console.WriteLine(a1);
            Console.WriteLine(g1);

        }
    }
}