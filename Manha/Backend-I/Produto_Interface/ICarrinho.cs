namespace Produto_Interface
{
    //interface para a classe Carrinho
    public interface ICarrinho
    {
        //definir(declarar) quais os métodos deverão ser implementados
        //na classe que herdar desta interface

        //CRUD : Create / Read / Update / Delete
        
        //Create
        void Adicionar(Produto _produto);

        //Read
        void Listar();

        //Update
        void Atualizar(int _codigo, Produto _novoProduto);

        //Delete
        void Remover(Produto _produto);
    }
}