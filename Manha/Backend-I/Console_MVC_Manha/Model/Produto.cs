namespace Console_MVC.Model
{
    public class Produto
    {
        //propriedades
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; } 

        //caminho da pasta e do arquivo definido
        private const string PATH =  "Database/Produto.csv";
        
        //criar um construtor
        public Produto()
        {         
            //obter o caminho da pasta   
            string pasta = PATH.Split("/")[0]; //"Database"

            //se não existir uma pasta Database, então cria-se uma
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //se não existir um arquivo csv no caminho, então cria-se um
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }   

        // Retorna uma lista com todos os produtos
        // Trabalha apenas com os dados (Model)
        public List<Produto> Ler()
        {
            //instanciar uma lista de produto
            List<Produto> produtos = new List<Produto>();

            //array de string que recebe cada linha do csv
            string[] linhas = File.ReadAllLines(PATH);

            //para a leitura das linhas
            foreach (string item in linhas)
            {
                //antes do split
                //001;Coca;6,50

                //array que recebe os itens da linha separado por ";"
                string[] atributos = item.Split(";");
                
                //após o split
                //atributo[0] = "001"
                //atibuto[1] = "Coca"
                //atributo[2] = "6,50"

                //instancia de objeto produto
                Produto p = new Produto();

                //atribuir os dados dentro de um objeto
                p.Codigo = int.Parse(atributos[0]);//001
                p.Nome = atributos[1];//"Coca"
                p.Preco = float.Parse(atributos[2]);//6.50f

                //adiciona os objetos dentro da lista
                produtos.Add(p);
            }
            //retorna a lista de produtos 
            return produtos;
        } 

        //método para preparar a linha do csv
        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }

        //método para inserir um produto no arquivo csv
        public void Inserir(Produto p)
        {
            //array que vai armazenar as linhas(cada "objeto")
            string[] linhas = {PrepararLinhasCSV(p)};

            //vai até o arquivo e insere todas as linhas
            File.AppendAllLines(PATH, linhas);
        }   
    }
}