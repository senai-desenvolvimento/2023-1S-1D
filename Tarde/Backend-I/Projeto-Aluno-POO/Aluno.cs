namespace Projeto_Aluno_POO
{
    //Classe
    public class Aluno
    {
        //atributos (caracteristicas) ou propriedades
        public string Nome;
        public string Curso;
        public string Idade;
        public string Rg;
        public bool Bolsista;
        public float MediaFinal;
        public float ValorMensalidade;

        //métodos (comportamentos) ou funções
        public float VerMediaFinal()
        {
            return this.MediaFinal;
        }

        // public void VerMediaFinal()
        // {
        //     Console.WriteLine($"{this.MediaFinal}");            
        // } 

        public float VerMensalidade()
        {
            float valor;

            if (this.Bolsista == true  && this.MediaFinal >= 8)
            {
                valor = this.ValorMensalidade * 0.5f;
            }
            else if (this.Bolsista == true && this.MediaFinal > 6) 
            {
                valor = this.ValorMensalidade * 0.7f;
            }
            else
            {
                valor = this.ValorMensalidade;
            }

            return valor;
        }
    }
}

// obs:

// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral