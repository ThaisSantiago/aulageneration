using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------Exercício1-----------------------------------
            
            Console.WriteLine("----Ano de nascimento e Idade-----");
            Console.WriteLine("Digite o ano de nascimento: ");

            int anoNasc = int.Parse(Console.ReadLine());
            int anoAtual = 2022;

            Console.WriteLine($"Sua idade é {anoAtual - anoNasc} ");
            Console.ReadLine(); 

            //-----------------------Exercício2-----------------------------------


            Console.WriteLine("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            int numero3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto número: ");
            int numero4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quinto número: ");
            int numero5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o sexto número: ");
            int numero6 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o sétimo número: ");
            int numero7 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o oitavo número: ");
            int numero8 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nono número: ");
            int numero9 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o décimo número: ");
            int numero10 = int.Parse(Console.ReadLine());

            Console.WriteLine($ "A soma é {numero1 + numero2 + numero3 + numero4+ numero5 + numero6 + numero7 + numero8 + numero9 + numero10 }");
            Console.ReadLine();

            //-----------------------Exercício3-----------------------------------

            int horasTrab;
            float valorHora;
            
            Console.WriteLine("Horas trabalhadas: ");
            int horasTrab = int.Parse(Console.WriteLine));

            Console.WriteLine("Valor da hora: ");
            float valorHora = float.Parse(Console.ReadLine());

            Console.WriteLine($"O funcionário trabalhou {horasTrab} horas. \nO salário é {(horasTrab * valorHora:00.00)}.");
            Console.ReadLine();

            //-----------------------Exercício4-----------------------------------

            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Você tem {idade} anos, representando: {idade * 12} meses * ");
            Console.ReadLine();

            //-----------------------Exercício5-----------------------------------

            Console.WriteLine("Digite o valor em real: ");
            float real = float.Parse(Console.ReadLine());

            float dolar = real / 4.87f;
            float euro = real / 5.21f;
            float libra = real / 6.12f;
            float canadianDollar = real / 3.89f;
            float argentinianPeso = real / 0.040f;
            float chilianPeso = real / 0.0050f;

            Console.WriteLine($"Dólar: $ {dolar:00.00}\nEuro: $ {euro:00.00}\nLibra: $ {libra:00.00}\n" + $"Dólar Canadense: $ {canadianDollar:00.00}\nPeso Argentino: $ {argentinianPeso:00.00}\nPeso Chileno {chilianPeso:00.00}");
            Console.ReadLine();

        }
    }       
            }
