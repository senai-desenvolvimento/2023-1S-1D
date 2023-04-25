using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Alunos_POO
{
    public class Aluno
    {
        //propriedades
        public string Nome;
        public string Curso;
        public string Idade;
        public string Rg;
        public bool Bolsista;
        public float MediaFinal;
        public float ValorMensalidade;

        //métodos
        public float VerMediaFinal()
        {
            return this.MediaFinal;
        }

        // public void VerMediaFinal()
        // {
        //    Console.WriteLine($"{this.MediaFinal}");    
        // }

        public float VerMensalidade()
        {
            //corpo
            float valor;

            if (this.Bolsista == true && this.MediaFinal >= 8)
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

// 100% = 100/100 = 1 ........ 50% = 50/100 = 0.5