using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] voto = new int[10];
            int i;
            int cand01 = 0, cand02 = 0, lidos = 0, nulo = 0, em_branco = 0;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Bem vindo ao Sistema de Votos");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            Console.WriteLine("Cada número representa uma ação, verifique a tabela a seguir: ");
            Console.WriteLine();
            Console.WriteLine("[ 1 ] - Candidado 01 => Votar para: | Zeca do Povo |");
            Console.WriteLine("[ 2 ] - Candidado 02 => Votar para: | Celsinho Amizade |");
            Console.WriteLine("[ 3 ] - * Voto em Branco *");
            Console.WriteLine("[ 4 ] - * Voto Nulo *");
            Console.WriteLine();
            Console.WriteLine("Escolha o seu voto e digite: ");
            Console.WriteLine();


            for (i = 0; i < 10; i++)

            {
                voto[i] = int.Parse(Console.ReadLine());
            }


            for (i = 0; i < 10; i++)

                if (voto[i] >= 1 && voto[i] <= 4)
                {
                Console.WriteLine("- Voto Validado -");
                }

                else
                {
                Console.WriteLine("*** VOTO INVÁLIDO ***");
                }

            for (i = 0; i < 10; i++)

                if (voto[i] == 1)

                {
                    cand01++;

                    lidos++;
                }


                else

                {

                    if (voto[i] == 2)

                    {
                        cand02++;

                        lidos++;
                    }


                    if (voto[i] == 3)

                    {
                        em_branco++;

                        lidos++;
                    }



                    if (voto[i] == 4)

                    {
                        nulo++;

                        lidos++;
                    }


                }


            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("---------- Compilação dos dados obitidos ----------");
            Console.WriteLine();
            Console.WriteLine("Total de votos para o candidato |Zeca do Povo| : {0}", cand01);
            Console.WriteLine("Total de votos para o candidato |Celsinho Amizade| : {0}", cand02);
            Console.WriteLine("Total de votos em Branco: {0}", em_branco);
            Console.WriteLine("Total de votos Nulo: {0}", nulo);
            Console.WriteLine("Total de votos lidos pelo Programa: {0}", lidos);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();


            if (cand01 > cand02)

            {
                Console.WriteLine("===> Candidato Zeca do Povo ganhou a eleição <===");
            }


            else

            {
                Console.WriteLine("===> Candidato Celsinho Amizade ganhou a eleição <===");
            }


            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("---------Fim do Programa----------");
            Console.ReadKey();
            return;
        }
    }
}
