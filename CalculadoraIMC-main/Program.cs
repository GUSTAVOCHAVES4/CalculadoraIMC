using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua altura em metros? Ex. 1.65");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o seu peso em Kg? Ex. 70,3");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = Math.Round(peso / (altura * altura), 2);

            Console.WriteLine("{0}, sua altura é {1}m e seu peso é {2}kg", nome, altura, peso);
            Console.WriteLine("Seu IMC é {0}", imc);

            Individuo pessoa = new Individuo (nome, altura, peso);

            Console.WriteLine("Sua faixa de peso é:" + pessoa.pesoFaixa());
            Console.WriteLine("Sua situação é:" + pessoa.pesoSituacao());
            
        }
    }
}