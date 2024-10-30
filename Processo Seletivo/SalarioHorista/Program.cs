using System;
using System.Globalization;

namespace SalarioHorista {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Calculadora Salário - Empregado Horista");
            Console.WriteLine("________________________________________");

            Console.WriteLine();

            // Entrada de Dados 
            Console.Write("Valor Salário Hora:  R$ ");
            string txtSalarioHora = Console.ReadLine();

            // Converção do caractere "," para "."
            string txtSalarioHoraFormatado = txtSalarioHora.Replace(",", ".");

            double salarioHora = double.Parse(txtSalarioHoraFormatado, CI);

            Console.WriteLine();

            Console.Write("Quantidade de Horas Trabalhadas (HH:MM): ");
            string txtHorasTrabalhadas = Console.ReadLine();
            string[] partes = txtHorasTrabalhadas.Split(':'); // Separando os valores do horario digitado dentro de um vetor.
            int horas = int.Parse(partes[0]);
            int minutos = int.Parse(partes[1]);
            double horasTrabalhadas = horas + (minutos / 60.0); // Convertendo minutos para fração de hora.

            Console.WriteLine();

            Console.Write("Quantidade De Filhos Menores que 14 anos: ");
            int qtdFilhos = int.Parse(Console.ReadLine());


            // Processamento de Dados

            double salarioBruto = salarioHora * horasTrabalhadas; // calculo para descobrir o salário Bruto 
            double salarioFamilia;

            //Estrutura para definir o valor do salário familia com base no salário bruto do empregado.
            if (salarioBruto >= 788.00) {
                salarioFamilia = qtdFilhos * 30.50;

            }
            else if (salarioBruto <= 1100.00) {
                salarioFamilia = qtdFilhos * 18.50;

            }
            else {
                salarioFamilia = qtdFilhos * 11.90;
            }


            // Saída de Dados

            Console.WriteLine();
            Console.WriteLine("_________________________________________");

            Console.WriteLine("Salário Bruto Mensal = R$ " + salarioBruto.ToString("F2", CI));
            Console.WriteLine("Salário Familia = R$ " + salarioFamilia.ToString("F2", CI));
            Console.WriteLine("Salário Líquido (Soma do Salário Bruto + Salário Familia) = R$ " + (salarioBruto + salarioFamilia).ToString("F2", CI));
            Console.WriteLine("_________________________________________");
            Console.ReadKey();

        }
    }
}
