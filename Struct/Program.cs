class Program{


    struct Poder{
        public string nome;
        public string poder;
        public int ataque;
        public Poder (string nome, string poder, int ataque){
            this.nome = nome;
            this.poder = poder;
        }

        public void imprimir(){
            Console.WriteLine($"O nome é {nome}. O poder é {poder}.");
        }
    }

    static void Main(string[] args){
        Poder[] personagens = new Poder[2];
        // BLOOOOOOOOOOOOOOM
        //STELLAAAAAAAAAAAAA
        //MUSAAAAAAAAA
        //AISHAAAA
        //TECNAAAAAAAAAAAAA
        //FLORAAAAAAAAAAA
        //joelma
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Digite o nome:");
            personagens[i].nome = Console.ReadLine();
            Console.WriteLine("Digite o poder:");
            personagens[i].poder = Console.ReadLine();
            personagens[i].imprimir();
        }
        for (int i = 0; i < 2; i++)
        {
            personagens[i].imprimir();
        }
    }

}
