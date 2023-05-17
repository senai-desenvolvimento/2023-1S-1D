namespace Projeto_Menu_Produto
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        
        public Usuario()
        {
            Cadastrar();
        }

        public void Cadastrar()
        {
            this.Nome = "Carlos";
            this.Email= "carlos@email.com";
            this.Senha = "1234";
            this.DataCadastro = DateTime.Now;
        }

        public void Deletar()
        {
            this.Nome = "";
            this.Email= "";
            this.Senha = "";
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }       
    }
}