using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot {
    class Program {
        static void Main(string[] args) {

            string pergunta, resposta;

            do {
                Console.WriteLine("Pergunta-me alguma coisa");

                pergunta = Console.ReadLine();

                switch (pergunta) {
                    case "Como e' que te chamas?":
                        resposta = "Antonio Jose, Toze para os amigos.";
                        Console.WriteLine(resposta);
                        break;
                    case "Como estas?":
                        resposta = "Estou bem obrigado.";
                        Console.WriteLine(resposta);
                        break;
                    case "Quantos anos tens?":
                        resposta = "Nao me parece que seja da tua conta.";
                        Console.WriteLine(resposta);
                        break;
                    case "Qual é a tua comida preferida?":
                        resposta = "Por mim comia pizza e nuggets todos os dias :^)";
                        Console.WriteLine(resposta);
                        break;
                    case "exit":
                        resposta = "Fechar programa";
                        Console.WriteLine(resposta);
                        continue;
                    default:
                        resposta = "Nao tenho resposta para tal pergunta...";
                        Console.WriteLine(resposta);
                        break;
                }

            } while (pergunta != "exit");            
        }
    }
}
