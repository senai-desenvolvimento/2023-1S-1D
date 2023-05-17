namespace Projeto_Menu_Produto
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }        
        public Marca Marca = new Marca();        
        public Usuario CadastroPor { get; set; }
        
        List<Produto> listaDeProdutos = new List<Produto>();
        
        public void Cadastrar()
        {
            //aqui vai a lógica
            //instanciar o objeto
            //receber os dados e cadastrar nesse objeto
            //armazenar o objeto na lista
        }

        public void Listar()
        {
            //aqui vai a lógica
            //exibir os objetos cadastrados na lista
        }
        
        public void Deletar(int codigo)
        {
            //aqui vai a lógica
            //buscar um objeto na lista pelo seu código
            //remove-lo
        }
        
    }
}