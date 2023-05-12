namespace Produto_Interface
{
    public class Carrinho : ICarrinho
    {
        public float Valor { get; set; }

        //lista onde vamos manipular os objetos
        List<Produto> carrinho = new List<Produto>();
        //implementar a lógica para cada método
        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Listar()
        {
            if (carrinho.Count > 0 || carrinho != null )
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine($"Código: {p.Codigo} - Nome: {p.Nome} - Preço: {p.Preco:C}");                    
                }
            }
            else
            {
                Console.WriteLine($"Carrinho vazio!");                
            }
        }

        public void Atualizar(int _codigo, Produto _novoProduto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }
        
        public void Remover(Produto _produto)
        {            
            carrinho.Remove(_produto);
        }

        public void ValorTotal()
        {
            Valor = 0;

            if (carrinho.Count > 0 || carrinho != null)
            {
                foreach (Produto item in carrinho)
                {
                    Valor += item.Preco;
                }
                Console.WriteLine($"O total do seu carrinho está em : {Valor:C}");                
            }
            else
            {
                Console.WriteLine($"Seu carrinho está vazio!");                
            }
        }
    }
}