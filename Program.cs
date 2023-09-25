 Console.WriteLine("BEM VINDO A PIZZARIA LASABOR \n ESCOLA UMA OPÇÃO: \n 1/Adcionar Pizza. \n 2/Listar Pizza. \n 3/Criar novo pedido. \n 4/Listar pedido.");
var opcoes = double.Parse(Console.ReadLine());

//Estrutura condicional

if (opcoes == 1)
{
    //dados pizza
Console.WriteLine("Digite o nome da pizza: ");
var nome = Console.ReadLine();
Console.WriteLine("Digite os sabores separados por virgulas: ");
var sabor = Console.ReadLine();

Console.WriteLine("Digite o preço: ");
var preco = Console.ReadLine();
var conversao = Convert.ToDouble(preco);
//dados do cliente

Console.WriteLine("Digite o nome do cliente: ");
var nome1 = Console.ReadLine();
Console.WriteLine("Digite numero de telefone: ");
var telefone = Console.ReadLine();
var conversaoTelefone = Convert.ToDouble(telefone);

var piz = new Pizza();
piz.Nome = nome;
piz.Preco = conversao;
piz.Sabor = sabor;


var dad = new DadosPessoas();
dad.NomeCliente = nome1;
dad.NumeroTel = conversaoTelefone;

Console.WriteLine("Pizza pronta! ");
Console.WriteLine("Cliente: " + dad.NomeCliente);
Console.WriteLine("Telefone: " + dad.NumeroTel);
Console.WriteLine("Nome da pizza: " + piz.Nome);
Console.WriteLine("Preço da pizza: " + piz.Preco);
Console.WriteLine("Sabor da pizza: " + piz.Sabor);

}else if (opcoes ==2)
{
    //lista
    Console.WriteLine("CARDAPIO!");
    
    var names = new List<string> { "Portuguesa", "Baiana", "Muzarela" };
foreach (var name3 in names)
{
    Console.WriteLine($"Pizza {name3.ToUpper()}!");

}

    //switch
    Console.WriteLine("Digite A/para Portuguesa, B/ para Baiana, C/para Muzarela.");
    var op = Console.ReadLine();

    string opc = (op);
    switch(opc){
        case "a":
            Console.WriteLine($"Opção: {op.ToUpper()} -> PORTUGUESA!");
            break;
        case "b":
            Console.WriteLine($"Opção: {op.ToUpper()} -> BAIANA!");
            break;
        case "c":
            Console.WriteLine($"Opção: {op.ToUpper()} -> MUZARELA!");
            break;
        default:
            Console.WriteLine("Digite apenas as letras 'A', 'B' ,'C', e uma por vez.");
            break;
    }

   }
else
{
    Console.WriteLine("Digite apenas os numeros '1', '2' ,'3'e '4', e uma por vez.");


}






// outro pedido
Console.WriteLine("Deseja acrescentar mais uma pizza? 1/sim 2/não");
var outroPedido = Console.ReadLine();
var conversaoPedido = Convert.ToDouble(outroPedido);

//Estrutura condicional

if (conversaoPedido == 1)
{
    Console.WriteLine("Escolha outro pedido.");
    Console.WriteLine();

    Console.WriteLine("Digite o nome da pizza: ");
    var nome = Console.ReadLine();
    Console.WriteLine("Digite os sabores separados por virgulas: ");
    var sabor = Console.ReadLine();

    Console.WriteLine("Digite o preço: ");
    var preco = Console.ReadLine();
    var conversao = Convert.ToDouble(preco);
    //dados do cliente

    Console.WriteLine("Digite o nome do cliente: ");
    var nome1 = Console.ReadLine();
    Console.WriteLine("Digite numero de telefone: ");
    var telefone = Console.ReadLine();
    var conversaoTelefone = Convert.ToDouble(telefone);

    var piz = new Pizza();
    piz.Nome = nome;
    piz.Preco = conversao;
    piz.Sabor = sabor;


    var dad = new DadosPessoas();
    dad.NomeCliente = nome1;
    dad.NumeroTel = conversaoTelefone;

    Console.WriteLine("Segunda Pizza pronta! ");
    Console.WriteLine("Cliente: " + dad.NomeCliente);
    Console.WriteLine("Telefone: " + dad.NumeroTel);
    Console.WriteLine("Nome da pizza: " + piz.Nome);
    Console.WriteLine("Preço da pizza: " + piz.Preco);
    Console.WriteLine("Sabor da pizza: " + piz.Sabor);
    
}else if(conversaoPedido == 2)
{
    Console.WriteLine("Seu pedido estar pronto, obrigado pela preferência.");
}else
{
    Console.WriteLine("Digite apenas os numeros '1' e '2' , e uma por vez.");
}
