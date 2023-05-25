using Console_MVC.Controller;
using Console_MVC.Model;

//instância do objeto produto
Produto p = new Produto();

//instância do objeto produtoController
ProdutoController controller = new ProdutoController(); 

//chamada do método controlador
controller.CadastrarProduto();

//chamada do método controlador
controller.ListarProdutos();