
using AindaMaisExercicios;
// Ex.7

Notebook notebook = new Notebook("Dell", 12345, 16);

Smartphone smartphone = new Smartphone("Samsung Galaxy", 13452, 500);

Console.WriteLine("=== NOTEBOOK ===");
notebook.ExibirInformacoes();

Console.WriteLine("=== SMARTPHONE ===");
smartphone.ExibirInformacoes();

// Ex.8
List<Animal> animais = new List<Animal>();

animais.Add(new Cachorro("Rex"));
animais.Add(new Gato("Fred"));
animais.Add(new Passaro("Zé"));

Console.WriteLine("=== ANIMAIS ===");
foreach (Animal animal in animais)
{
    Console.WriteLine("======");
    animal.Apresentar();
    animal.EmitirSom();
}

// Ex. 9
Console.WriteLine("=== SISTEMA DE ARMAZENAMENTO ===");
IArmazenavel armazenamento;
armazenamento = new ArquivoTexto();
armazenamento.Salvar("Meu primeiro arquivo");
armazenamento.Ler();

armazenamento = new BancoDados();

armazenamento.Salvar("Meu primeiro registro");
armazenamento.Ler();

// Ex.10
Console.WriteLine("=== SISTEMA DE SERVIÇOS ===");
IContratavel servico1 = new Hospedagem("Hotel Fazenda");
IContratavel servico2 = new Consultoria("Consultoria de TI");

servico1.Contratar();
servico2.Contratar();

Hospedagem hospedagem = new Hospedagem("Hotel Central");

hospedagem.Cancelar();