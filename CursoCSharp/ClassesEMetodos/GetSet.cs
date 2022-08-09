using System;

namespace CursoCSharp.ClassesEMetodos
{
    class GetSet
    {
        public class Moto
        {
            private string Marca;
            private string Modelo;
            private uint Cilindrada;

            public Moto(string marca, string modelo, uint cilindrada)
            {
                //Marca = marca;
                //Modelo = modelo;
                //Cilindrada = cilindrada;
                SetMarca(marca);
                SetModelo(modelo);
                SetCilindrada(cilindrada);
            }

            public Moto() { }

            public string GetMarca()
            {
                return Marca;
            }

            public void SetMarca(string marca)
            {
                Marca = marca;
            }

            public string GetModelo()
            {
                return Modelo;
            }

            public void SetModelo(string modelo)
            {
                Modelo = modelo;
            }

            public uint GetCilindrada()
            {
                return Cilindrada;
            }

            public void SetCilindrada(uint cilindrada)
            {
                Cilindrada = cilindrada;
            }
        }

        public static void Executar()
        {
            var moto = new Moto("CB300", "Honda", 300);

            Console.WriteLine("Modelo: " + moto.GetModelo());
            Console.WriteLine("Marca: " + moto.GetMarca());
            Console.WriteLine("Cilindrada: " + moto.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetModelo("Fazer 250");
            moto2.SetMarca("Yamaha");
            moto2.SetCilindrada(250);

            Console.WriteLine("\nModelo: " + moto2.GetModelo() + "\nMarca: " + moto2.GetMarca() + "\nCilindrada: " + moto2.GetCilindrada());

        }
    }
}
