//instância do objeto carrinho
using Projeto_Produto_Interface;

//instanciar um objeto carrinho para acessar os métodos
Carrinho carrinho = new Carrinho();

//instanciar objeto(s) da classe Produto
Produto p1 = new Produto(1, "GTA V", 52.90f);
Produto p2 = new Produto(2, "Detroit Become Human", 120.50f);
Produto p3 = new Produto(3, "Forza", 100f);

//chama o método Adicionar e passa os objetos como parâmtero
carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

//chama o método Listar
carrinho.Listar();

//chama o método TotalCarrinho
carrinho.TotalCarrinho();

Console.WriteLine($"Após a remoção de um item");

//chama o método Remover
carrinho.Remover(p2);
carrinho.Remover(p3);

//chama o método Listar
carrinho.Listar();

//chama o método TotalCarrinho
carrinho.TotalCarrinho();

Console.WriteLine($"Agora vamos atualizar um objeto");

//criar um objeto com os dados atualizados
Produto _novoProduto = new Produto();
_novoProduto.Nome = "Fifa 2023";
_novoProduto.Preco = 300f; 

//chama o método Atualizar, passando o código de quem quer alterar e o objeto com os dados atualizados
carrinho.Atualizar(1,_novoProduto);

carrinho.Listar();

carrinho.TotalCarrinho();