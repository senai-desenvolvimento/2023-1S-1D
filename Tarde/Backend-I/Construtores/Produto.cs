namespace construtores
{
    public class Produto
    {
        //propriedades
        public string Nome { get; set; }
        public int Codigo { get; set; }        
        public int Estoque { get; set; }
        
        //método construtor vazio
        public Produto()
        {            
        }

        //método construtor passando o código como obrigatório
        public Produto(int codigo)
        {
            Codigo = codigo;
        }

        //método construtor passando todas as propriedades como obrigatórias
        public Produto(string nome, int codigo, int estoque)
        {
            Nome = nome;
            Codigo = codigo;
            Estoque = estoque;
        }
    }
}