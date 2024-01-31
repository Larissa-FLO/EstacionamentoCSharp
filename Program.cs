﻿// Declarando variáveis

using LalaCar;

decimal precoInicial = 0;
decimal precoHora = 0;

// Iniciar o sistema
Console.WriteLine("Sejam bem vindos ao LalaCar!");
Console.WriteLine("---------------------------------");

Console.WriteLine("Informe o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço por hora no estacionamento:");
precoHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento
Estacionamento es = new Estacionamento(precoInicial, precoHora);

//Loop

bool menu = true;

while (menu)
{
    Console.Clear();
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Adicionar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículo");
    Console.WriteLine("4 - Sair do sistema");

    switch (Console.ReadLine())
    {
        case "1":
            es.adicionarVeiculo();
            break;
        case "2":
            es.removerVeiculo();
            break;
        case "3":
            es.listarVeiculo();
            break;
        case "4":
            menu = false;
            Console.WriteLine("Você está saindo do sistema...");
            break;

        default: 
            Console.WriteLine("Opção inexistente. Digite uma opção válida.");
            break;
    }

    Console.WriteLine("Digite uma tecla para continuar:");
    Console.ReadLine();

}