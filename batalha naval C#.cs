 using System;

namespace BATALHANAVALCSHARP
{
    public class BATALHANAVALCSHARP
    {
        static void Main(String[] args)
        {
            double contador = 3, bauposicaox=0, bauposicaoy=0,
                   chutebaux=0, chutebauy=0,
                   numerodevezes = 0;
            double[] bombasx = new double[3];
            double[] bombasy = new double[3];
            double[] vidasextrasx = new double[3];
            double[] vidasextrasy = new double[3];
            Console.WriteLine("****Jogador 1****");
            Console.WriteLine("Escolha a posição das BOMBAS");
            Bombas(ref bombasx,ref  bombasy);
            Console.WriteLine("Escolha a posição das VIDAS EXTRAS");
            vidasExtras(ref vidasextrasx, ref vidasextrasy);
            Console.WriteLine("Escolha a posição do BAÚ DO TESOURO\nPrimeiro x e Depois o y");
            bauTesouro(ref bauposicaox, ref bauposicaoy);
            Console.WriteLine("****VEZ DO JOGADOR 2****");
            chute(ref vidasextrasx, ref vidasextrasy,ref bombasx, ref bombasy, 
                    ref chutebaux, ref chutebauy,ref bauposicaox,ref bauposicaoy);
            verifica(ref contador,ref numerodevezes, ref bauposicaox, ref bauposicaoy);
            
            static void verifica(ref double contador,ref double numerodevezes, ref double bauposicaox,ref double bauposicaoy)
            {
                if (contador == 0)
                {
                    Console.WriteLine("VOCÊ PERDEU");
                    Console.WriteLine("Numero de tentativas: " + numerodevezes);
                    Console.WriteLine($"O TESOURO ESTAVA NA POSICAÇÃO X: {bauposicaox} E NA POSIÇÃO Y: {bauposicaoy}");
                }
                else
                {
                    Console.WriteLine("VOCÊ GANHOU");
                    Console.WriteLine($"O TESOURO ESTAVA NA POSICAÇÃO X: {bauposicaox} E NA POSIÇÃO Y: {bauposicaoy}");
                }
            }
            static void chute(ref double[] vidasextrasx, ref double[] vidasextrasy,
                ref double[] bombasx, ref double[] bombasy, ref double chutebaux,
                ref double chutebauy, ref double bauposicaox, ref double bauposicaoy,int numerodevezes=0,int contador = 3)
            {
                while (contador > 0)
                {
                    Console.WriteLine("Chute a posição do BAÚ DO TESOURO\nPrimeiro x e Depois o y");
                    chutebaux = double.Parse(Console.ReadLine());
                    chutebauy = double.Parse(Console.ReadLine());

                    if (chutebaux == bombasx[0] && chutebauy == bombasy[0])
                    {
                        Console.WriteLine("ACHOU A BOMBAA! GAME OVER\nTENTE NOVAMENTE");
                        contador = contador - 1;
                    }
                    else if (chutebaux == bombasx[1] && chutebauy == bombasy[1])
                    {
                        Console.WriteLine("ACHOU A BOMBAA! GAME OVER\nTENTE NOVAMENTE");
                        contador = contador - 1;
                    }
                    else if (chutebaux == bombasx[2] && chutebauy == bombasy[2])
                    {
                        Console.WriteLine("ACHOU A BOMBAA! GAME OVER\nTENTE NOVAMENTE");
                        contador = contador - 1;
                    }
                    else if (chutebaux == vidasextrasx[0] && chutebauy == vidasextrasy[0])
                    {
                        Console.WriteLine("VOCÊ GANHOU UMA VIDA\nTENTE NOVAMENTE");
                        contador = contador + 1;
                    }
                    else if (chutebaux == vidasextrasx[1] && chutebauy == vidasextrasy[1])
                    {
                        Console.WriteLine("VOCÊ GANHOU UMA VIDA\nTENTE NOVAMENTE");
                        contador = contador + 1;
                    }
                    else if (chutebaux == vidasextrasx[2] && chutebauy == vidasextrasy[2])
                    {
                        Console.WriteLine("VOCÊ GANHOU UMA VIDA\nTENTE NOVAMENTE");
                        contador = contador + 1;
                    }
                    else if (chutebaux != bauposicaox && chutebauy != bauposicaoy)
                    {
                        Console.WriteLine("VOCÊ ERROU\nTENTE NOVAMENTE");
                        contador = contador - 1;
                    }
                    else if (chutebaux == bauposicaox && chutebauy == bauposicaoy)
                    {
                        Console.WriteLine("VOCÊ ACERTOU");
                        numerodevezes = numerodevezes + 1;
                        break;
                    }
                    numerodevezes = numerodevezes + 1;
                }
            }
        }
        static void bauTesouro(ref double bauposicaox, ref double bauposicaoy)
        {
            bauposicaox = double.Parse(Console.ReadLine());
            bauposicaoy = double.Parse(Console.ReadLine());
        }
        static void vidasExtras(ref double[] vidasextrasx,ref double[] vidasextrasy)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine($"Escolha a posição da {i + 1} VIDA EXTRA\nPrimeiro x e Depois o y");
                vidasextrasx[i] = double.Parse(Console.ReadLine());
                vidasextrasy[i] = double.Parse(Console.ReadLine());
            }
        }
        static void Bombas(ref double[] bombasx, ref double[] bombasy)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine($"Escolha a posição da {i + 1}º BOMBA\nPrimeiro x e Depois o y");
                bombasx[i] = double.Parse(Console.ReadLine());
                bombasy[i] = double.Parse(Console.ReadLine());
            }
        }
    }
}
    
