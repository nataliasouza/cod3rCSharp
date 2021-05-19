using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Natalia";
            sicrano.Idade = 36;

            //Console.WriteLine($"{cadastro.Nome} tem {cadastro.Idade} anos.");

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "João";
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();

        }
    }
}
