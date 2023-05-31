using Console_MVC_Tarde.Model;
using Console_MVC_Tarde.View;

namespace Console_MVC_Tarde.Controller
{
    public class ProdutoController
    {
        //instância das classes produto e produtoView
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        //método controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            //chamada da model trazendo a lista
            List<Produto> produtos = produto.Ler();
            
            //chamada da view passando a lista
            produtoView.Listar(produtos);
        }

        public void Cadastrar()
        {
           Produto novoProduto = produtoView.Cadastrar();

           produto.Inserir(novoProduto);
        }
    }
}