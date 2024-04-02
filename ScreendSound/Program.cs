using System;

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
// Bandas com notas iniciais
bandasRegistradas.Add("AC/DC", new List<int>
{
    10,
    10,
    9,
});
bandasRegistradas.Add("Iron Maiden", new List<int>
{
    10,
});
bandasRegistradas.Add("Guns Roses", new List<int>
{ }); // Sem notas



void ExibirMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair\n");

    string opcaoEscolhida = Console.ReadLine();
    int opcaoEscolhidaConvertida = int.Parse(opcaoEscolhida);
    {
        switch (opcaoEscolhidaConvertida)
        {
            case 1:
                Console.WriteLine("Digite o nome da banda que quer registrar");
                RegistrarBanda();
                break;
            case 2:
                ExibirBandas();
                break;
            case 3:
                AvaliarBanda();
                break;
            case -1:
                Console.WriteLine("Encerrando...");
                break;
            default:
                break;
        }
    }
}

void RegistrarBanda()
{
    string registroDaBanda = Console.ReadLine();
    bandasRegistradas.Add(registroDaBanda, new List<int> { }); // Como estamos apenas adicionando a banda, poassamos a nota como um "objeto vazio"
    Console.WriteLine("Banda registrada com sucesso");
    Thread.Sleep(1000);
    Console.Clear();
    TelaInicial();
}

void ExibirBandas()
{
    Console.WriteLine("\nBandas:");
    foreach (var item in bandasRegistradas)
    {
        Console.WriteLine(item.Key);
    }
    Thread.Sleep(3000); // Para visualizar as bandas
    Console.Clear();
    ExibirMenu();
}

void AvaliarBanda()
{
    Console.WriteLine("Qual a banda que você deseja avaliar?");
    string bandaASerAvaliada = Console.ReadLine();
    // O método ContainsKey() retorna true se a chave existir no dicionário e false caso contrário.
    if (bandasRegistradas.ContainsKey(bandaASerAvaliada))
    {
        Console.WriteLine("Dê uma nota de 0 a 10 para esta banda: ");
        string nota = Console.ReadLine();
        int notaConvertida = int.Parse(nota);
        bandasRegistradas[bandaASerAvaliada].Add(notaConvertida);
        Console.Clear();
        Console.WriteLine("Nota atribuida com sucesso!\n");
        Console.WriteLine($"Notas da banda {bandaASerAvaliada}: ");
        foreach (var notas in bandasRegistradas[bandaASerAvaliada])
        {
            Console.WriteLine(notas + "\n");
        }
        Console.WriteLine("Digite uma tecla para voltar à tela inicial");
        Console.ReadKey();
        TelaInicial();
    }
    else
    {
        Console.WriteLine($"A banda {bandaASerAvaliada} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar à tela inicial");
        Console.ReadKey();
        TelaInicial();

    }

}

void TelaInicial()
{
    Console.WriteLine("Sinta a energia do rock em cada nota \n");
    Console.WriteLine(@"
        ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
        ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
        ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
        ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
        ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
        ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    ExibirMenu();
}

// Ao iniciar o programa
TelaInicial();