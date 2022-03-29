﻿using System;

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

            if (imc < 17.00)
            {
                Console.WriteLine("Muito abaixo do peso");
            }
            else if (imc >= 17.00 && imc < 18.50)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc >= 18.50 && imc < 25.00)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc >= 25.00 && imc < 30.00)
            {
                Console.WriteLine("Acima do peso");
            }
            else if (imc >= 30.00 && imc < 35.00)
            {
                Console.WriteLine("Obesidade I");
            }
             else if (imc >= 35.00 && imc < 40.00)
            {
                Console.WriteLine("Obesidade II (severa)");
            }
            
            {
                Console.WriteLine("Obesidade III (mórbida)");
            }

            Console.WriteLine("{0} sua altura é {1} e seu peso {2}", nome, altura, peso);
            Console.WriteLine("Seu IMC é {0}", imc);
        }
    }
}
