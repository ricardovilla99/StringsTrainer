namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inicializa a variável string title, atribui vazio
            string title = "";

            //pede o nome e usa while loop ate a pessoa inserir algo.
            Console.WriteLine("Yeah Bitch\n");
            String nome = "";
            while (nome == "")
            {
                Console.WriteLine("Como é seu nome? \n");
                nome = Console.ReadLine();
            }

            // poe o nome para uppercase
            string NOME = nome.ToUpper();

            // insere na posição index 0 (a primeira pq é 0 indexed) o termo MR.
            string codeName = NOME.Insert(0, "MR. ");

            // prompt com uma pergunta
            Console.WriteLine("Você prefere Cerveja (1), Vinho (2), ou Caipifruta (3)?\nDigite o número correspondente");

            //recebe a resposta e da Parse de string (pq input ReadLine é string) para int.
            int bonsDrink = int.Parse(Console.ReadLine());

            // switch case de acordo com a resposta
            switch (bonsDrink)
            {
                case 1:
                    Console.WriteLine("Boa Escolha!");
                    Console.WriteLine("Seu codinome Dev é " + codeName + " STRONG");
                    Console.WriteLine("Seu nome tem " + NOME.Length + " Caracteres.");
                    title = "STRONG";

                    break;

                case 2:
                    Console.WriteLine("Uma escolha digna.");
                    Console.WriteLine("Seu codinome Dev é " + codeName + " AVERAGE");
                    Console.WriteLine("Seu nome tem " + NOME.Length + " Caracteres.");
                    title = "AVERAGE";
                    break;

                case 3:
                    Console.WriteLine("Hmm... boiola...");
                    Console.WriteLine("Seu codinome Dev é " + codeName + " WEAKLING");
                    Console.WriteLine("Seu nome tem " + NOME.Length + " Caracteres.");
                    title = "WEAKLING";
                    break;

                //caso nao responda de acordo tem uma ação default
                default:
                    Console.WriteLine("Você não respondeu de acordo.");
                    Console.WriteLine("Isso significa baixo QI ou déficit de atenção.");
                    Console.WriteLine("Você deve procurar uma escola e/ou um psiquiatra.");
                    title = "CRAZY";
                    break;
            }
            //converte a variavel que era int para string
            string drinkEscolhido = Convert.ToString(bonsDrink);

            //o motivo de pegar uma string, converter para int, e depois para string de novo é para ter um menu numérico e evitar erros de digitação.

            //switch case de drinkEscolhido, atribui um novo valor em cada caso.
            switch (drinkEscolhido)
            {
                case "1":
                    drinkEscolhido = "Cerveja";
                    break;

                case "2":
                    drinkEscolhido = "Vinho";
                    break;

                case "3":
                    drinkEscolhido = "Caipifruta";
                    break;

                default:
                    drinkEscolhido = "qualquer coisa";
                    break;

            }

            //escreve a frase e concatena com drinkEscolhido (ja com o novo valor atribuido)
            Console.WriteLine("\nMe diga 2 estilos de " + drinkEscolhido + ", um por vez: \n");

            //pede input 2 tipos de drinks
            String drinktype1 = Console.ReadLine();
            String drinktype2 = Console.ReadLine();

           
            Console.WriteLine("\nVocê pratica esportes? Musculação (1), Halterofilismo (2), Artes Marciais (3), Ciclismo (4), Ginástica Olímpica (5), Porra Nenhuma (6) ?\nDigite o número correspondente:");

            //recebe a resposta e da Parse de string (pq input ReadLine é string) para int.
            int esporteEscolhido = int.Parse(Console.ReadLine());

            //converte a variavel que era int para string
            string esporte2 = Convert.ToString(esporteEscolhido);

            //o motivo de pegar uma string, converter para int, e depois para string de novo é para ter um menu numérico e evitar erros de digitação.

            //switch case de esporte
            switch (esporte2)
            {
                case "1":
                    esporte2 = "Musculação";
                    break;

                case "2":
                    esporte2 = "Halterofilismo";
                    break;

                case "3":
                    esporte2 = "Artes Marciais";
                    break;

                case "4":
                    esporte2 = "Ciclismo";
                    break;

                case "5":
                    esporte2 = "Ginástica Olímpica";
                    break;

                case "6":
                    esporte2 = "Porra Nenhuma";
                    break;

                default:
                    esporte2 = "being a lazy bitch";
                    break;

            }

            //da uma mensagem concatenando diversas variaveis e palavras e espaços entre elas
            Console.WriteLine("\nSeu codinome Dev é " + codeName + " " + title + ", e você gosta de " + drinktype1 + " e " + drinktype2 + ". Você pratica " + esporte2 + ".\n\n");


            //mensagem
            Console.WriteLine("Você precisa treinar programação todos os dias.\n\n");

            Console.WriteLine("Você deveria malhar mais também.\n\n");


            //mensagem
            Console.WriteLine("\"Beer is proof that God loves us and wants us to be happy.\"");

            //readkey simplesmente para o programa nao fechar sozinho
            Console.ReadKey();


        }

























    }
}
