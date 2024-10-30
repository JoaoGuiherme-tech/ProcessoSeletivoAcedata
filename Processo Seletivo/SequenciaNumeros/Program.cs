using System;
using System.Globalization;
using System.Linq;

namespace SequenciaNumeros {
    internal class Program {
        static void Main(string[] args) {


            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Sequencia de Números");
            Console.WriteLine("_____________________");

            Console.WriteLine();

            //Entrada de Dados
            Console.Write("Quantos números você deseja que a sequência tenha ? ");
            int n = int.Parse(Console.ReadLine());

            // Processamento de Dados
            int[] sequencia = new int[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite os números da sequência: ");
                sequencia[i] = int.Parse(Console.ReadLine());
            }

            // saída de dados
            Console.WriteLine("_____________________");
            Console.WriteLine();
            Console.Write("Sequencia Digitada: ");



            for (int i = 0; i < n; i++) {
                Console.Write(sequencia[i] + " "); // retornar os valores digitados em formato de sequência

            }


            int maior = sequencia.Max();// definir o maior valor apresentado na sequência
            int menor = sequencia.Min();// definir o menor valor apresentado na sequência


            Console.WriteLine();
            Console.WriteLine("_____________________");
            Console.WriteLine();

            Console.WriteLine("Maior Número da sequência: " + maior);
            Console.WriteLine("Menor Número da sequência: " + menor);
            Console.WriteLine("_____________________");

            Console.WriteLine();


            Console.ReadKey();


        }
    }
}