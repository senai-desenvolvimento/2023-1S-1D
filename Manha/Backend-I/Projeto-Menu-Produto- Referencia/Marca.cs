namespace Projeto_Menu_Produto
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }

        List<Marca> listaDeMarcas = new List<Marca>();

        public Marca Cadastrar()
        {

            //instanciar o objeto
            Marca novaMarca = new Marca();

            //receber os dados e cadastrar nesse objeto
            //armazenar o objeto na lista
            //retornar o objeto criado
            return novaMarca;
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