using System;

namespace Validacao
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("insira o seu nome");
                string nome = Console.ReadLine();
                if (nome != "") {
                    break;}
                Console.WriteLine("Espaços vazios não são permitidos");}
            while (true) {
                Console.WriteLine("Digite sua idade");
                int idade = int.Parse(Console.ReadLine());
                if(idade >= 0 && idade <=150) {
                    break;}
                Console.WriteLine("idade invalida");}
            while (true){
                Console.WriteLine("Digite seu salário");
                double salario = double.Parse(Console.ReadLine());
                if (salario > 0){
                    break;}
                Console.WriteLine("Resposta inválida");}
            while (true){
                Console.WriteLine("Estado civil - digite apenas a primeira letra");
                Console.WriteLine("'s'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a))");
                string estado = Console.ReadLine();
                if (estado == "s" || estado == "c" || estado == "v" || estado == "d"){
                    break;}
                Console.WriteLine("Resposta inválida");}
            Console.WriteLine("Cadastro Realizado");
        }
    }
}
