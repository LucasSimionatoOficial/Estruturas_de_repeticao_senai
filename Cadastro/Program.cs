using System;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

            string name = "";
            string password = "";
            do {
                Console.WriteLine("Digite seu nome");
                name = Console.ReadLine();
                Console.WriteLine("Agora sua senha");
                password = Console.ReadLine();
                if (name != password){
                    break;
                }
                Console.WriteLine("o nome e a senha devem ser diferentes");
            } while ("ate" != "dar break");
            Console.WriteLine("Cadastro concluído");

        }
    }
}
