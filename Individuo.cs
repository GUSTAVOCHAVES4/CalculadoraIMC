public class Individuo 
{
    public string Nome { get; set; }
    public float Altura { get; set; }
    public float Peso { get; set; }
    public double IMC { get => Peso / (Altura * Altura); }
     
     public Individuo(string nome, float altura, float peso)
     {
         Nome = nome;
         Altura = altura;
         Peso = peso;
     }

     public double Imc { get => peso / (altura * altura); }


}