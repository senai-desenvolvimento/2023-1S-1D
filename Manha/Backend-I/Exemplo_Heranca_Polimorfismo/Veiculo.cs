namespace Carlos
{
    //classe abstrata
    public abstract class Veiculo
    {
        //propriedades = atalho "prop"
        public string Modelo { get; set; }        
        public string Cor { get; set; }

        //método abstrato = "abstract"
        //não tem corpo no método abstrato
        public abstract void Ligar();

        //método "normal"
        public void Desligar()
        {
            Console.WriteLine($"Desligando...");
        }       
    }
}