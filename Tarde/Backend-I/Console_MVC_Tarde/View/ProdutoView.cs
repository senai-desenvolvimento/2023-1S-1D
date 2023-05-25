using Console_MVC_Tarde.Model;

namespace Console_MVC_Tarde.View
{
    public class ProdutoView
    {
        //método para exibir os dados da lista no console
        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine($"\nCódigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C}");                
            }
        }

        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o código: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Informe o nome: ");
            novoProduto.Nome = Console.ReadLine();
            
            Console.WriteLine($"Informe o preço: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            return novoProduto;            
        }
    }
}