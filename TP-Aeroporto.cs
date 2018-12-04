using System;
using System.Collections;
using System.Collections.Generic;

namespace TP_aeroporto
{
    public class Voo
    {
        public int Id { get; set; }
        public string Destino { get; set; }
        public DateTime dateTime { get; set; }
    }

    public class Passageiro
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public long Telefone { get; set; }
        public string Numvoo { get; set; }
        public string Destino { get; set; }
        public DateTime dateTime { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Voo primeiro = new Voo()
            {
                Id = 001,
                Destino = "Minas Gerais",
                dateTime = Convert.ToDateTime("12:20")
            };
            Voo segundo = new Voo()
            {
                Id = 002,
                Destino = "São Paulo",
                dateTime = Convert.ToDateTime("17:00")
            };
            Voo terceiro = new Voo()
            {
                Id = 003,
                Destino = "Rio Grande do Sul",
                dateTime = Convert.ToDateTime("15:30")
            };

            List<Voo> voos = new List<Voo>();
            voos.Add(primeiro);
            voos.Add(segundo);
            voos.Add(terceiro);

            int posicao;
            Queue espera = new Queue();
            List<Passageiro> listaPassageiro = new List<Passageiro>();

            Passageiro passageiro = new Passageiro();

            Passageiro porta1 = new Passageiro()
            {
                Nome = "Deivid",
                CPF = "32546347895",
                Telefone = 31995689781,
                Numvoo = " ",
                dateTime = Convert.ToDateTime("17:00")
            };
            Passageiro porta2 = new Passageiro()
            {
                Nome = "Matheus",
                CPF = "65485235798",
                Telefone = 64989546598,
                Numvoo = " ",
                dateTime = Convert.ToDateTime("17:00")
            };
            Passageiro porta3 = new Passageiro()
            {
                Nome = "Souza",
                CPF = "65498785201",
                Telefone = 11985478521,
                Numvoo = " ",
                dateTime = Convert.ToDateTime("17:00")
            };
            Passageiro porta4 = new Passageiro()
            {
                Nome = "Pedro",
                CPF = "65487915945",
                Telefone = 14998755484,
                Numvoo = " ",
                dateTime = Convert.ToDateTime("17:00")
            };

            //Enqueue é usado para enfileirar as strings
            listaPassageiro.Add(porta1);
            listaPassageiro.Add(porta2);
            listaPassageiro.Add(porta3);
            listaPassageiro.Add(porta4);
            espera.Enqueue(porta1);
            espera.Enqueue(porta2);
            espera.Enqueue(porta3);
            espera.Enqueue(porta4);
            bool sair = false;
            do
            {
                string Destino = "";
                DateTime aux;
                for (int i = 0; i < voos.Count; i++)
                {
                    Destino = primeiro.Destino;
                    aux = primeiro.dateTime;
                    if (aux > segundo.dateTime)
                    {
                        Destino = segundo.Destino;
                    }
                    else if (aux > terceiro.dateTime)
                    {
                        Destino = terceiro.Destino;
                    }
                }
                Console.WriteLine("\n\t\t\t\t\tSeja bem Vindo ao Aeroporto de Confins:\n\n" + "\n\n" +
                    "\t\t\t\t\tOpções Para Voos\n" +
                    "\n\t\t\t\t\t[F1] Lista de Passageiros\n" +
                    "\t\t\t\t\t[F2] Pesquisar\n" +
                    "\t\t\t\t\t[F3] Cadastrar Novo Passageiro\n" +
                    "\t\t\t\t\t[F4] Excluir Passageiro da lista\n" +
                    "\t\t\t\t\t[F5] Mostra Fila de Espera\n" +
                    "\t\t\t\t\t[ESC] SAIR", Destino);
                ConsoleKeyInfo Menu = Console.ReadKey();
                sair = Menu.Key == ConsoleKey.Escape;
                if (Menu.Key == ConsoleKey.F1)
                {
                    posicao = 1;
                    for (int i = 0; i < espera.Count; i++)
                    {
                        Console.WriteLine("\n" + posicao + "°: " + "Nome: {0} " +
                            "CPF: {1} " +
                            "Numero do Voo: 125{2} " +
                            "Destino: SP/{3} " +
                            "Telefone: {4} " +
                            "Horario: {5}",
                            listaPassageiro[i].Nome, listaPassageiro[i].CPF, listaPassageiro[i].Destino, listaPassageiro[i].Telefone, listaPassageiro[i].Telefone, listaPassageiro[i].dateTime);
                        posicao++;
                        Console.ReadKey();
                    }
                }
                else if (Menu.Key == ConsoleKey.F2)
                {
                    Console.WriteLine("Digite o CPF requerido");
                    string CPF = Console.ReadLine();
                    for (int i = 0; i < listaPassageiro.Count && i < 5; i++)
                    {
                        if (CPF == listaPassageiro[i].CPF)
                        {
                            Console.WriteLine("\n" + "Nome: {0} " +
                            "CPF: {1} " +
                            "Numero do Voo: 127{2} " +
                            "Destino: BH/{3} " +
                            "Telefone: {4} " +
                            "Horario: {5}",
                            listaPassageiro[i].Nome, listaPassageiro[i].CPF, listaPassageiro[i].Destino, listaPassageiro[i].Telefone, listaPassageiro[i].Telefone, listaPassageiro[i].dateTime);
                            Console.ReadKey();
                        }
                    }
                }
                else if (Menu.Key == ConsoleKey.F3)
                {
                    bool retornar = false;
                    do
                    {
                        Passageiro cadastrado = new Passageiro();

                        Console.WriteLine("Qual é o seu nome?");
                        cadastrado.Nome = Console.ReadLine();

                        Console.WriteLine("Informe o seu CPF");
                        cadastrado.CPF = (Console.ReadLine());

                        Console.WriteLine("Insira o local de destino");
                        string Numvoo = Console.ReadLine();

                        if (Numvoo == "SP")
                        {
                            cadastrado.Numvoo = "primeiro";
                        }
                        else if (Numvoo == "RE")
                        {
                            cadastrado.Numvoo = "segundo";
                        }
                        else if (Numvoo == "RJ")
                        {
                            cadastrado.Numvoo = "primeiro";
                        }
                        Console.WriteLine("Qual o Telefone para Contato?");
                        passageiro.Telefone = long.Parse(Console.ReadLine());

                        listaPassageiro.Add(cadastrado);
                        espera.Enqueue(cadastrado);

                        Console.WriteLine("Deseja efetuar um novo cadastro? Aperte ESC para retornar");
                        var terminar = Console.ReadKey();

                        retornar = terminar.Key == ConsoleKey.Escape;
                        Console.ReadKey();

                    } while (!retornar);
                }
                else if (Menu.Key == ConsoleKey.F4)
                {
                    //O código Dequeue é usado para desenfileirar
                    espera.Dequeue();

                    Console.WriteLine("\nRemoção feita com Sucesso\n");
                    Console.ReadKey();
                }

                else if (Menu.Key == ConsoleKey.F5)
                {
                    posicao = 6;
                    for (int i = 0; i > 5 && i < espera.Count; i++)
                    {
                        Console.WriteLine("\n" + posicao + "°: " + "Nome: {0} " +
                            "CPF: {1} " +
                            "Numero do Voo: 458{2} " +
                            "Destino: BH/{3} " +
                            "Telefone: {4} " +
                            "Horario: {5}",
                        listaPassageiro[i].Nome, listaPassageiro[i].CPF, listaPassageiro[i].Destino, listaPassageiro[i].Telefone, listaPassageiro[i].Telefone, listaPassageiro[i].dateTime);
                        posicao++;
                        Console.ReadKey();
                    }
                }
            } while (!sair);
        }
    }

}