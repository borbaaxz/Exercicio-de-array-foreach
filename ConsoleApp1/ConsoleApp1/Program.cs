using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista fixa de números secretos
        List<int> numerosSecretos = new List<int> { 3, 6, 9, 12, 15, 18 };

        while (true)
        {
            Console.Write("Digite um palpite (número negativo para sair): ");
            int palpite = int.Parse(Console.ReadLine());

            // Se for negativo, encerra
            if (palpite < 0)
            {
                Console.WriteLine("Programa encerrado.");
                return;
            }

            bool acertou = false;

            foreach (int numero in numerosSecretos)
            {
                // Pula se for par
                if (numero % 2 == 0)
                {
                    continue;
                }

                // Se acertar
                if (palpite == numero)
                {
                    Console.WriteLine("Acertou!");
                    acertou = true;
                    break; // sai do foreach
                }
            }

            // Se não acertou nenhum
            if (!acertou)
            {
                Console.WriteLine("Não acertou, tente outro.");
            }
        }
    }
}
