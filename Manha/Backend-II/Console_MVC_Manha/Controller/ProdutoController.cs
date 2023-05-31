using Console_MVC.Model;
using Console_MVC.View;

namespace Console_MVC.Controller
{
    public class ProdutoController
    {
        //instanciar objeto produto e produtoView
        // O controller precisa conhecer a Model e a View de produtos

        // Produto Model
        Produto produto = new Produto();

        // Produto View
        ProdutoView produtoView = new ProdutoView();

        //método controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            //lista de produtos chamada pela model
            List<Produto> produtos = produto.Ler();

            //chamada do método de exibição(VIEW) recebendo como argumento a lista
            produtoView.Listar(produtos);
        }

        //método controlador para acessar o cadastro de produto
        public void CadastrarProduto()
        {
            //chamada para a view que recebe cada objeto a ser inserido no csv
            Produto novoProduto = produtoView.Cadastrar();

            //chamada para a model para inserir esse objeto no csv
            produto.Inserir(novoProduto);
        }
    }
}