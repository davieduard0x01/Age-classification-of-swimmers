using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade_Maior_Menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CLASSIFICAÇÃO DE IDADE  (NADADORES ) ");

            Console.WriteLine("Digite sua idade  : ");

            int idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("CATEGORIA  -- INFANTIL A  ");

            }

            else if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("CATEGORIA  -- INFANTIL B  ");

            }

            else if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine("CATEGORIA  -- JUVENIL A ");

            }

            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("CATEGORIA  -- JUVENIL B ");

            }

            else if (idade >= 18)
            {
                Console.WriteLine("CATEGORIA  ---- \n SÊNIOR ");

            }

            Console.ReadKey();
        }
    }
}
//. Escreva um programa que leia a idade de um nadador e classifique-o em uma das seguintes categorias: