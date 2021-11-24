using System;

namespace prova
{
    class Program
    {
        static void Main(string[] args)
        {
            //Código feito por Guilherme Matos Santana. 23/11/2021 as 15:13

            int contador = 0;
            Console.SetCursorPosition(10, 1);
            Console.WriteLine("Código feito por Guilherme Matos Santana");
            VoltarInicio:
            Iniciar();
            int opcao = int.Parse(Console.ReadLine());

            do{
            switch(opcao)
            {
                case 1:
                Console.Clear();
                Voltar:
                Pergunta1();
                string opcao1 = (Console.ReadLine());

                switch(opcao1.ToLower())
                {
                    case "a":
                    Console.Clear();
                    break;

                    case "b":
                    Console.Clear();
                    break;

                    case "c":
                    contador++;
                    Console.Clear();
                    break;

                    case "d":
                    Console.Clear();
                    break;

                    case "e":
                    Console.Clear();
                    break;

                    default:
                    Console.Clear();
                    Console.WriteLine("Você digitou uma opção inválida, favor apertar qualquer tecla para responder novamente");
                    Console.ReadKey();
                    goto Voltar;
                    
                }

                Voltar2:
                Pergunta2();
                string opcao2 = (Console.ReadLine());

                switch(opcao2.ToLower())
                {
                    case "a":
                    contador++;
                    Console.Clear();
                    break;

                    case "b":
                    Console.Clear();
                    break;

                    case "c":
                    Console.Clear();
                    break;

                    case "d":
                    Console.Clear();
                    break;

                    case "e":
                    Console.Clear();
                    break;

                    default:
                    Console.Clear();
                    Console.WriteLine("Você digitou uma opção inválida, favor apertar qualquer tecla para responder novamente");
                    Console.ReadKey();
                    goto Voltar2;
                    
                }

                Voltar3:
                Pergunta3();
                string opcao3 = (Console.ReadLine());

                switch(opcao3.ToLower())
                {
                    case "a":
                    Console.Clear();
                    break;

                    case "b":
                    Console.Clear();
                    break;

                    case "c":
                    contador++;
                    Console.Clear();
                    break;

                    case "d":
                    Console.Clear();
                    break;

                    case "e":
                    Console.Clear();
                    break;

                    default:
                    Console.Clear();
                    Console.WriteLine("Você digitou uma opção inválida, favor apertar qualquer tecla para responder novamente");
                    Console.ReadKey();
                    goto Voltar3;
                    
                }

                Voltar4:
                Pergunta4();
                string opcao4 = (Console.ReadLine());

                switch(opcao4.ToLower())
                {
                    case "a":
                    Console.Clear();
                    break;

                    case "b":
                    contador++;
                    Console.Clear();
                    break;

                    case "c":
                    Console.Clear();
                    break;

                    case "d":
                    Console.Clear();
                    break;

                    case "e":
                    Console.Clear();
                    break;

                    default:
                    Console.Clear();
                    Console.WriteLine("Você digitou uma opção inválida, favor apertar qualquer tecla para responder novamente");
                    Console.ReadKey();
                    goto Voltar4;
                    
                }

                Voltar5:
                Pergunta5();
                string opcao5 = (Console.ReadLine());

                switch(opcao5.ToLower())
                {
                    case "a":
                    Console.Clear();
                    break;

                    case "b":
                    Console.Clear();
                    break;

                    case "c":
                    Console.Clear();
                    break;

                    case "d":
                    Console.Clear();
                    break;

                    case "e":
                    contador++;
                    Console.Clear();
                    break;

                    default:
                    Console.Clear();
                    Console.WriteLine("Você digitou uma opção inválida, favor apertar qualquer tecla para responder novamente");
                    Console.ReadKey();
                    goto Voltar5;
                    
                }

                

                break;

                case 2:

                Console.Clear();
                Console.WriteLine("Você Não desejou fazer o quis, programa encerrado!");
                goto FIM;

                default :
                Console.Clear();
                Console.SetCursorPosition(5, 1);
                Console.WriteLine("Você digitou uma opção inválida. Tente novamente.");
                goto VoltarInicio;

                break;

            }

            Console.Clear();
            moldura();
            Console.SetCursorPosition(13, 6);
            Console.WriteLine("QUIZ - Velozes e Furiosos");
            Console.SetCursorPosition(13, 8);
            Console.WriteLine("Você acertou {0} questões", contador);
            Console.SetCursorPosition(19, 10);
            Console.WriteLine("Refazer quiz");
            Console.SetCursorPosition(21, 12);
            Console.WriteLine("1 - Sim");
            Console.SetCursorPosition(21, 13);
            Console.WriteLine("2 - Não");
            Console.SetCursorPosition(11, 15);
            Console.WriteLine("Digite o número da sua opção : ");
            Console.SetCursorPosition(24, 17);
            Console.WriteLine("[  ]");
            Console.SetCursorPosition(25, 17);
            int opcaoFinal = int.Parse(Console.ReadLine());
            
            if(opcaoFinal == 1 )
            {
                opcao = 1;

            } else if(opcaoFinal == 2)
            {
                opcao = 2;

            } else {

                opcao = 2;
                Console.Clear();
                Console.WriteLine("Você digitou Uma opção inválida, Programa encerrado");
                Console.ReadKey();
            }


        }while(opcao == 1);
        FIM:
        Console.Clear();
        Console.WriteLine("Programa encerrado.");
        Console.ReadKey();

        }
        private static void moldura(){

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("##############################################");
            

            for(int posicao = 4; posicao <= 20; posicao ++){
                
                Console.SetCursorPosition(3, posicao);
                Console.WriteLine("#                                            #");
            }

            Console.SetCursorPosition(3, 21);
            Console.WriteLine("##############################################");
        }

        static void Pergunta1()
        {
            moldura();
            Console.SetCursorPosition(9, 6);
            Console.WriteLine("Qual nome da irmã do Torretto ?");
            Console.SetCursorPosition(18, 10);
            Console.WriteLine("a) Alisson");
            Console.SetCursorPosition(18, 11);
            Console.WriteLine("b) Jasmine");
            Console.SetCursorPosition(18, 12);
            Console.WriteLine("c) Mia");
            Console.SetCursorPosition(18, 13);
            Console.WriteLine("d) Cristina");
            Console.SetCursorPosition(18, 14);
            Console.WriteLine("e) Stefanny");
            Console.SetCursorPosition(8, 16);
            Console.WriteLine("Digite a letra da resposta correta");
            Console.SetCursorPosition(23, 18);
            Console.WriteLine("[  ]");
            Console.SetCursorPosition(25, 18);

        }
        static void Pergunta2()
        {
            moldura();
            Console.SetCursorPosition(6, 6);
            Console.WriteLine("Em que cidade Foi o Velozes e Furiosos 5");
            Console.SetCursorPosition(18, 10);
            Console.WriteLine("a) Rio de janeiro");
            Console.SetCursorPosition(18, 11);
            Console.WriteLine("b) Chicago");
            Console.SetCursorPosition(18, 12);
            Console.WriteLine("c) Los angeles ");
            Console.SetCursorPosition(18, 13);
            Console.WriteLine("d) São Paulo");
            Console.SetCursorPosition(18, 14);
            Console.WriteLine("e) Barcelona");
            Console.SetCursorPosition(8, 16);
            Console.WriteLine("Digite a letra da resposta correta");
            Console.SetCursorPosition(23, 18);
            Console.WriteLine("[  ]");
            Console.SetCursorPosition(25, 18);
           
        }
        static void Pergunta3()
        {
            moldura();
            Console.SetCursorPosition(8, 6);
            Console.WriteLine("Qual personagem era um policial ?");
            Console.SetCursorPosition(18, 10);
            Console.WriteLine("a) Letty");
            Console.SetCursorPosition(18, 11);
            Console.WriteLine("b) Torretto");
            Console.SetCursorPosition(18, 12);
            Console.WriteLine("c) Brian");
            Console.SetCursorPosition(18, 13);
            Console.WriteLine("d) Vince");
            Console.SetCursorPosition(18, 14);
            Console.WriteLine("e) The rock");
            Console.SetCursorPosition(8, 16);
            Console.WriteLine("Digite a letra da resposta correta");
            Console.SetCursorPosition(23, 18);
            Console.WriteLine("[  ]");
            Console.SetCursorPosition(25, 18);
            
        }
        static void Pergunta4()
        {
            moldura();
            Console.SetCursorPosition(8, 6);
            Console.WriteLine("Qual era o Nome do filho do Vince");
            Console.SetCursorPosition(18, 10);
            Console.WriteLine("a) Nicholas");
            Console.SetCursorPosition(18, 11);
            Console.WriteLine("b) Dominic");
            Console.SetCursorPosition(18, 12);
            Console.WriteLine("c) Guilherme");
            Console.SetCursorPosition(18, 13);
            Console.WriteLine("d) Eduardo");
            Console.SetCursorPosition(18, 14);
            Console.WriteLine("e) Edenilson");
            Console.SetCursorPosition(8, 16);
            Console.WriteLine("Digite a letra da resposta correta");
            Console.SetCursorPosition(23, 18);
            Console.WriteLine("[  ]");
            Console.SetCursorPosition(25, 18);
            
        }
        static void Pergunta5()
        {
            moldura();
            Console.SetCursorPosition(6, 6);
            Console.WriteLine("Quem morre nos velozes e furiosos 5");
            Console.SetCursorPosition(18, 10);
            Console.WriteLine("a) Dominic");
            Console.SetCursorPosition(18, 11);
            Console.WriteLine("b) Mia");
            Console.SetCursorPosition(18, 12);
            Console.WriteLine("c) Letty");
            Console.SetCursorPosition(18, 13);
            Console.WriteLine("d) Bria");
            Console.SetCursorPosition(18, 14);
            Console.WriteLine("e) Vince");
            Console.SetCursorPosition(8, 16);
            Console.WriteLine("Digite a letra da resposta correta");
            Console.SetCursorPosition(23, 18);
            Console.WriteLine("[  ]");
            Console.SetCursorPosition(25, 18);
            
        }

        static void Iniciar()
        {
            moldura();
            Console.SetCursorPosition(13, 6);
            Console.WriteLine("QUIZ - Velozes e Furiosos");
            Console.SetCursorPosition(19, 9);
            Console.WriteLine("Iniciar quiz");
            Console.SetCursorPosition(21, 12);
            Console.WriteLine("1 - Sim");
            Console.SetCursorPosition(21, 13);
            Console.WriteLine("2 - Não");
            Console.SetCursorPosition(11, 15);
            Console.WriteLine("Digite o número da sua opção : ");
            Console.SetCursorPosition(24, 17);
            Console.WriteLine("[  ]");
            Console.SetCursorPosition(25, 17);

        }
    }
}
