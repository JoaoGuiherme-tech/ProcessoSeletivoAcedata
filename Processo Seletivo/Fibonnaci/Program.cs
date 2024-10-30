using System;

namespace Fibonacci {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Sequência de Fibonacci");
            Console.WriteLine("______________________");
            Console.WriteLine();

            // Entrada de Dados
            // Solicita ao usuário a quantidade de valores que serão digitados 
            Console.Write("Qual a quantidade de valores que serão digitados: ");
            int n = int.Parse(Console.ReadLine());

            // vetor responsável por armazenar os valores da sequência
            int[] valores = new int[n];

            Console.WriteLine();
            Console.WriteLine("______________________");
            Console.WriteLine();
            Console.Write("Sequência de Fibonacci com " + n + " valores: ");

            // Variáveis para os cálculos da sequência
            int valorA = 1, valorB = 1, temp = 0;


            //Processamento dos Dados Informados
            for (int i = 0; i < n; i++) {

                // Armazena o valor atual da sequência no vetor
                valores[i] = valorA;

                //Imprime os valores da sequência
                if (i < n - 1) {
                    Console.Write(valorA + " , ");
                }
                else {
                    Console.Write(valorA);
                }

                // Calcula o próximo valor da sequência de Fibonacci
                temp = valorA + valorB;
                valorA = valorB;
                valorB = temp;

            }
            Console.WriteLine();

            //Verificação para saber se o valor de "n" especifícado pelo usuário é apresentado dentro da sequência.
            bool result = false;
            for (int i = 0; i < valores.Length; i++) {

                // Se o valor de "n" for encontrado na sequência, define "result" como verdadeiro e interrompe o loop
                if (valores[i] == n) {
                    result = true;
                    break;

                }

            }
            // Saída de Dados - Onde caso "result" seja "true" ou "false" irá retornar um valor diferente
            Console.WriteLine();
            if (result) {
                Console.WriteLine("O valor " + n + " está na sequência de Fibonacci");
            }
            else {
                Console.WriteLine("O valor " + n + " não está na sequência de Fibonacci");
            }

            Console.WriteLine();


            Console.ReadKey();


        }
    }
}
