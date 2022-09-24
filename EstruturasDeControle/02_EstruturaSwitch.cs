﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacaoCSharp.EstruturasDeControle
{
    public class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Auto avaliação de desempenho nos estudos.");
            Console.WriteLine("Informe uma nota de 0 a 5.");
            int.TryParse(Console.ReadLine(), out int nota);

            //var tt = true;
            //if (tt)
            //    Console.WriteLine("Oi");

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Ótimo");
                    break;
                default:
                    Console.WriteLine("Essa nota é inválida!");
                    break;
            }

            // Má prática
            //if (nota != 0 && nota != 1 && nota != 2)
            //{
            //    Console.WriteLine("Essa nota é inválida!");
            //}
        }
    }
}
