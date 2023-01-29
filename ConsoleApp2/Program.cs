namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            


            Console.WriteLine("Yeah Bitch\n");
            Console.WriteLine("Como é seu nome? \n");
            String nome = Console.ReadLine();
            

            string NOME = nome.ToUpper();
            string nome2 = NOME.ToLower();
            string codeName = NOME.Insert(0, "MR. ");
            Console.WriteLine("Seu codinome é " + codeName + " KING");
            Console.WriteLine("Seu nome tem " + NOME.Length + " Caracteres.");
            Console.WriteLine("\nMe diga 2 estilos de cerveja: \n");


            String beertype1 = Console.ReadLine();
            String beertype2 = Console.ReadLine();
         

            Console.WriteLine("\nSeu nome é " + codeName + " KING, e você gosta de " + beertype1 + " e " + beertype2 + ".\n\n");
            Console.WriteLine("\"Beer is proof that God loves us and wants us to be happy.\"");


            Console.ReadKey();













        }
    }
}