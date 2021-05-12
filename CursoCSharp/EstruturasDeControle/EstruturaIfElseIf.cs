﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota do aluno: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if(nota >= 9.0)
            {
                Console.WriteLine("Quadro de honra! Aprovado!");
            } else if (nota >= 7.0)
            {
                Console.WriteLine("Está aprovado!");
            } else if (nota >= 5.0)
            {
                Console.WriteLine("Em recuperação!");
            } else
            {
                Console.WriteLine("Te vejo na próxima! Reprovado!");
            }
            Console.WriteLine("FIM!");
        }
    }
}
