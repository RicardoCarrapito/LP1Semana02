using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string question;
            do
            {
                Console.WriteLine("Insira uma questão:");
                question = Console.ReadLine();


                if(question=="EXIT")
                {
                    break;
                }
                
                else if (question == "És mais inteligente que eu?")
                {
                    Console.WriteLine("Claro que sim");
                }

                else if (question == "Sabes falar quantas linguas?")
                {
                    Console.WriteLine("TODAS");
                }

                else if (question == "Quantos anos tens?")
                {
                    Console.WriteLine("Mais do que possas contar");
                }

                else if (question == "Tens algum género?")
                {
                    Console.WriteLine("Não, não tenho nenhum género definido");
                }
                else
                {
                    Console.WriteLine("Não tenho resposta");
                }



            } while (question != "EXIT");
        }
    }
}
