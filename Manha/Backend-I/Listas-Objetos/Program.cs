using Listas_Objetos;

//Criar uma lista de objetos(produtos)
List<Produto> produtos = new List<Produto>();

//CREATE

//inserir objetos de produtos dentro da lista
//através de uma instância direta (com construtor)
produtos.Add(
    new Produto(1234, "camiseta lacoste", 19.99f)
);
produtos.Add(
    new Produto(1235, "camiseta adidas", 19.99f)
);
produtos.Add(
    new Produto(1236, "camiseta nike", 19.99f)
);

//através de uma instância básica de objeto
Produto camisetaArmani = new Produto(1237,"camiseta armani", 49.90f);
produtos.Add(camisetaArmani);

//READ

Console.WriteLine($"Produtos antes da alteração");
Console.WriteLine($"***************************");

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preco: {item.Preco:C} {produtos.IndexOf(item)}");    
}

//UPDATE

//acessar um objeto da lista para poder manipulá-lo
Produto produtoEncontrado = produtos.Find(x => x.Codigo == 1235);

//encontrar o índice do produto encontrado
int index = produtos.IndexOf(produtoEncontrado);

//exibir o índice no console
Console.WriteLine($"O índice do produto encontrado é o: {index}");

//fazer alterações
produtoEncontrado.Preco = 599f;

//remover o item antigo da lista
produtos.RemoveAt(index);

//devolver o item atualizado no lugar
produtos.Insert(index,produtoEncontrado);

Console.WriteLine($"Produtos depois da alteração");
Console.WriteLine($"***************************");

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preco: {item.Preco:C} {produtos.IndexOf(item)} ");    
}

//DELETE

produtos.RemoveAt(1);

Console.WriteLine($"Produtos após a exclusão");
Console.WriteLine($"***************************");

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preco: {item.Preco:C} {produtos.IndexOf(item)} ");    
}