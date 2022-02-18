﻿using System;
using System.IO;


namespace CadastroUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string acao = "";
            string caminho = "usuario.txt";
            string nome = "", email = "", telefone = "", rg = "";

            Console.WriteLine("CADASTRO DE USUÁRIO");
            Console.WriteLine("--------------");
            Console.WriteLine("1 - Adicionar ");
            Console.WriteLine("2 - Listar    ");
            Console.WriteLine("S - Sair  ");
            Console.WriteLine("----------");
            Console.WriteLine("");
            Console.Write("Digite uma operação: ");

            acao = Console.ReadLine().ToUpper();
            Console.WriteLine();

            while (acao != "S")
            {

                if (acao == "1")
                {
                    Console.Write("Informe seu nome: ");
                    nome = Console.ReadLine();

                    Console.Write("Informe seu e-mail: ");
                    email = Console.ReadLine();

                    Console.Write("Informe seu Telefone: ");
                    telefone = Console.ReadLine();

                    Console.Write("Informe seu RG: ");
                    rg = Console.ReadLine();

                    StreamWriter sw = new StreamWriter(caminho, true);

                    sw.WriteLine("Nome: " + nome);
                    sw.WriteLine("E-mail: " + email);
                    sw.WriteLine("Telefone: " + telefone);
                    sw.WriteLine("RG: " + rg);
                    sw.WriteLine("--------------------------------------------------");

                    sw.Close();
                }
                else if (acao == "2")
                {
                    StreamReader sr = new StreamReader(caminho);

                    while (sr.EndOfStream != true)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }

                    sr.Close();
                }

                Console.WriteLine();
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("CADASTRO DE USUÁRIO");
                Console.WriteLine("--------------");
                Console.WriteLine("1 - Adicionar ");
                Console.WriteLine("2 - Listar    ");
                Console.WriteLine("S - Sair  ");
                Console.WriteLine("----------");
                Console.WriteLine("");
                Console.Write("Digite uma operação: ");

                acao = Console.ReadLine().ToUpper();
                Console.WriteLine();

            }
        }
    }
}
