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
            case 4:
                ExibirMedia();
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
        Console.WriteLine("Dê uma nota de 0 à 10 para esta banda: ");
        int nota = int.Parse(Console.ReadLine()!);
        if (nota > 10 || nota < 0)
        {
            Console.WriteLine("Nota não foi atribuida ");
            Console.WriteLine("A nota tem que ser de 0 à 10");
            Console.WriteLine("Voltando a tela inicial...");
            Thread.Sleep(2000);
            TelaInicial();
        }
        else
        {
            bandasRegistradas[bandaASerAvaliada].Add(nota);
            Console.Clear();
            Console.WriteLine($"Nota {nota} da banda {bandaASerAvaliada} atribuida com sucesso!\n");
            Thread.Sleep(2000);
            TelaInicial();
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"A banda {bandaASerAvaliada} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar à tela inicial");
        Console.ReadKey();
        Console.Clear();
        TelaInicial();

    }

}

// Desafio de calcular a media de todas as bandas
void ExibirMedia()
{
    Console.Clear();
    // Calculo da media de todas as bandas
    foreach (var banda in bandasRegistradas)
    {
        string nomeBanda = banda.Key;
        List<int> notasBanda = banda.Value;
        if (notasBanda.Any()) // Verificação se está vazia
        {
        double mediaNotasBanda = (double) notasBanda.Average();
        double mediaNotasBandaArrendondada = Math.Round(mediaNotasBanda, 2);
        Console.WriteLine($"Media de notas da banda {nomeBanda}:");
        Console.WriteLine(mediaNotasBandaArrendondada);
        } else
        {
            Console.WriteLine($"A banda {nomeBanda} não possui notas registradas.");
        }
        Console.WriteLine();
    }

    Console.WriteLine("Pressione alguma tecla para voltar à tela inicial");
    Console.ReadKey();
    Console.Clear();
    TelaInicial();
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

TelaInicial();

//Desafio dos carros
//Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
//    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
//    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
//    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
//    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
//    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
//};

//Média do Bugatti Veyron
//List<int> bugattiVendidoPorAno = vendasCarros["Bugatti Veyron"] ;
//double mediaBugattiVendidoPorAno = bugattiVendidoPorAno.Average();
//Console.WriteLine(mediaBugattiVendidoPorAno);