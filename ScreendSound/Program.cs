using System;

string mensagemDeBoasVindas = "Bem vindo ao Screend Sound\n";
// Um Dictionary armazena pares de chave-valor, onde cada chave é única e associada a um valor.
Dictionary<int, string> listaDasBandas = new Dictionary<int, string>()
{
    {0, "U2"},
    {1, "The Beatles"},
    {2, "Calypso"},
    {3, "AC/DC"},
    {4, "Guns N' Roses"}
};


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

int EscolhaABanda(int home)
{
    // Opção invalida
    int opcaoEscolhidaNumerica = -4;
    if (home == 1)
    {
        Console.WriteLine("Bandas: ");
        foreach (var banda in listaDasBandas)
        {
            Console.WriteLine($"{banda.Key} - {banda.Value}");
        }
        Console.Write("\nDigite o número da sua banda: ");
        string opcaoEscolhida = Console.ReadLine()!;
        opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); // Coloquei negativo por que aqui pode ser 2 ou 3
    }
    else if (home == 2) // Escolha
    {
        opcaoEscolhidaNumerica = -2;
    }
    else if (home == 3) // Exit
    {
        opcaoEscolhidaNumerica = -3;
    }

    switch (opcaoEscolhidaNumerica)
    {
        case -2:
            Console.Clear();
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string bandaRegistro = Console.ReadLine();
            RegistrarBanda(bandaRegistro);
            break;
        case -3:
            Console.WriteLine("Encerrando...");
            break;
        default:
            if (listaDasBandas.ContainsKey(opcaoEscolhidaNumerica))
            {
                Console.WriteLine($"Você escolheu a banda {listaDasBandas[opcaoEscolhidaNumerica]}");
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
            break;
    }
    return opcaoEscolhidaNumerica;
}

void RegistrarBanda(string bandaRegistro)
{
    // Adiciona a nova banda com o próximo número de identificação disponível
    int novoIndice = listaDasBandas.Count;
    listaDasBandas.Add(novoIndice, bandaRegistro);
    Console.WriteLine("Banda adicionada!");
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("Bandas disponíveis: ");
    foreach (var banda in listaDasBandas)
    {
        Console.WriteLine($"{banda.Key} - {banda.Value}");
    }
    Thread.Sleep(1000);
    int resultadoHome = Home(); // Para menu da home 
    EscolhaABanda(resultadoHome); // Para escolher novamente 
}

int Home()
{

    Console.WriteLine("\nDigite 1 se para escolher um banda disponível");
    Console.WriteLine("Digite 2 se deseja registrar uma banda");
    Console.WriteLine("Digite 3 para encerrar");
    string escolhaHome = Console.ReadLine();
    int home = int.Parse(escolhaHome);

    return home;
}
void AoIniciarOPrograma()
{
    ExibirMensagemDeBoasVindas();
    ExibirLogo();
    Console.WriteLine("\n\nBandas inicialmente disponiveis: ");
    foreach (var banda in listaDasBandas)
    {
        Console.WriteLine($"{banda.Key} - {banda.Value}");
    }
    Console.WriteLine("\n\nCrie sua banda ou entre em uma!");
    int registraBanda = Home(); // Armazena o resultado de Home() em uma variável
    EscolhaABanda(registraBanda); // Chama EscolhaABanda() com o resultado de Home()

}

AoIniciarOPrograma();