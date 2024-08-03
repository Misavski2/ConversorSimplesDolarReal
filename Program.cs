using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Teste
{

    class Program
    {

        static void Main(string[] args)
        {
            //valor em dolar x valor em real =  conversao em dolar
            while (true)
            {
                Console.WriteLine("--------CONVERSOR EM REAIS------------");
                Console.WriteLine("Quantos dolares voce quer converter?");
                Console.WriteLine("--------------------------------------");

                string? quantidade = Console.ReadLine();

                if (float.TryParse(quantidade, out float dolares))
                {

                    float resultado = converter(dolares);
                    Console.WriteLine($"O valor de {dolares} dolares foi convertido para {resultado} reais.");

                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida, por favor insira um número válido.");
                }
            }

        }

        static float converter(float num)
        {
            float dolar = 5.70f;
            float conversao = num * dolar;

            return conversao;
        }
    }
}