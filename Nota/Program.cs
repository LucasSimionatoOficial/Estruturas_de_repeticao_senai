using System;

namespace Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

            Console.WriteLine("Digite a nota");
            double nota = double.Parse(Console.ReadLine());
            while (nota < 0 || nota > 10) {
                Console.WriteLine("apenas números de 0 a 10");
                nota = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nota registrada");
        }
    }
}
