using System;
using POO_CSharp;
using System.Collections.Generic;


namespace POO_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Corrente c1 = new Corrente();

            c1.Creditar(100);

            c1.ExibirSaldo();
            
            /* Aluno p1 = new Aluno();
            p1.nome = "Rafael";
            p1.idade = 19;
            p1.Nota = 10;
            p1.Apresentar();
            
            Professor p2 = new Professor();
            p2.nome = "Vittor";
            p2.idade = 20;
            p2.Salario = 2000;
            p2.Apresentar();

            */
        }
    }
}