using System;

string mensagemDeBoasVindas = "Bem vindo ao Screend Sound\n";
string[] listaDasBandas = ["0 - U2", "1 - The Beatles", "2 - Calypso", "3 - AC/DC", "4 - Guns N' Roses"];


void ExibirLogo()
{
    Console.WriteLine(@"
        ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
        ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
        ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
        ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
        ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
        ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
}

void ExibirMensagemDeBoasVindas()
{
    Console.Write(mensagemDeBoasVindas);
}

int EscolhaABanda()
{
    Console.WriteLine("Bandas: ");
    for (int i = 0; i < listaDasBandas.Length; i++)
    {
        Console.WriteLine(listaDasBandas[i]);
    }
    Console.Write("\nDigite o número da sua banda: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
  
    switch (opcaoEscolhidaNumerica)
    {
        case 0:
            Console.WriteLine($"Você a banda {listaDasBandas[opcaoEscolhidaNumerica]}");
            break;
        case 1:
            Console.WriteLine($"Você a banda {listaDasBandas[opcaoEscolhidaNumerica]}");
            break;
        case 2:
            Console.WriteLine($"Você a banda {listaDasBandas[opcaoEscolhidaNumerica]}");
            break;
        case 3:
            Console.WriteLine($"Você a banda {listaDasBandas[opcaoEscolhidaNumerica]}");
            break;
        case 4:
            Console.WriteLine($"Você a banda {listaDasBandas[opcaoEscolhidaNumerica]}");
            break;
        case -1:
            Console.WriteLine("Tchau tchau");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    return opcaoEscolhidaNumerica;
}

void IniciarPrograma()
{
    ExibirMensagemDeBoasVindas();
    ExibirLogo();
    EscolhaABanda();
}

IniciarPrograma();