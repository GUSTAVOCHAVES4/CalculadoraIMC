public class Individuo
{
    public string Nome { get; set; }
    public float Altura { get; set; }
    public float Peso { get; set; }
    public double IMC { get => Peso / (Altura * Altura);}
     
     public Individuo(string nome, double altura, double peso)
     {
        Nome = nome;
        Altura = altura;
        Peso = peso;
     }

     public string pesoFaixa ()
     {

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

            public string pesoSituacao ()
            {
                if(imc < 18.50)
            {
                double pesoIdeal = 18.50;
                double pesoNecessario = Math.Round(pesoIdeal - imc, 2);

                Console.WriteLine("Você precisa ganhar {0} Kg", pesoNecessario);
            }

            else if(imc >= 25)
            {
                double pesoIdeal = 24.99;
                double pesoNecessario = Math.Round(imc - pesoIdeal, 2);

                Console.WriteLine("Você precisa perder {0} Kg", pesoNecessario);
            }
            else
            {
                return "Você está com o peso ideal.";
            }

        }
    }
}