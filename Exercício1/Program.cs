namespace Exercício1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número");
            string numero1 = Console.ReadLine();

            Console.WriteLine("Escreva mais um número");
            string numero2 = Console.ReadLine();

            int num1 = int.Parse(numero1);
            int num2 = int.Parse(numero2);


            int soma = num1 + num2;
            Console.WriteLine("A soma dos números é: " + soma);
        }
    }
}

