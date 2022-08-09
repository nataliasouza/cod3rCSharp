using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;
        string nome;
        public string Nome
        {
            get
            {
                return "\nOpcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        //Propriedade autoimplementada
        public double Preco { get; set; }

        //Somente leitura
        public double PrecoComDesconto
        {
            // get => Preco - (desconto * Preco); - Lambda
            get
            {
                return Preco - (desconto * Preco);
            }
        }

        public CarroOpcional() { }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }   

    public class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2450.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);
            Console.WriteLine("Preço com desconto: R$" + op1.PrecoComDesconto);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine("Preço com desconto: R$" + op2.PrecoComDesconto);
        }
    }
}
