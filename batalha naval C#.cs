 double contador = 3, bomba1x, bomba1y, bomba2x, bomba2y, bomba3x, bomba3y,
            vidasextra1x, vidasextra1y, vidasextra2x, vidasextra2y, vidasextra3x, vidasextra3y,
            bauposicaox, bauposicaoy,
            chutebaux, chutebauy,
            numerodevezes = 0;
            

            Console.WriteLine("****Jogador 1****");
            Console.WriteLine("Escolha a posição das BOMBAS");
            Console.WriteLine("Escolha a posição da PRIMEIRA BOMBA\nPrimeiro x e Depois o y");
            bomba1x = double.Parse(Console.ReadLine());
            bomba1y = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha a posição da SEGUNDA BOMBA\nPrimeiro x e Depois o y");
            bomba2x = double.Parse(Console.ReadLine());
            bomba2y = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha a posição da TERCEIRA BOMBA\nPrimeiro x e Depois o y");
            bomba3x = double.Parse(Console.ReadLine());
            bomba3y = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha a posição das VIDAS EXTRAS");
            Console.WriteLine("Escolha a posição da PRIMEIRA VIDA EXTRA\nPrimeiro x e Depois o y");
            vidasextra1x = double.Parse(Console.ReadLine());
            vidasextra1y = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha a posição da SEGUNDA VIDA EXTRA\nPrimeiro x e Depois o y");
            vidasextra2x = double.Parse(Console.ReadLine());
            vidasextra2y = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha a posição da TERCEIRA VIDA EXTRA\nPrimeiro x e Depois o y");
            vidasextra3x = double.Parse(Console.ReadLine());
            vidasextra3y = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha a posição dO BAÚ DO TESOURO\nPrimeiro x e Depois o y");
            bauposicaox = double.Parse(Console.ReadLine());
            bauposicaoy = double.Parse(Console.ReadLine());
            Console.WriteLine("****VEZ DO JOGADOR 2****");
            do
            {
                Console.WriteLine("Chute a posição do BAÚ DO TESOURO\nPrimeiro x e Depois o y");
                chutebaux = double.Parse(Console.ReadLine());
                chutebauy = double.Parse(Console.ReadLine());

                if (chutebaux == bomba1x && chutebauy == bomba1y)
                {
                    Console.WriteLine("ACHOU A BOMBAA! GAME OVER\nTENTE NOVAMENTE");
                    contador = contador - 1;
                }
                else if (chutebaux == bomba2x && chutebauy == bomba2y)
                {
                    Console.WriteLine("ACHOU A BOMBAA! GAME OVER\nTENTE NOVAMENTE");
                    contador = contador - 1;
                }
                else if (chutebaux == bomba3x && chutebauy == bomba3y)
                {
                    Console.WriteLine("ACHOU A BOMBAA! GAME OVER\nTENTE NOVAMENTE");
                    contador = contador - 1;
                }
                else if (chutebaux == vidasextra1x && chutebauy == vidasextra1y)
                {
                    Console.WriteLine("VOCÊ GANHOU UMA VIDA\nTENTE NOVAMENTE");
                    contador = contador + 1;
                }
                else if (chutebaux == vidasextra2x && chutebauy == vidasextra2y)
                {
                    Console.WriteLine("VOCÊ GANHOU UMA VIDA\nTENTE NOVAMENTE");
                    contador = contador + 1;
                }
                else if (chutebaux == vidasextra3x && chutebauy == vidasextra3y)
                {
                    Console.WriteLine("VOCÊ GANHOU UMA VIDA\nTENTE NOVAMENTE");
                    contador = contador + 1;
                }
                else
                {
                    Console.WriteLine("ERROUUU\nTENTE NOVAMENTE");
                    contador = contador - 1;
                }
                numerodevezes = numerodevezes + 1;
            }
            while (chutebaux != bauposicaox && chutebauy != bauposicaoy || contador>0);
            if(chutebaux == bauposicaox && chutebauy == bauposicaoy)
            {
                Console.WriteLine("PARABENS VOCÊ ACERTOU");
                Console.WriteLine($"NUMERO DE TENTATIVAS ={numerodevezes}");
            }
            else if (contador > 0)
            {
                Console.WriteLine("VOCÊ PERDEU");
                Console.WriteLine($"O TESOURO ESTAVA NA POSICAÇÃO X: {bauposicaox} E NA POSIÇÃO Y: {bauposicaoy}");
            }