using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício1

            int exercicio;

            Console.WriteLine("======Menu======")
            Console.WriteLine("exercicio 1");
            Console.WriteLine("exercicio 2");
            Console.WriteLine("exercicio 3");
            Console.WriteLine("exercicio 4");
            Console.WriteLine("exercicio 5");
            Console.WriteLine("exercicio 6");
            
           exercicio = int.Parse(Console.ReadLine());
          
           switch(exercicio);

           case 1:
               Console.WriteLine("Ex dias da semana");
            Console.WriteLine("numero de 1 a 7 correspondente a um dia da semana ");
            dia = int.Parse(Console.ReadLine());

            switch (dia)
            { 
                case 1:
                    Console.WriteLine("numero digitado corresponde a domingo");
                    break;

                case 2:
                    Console.WriteLine("numero digitado corresponde a segunda-feira");
                    break;

                case 3:
                    Console.WriteLine("numero digitado corresponde a terça-feira");
                    break;

                case 4:
                    Console.WriteLine("numero digitado corresponde a quarta-feira");
                    break;

                case 5:
                    Console.WriteLine("numero digitado corresponde a quinta-feira");
                    break;

                case 6:
                    Console.WriteLine("numero digitado corresponde a sexta-feira");
                    break;

                case 7:
                    Console.WriteLine("numero corresponde ao sabado");
                    break;
      








            default:




                //exercício 2
                case 2:
                    switch (formaPagamento)
                    {
                        int main()
                    {
                        float valorTotal, valorFinal;
                        int formaPagamento;

                        << "Digite o valor total da compra: ";
                        cin >> valorTotal;

                        cout << "Selecione a forma de pagamento:" << endl;
                        cout << "1 - Dinheiro (15% de desconto)" << endl;
                        cout << "2 - PIX (10% de desconto)" << endl;
                        cout << "3 - Debito (5% de acréscimo)" << endl;
                        cout << "4 - Credito (10% de acréscimo)" << endl;
                        cin >> formaPagamento;


                        case 1:
                            valorFinal = valorTotal * 0.85;
                            cout << "Valor final a ser pago: R$ " << valorFinal << endl;
                            break;
                        case 2:
                            valorFinal = valorTotal * 0.9;
                            cout << "Valor final a ser pago: R$ " << valorFinal << endl;
                            break;
                        case 3:
                            valorFinal = valorTotal * 1.05;
                            cout << "Valor final a ser pago: R$ " << valorFinal << endl;
                            break;
                        case 4:
                            valorFinal = valorTotal * 1.1;
                            cout << "Valor final a ser pago: R$ " << valorFinal << endl;
                            break;
                        default:
                            cout << "Forma de pagamento invalida" << endl;
                    }

                    return 0;

            //exercício 3 
            class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Digite o número do mês: ");
                int mes = int.Parse(Console.ReadLine());
                Console.Write("Digite o ano: ");
                int ano = int.Parse(Console.ReadLine());
                int dias = 0;

                switch (mes)
                {
                    case 1:
                        Console.WriteLine("Janeiro - 31 dias");
                        break;

                    case 2:
                        if (DateTime.IsLeapYear(ano))
                        {
                            dias = 29;
                        }
                        else
                        {
                            dias = 28;
                        }
                        Console.WriteLine("Fevereiro - " + dias + " dias");
                        break;

                    case 3:
                        Console.WriteLine("Março - 31 dias");
                        break;

                    case 4:
                        Console.WriteLine("Abril - 30 dias");
                        break;

                    case 5:
                        Console.WriteLine("Maio - 31 dias");
                        break;

                    case 6:
                        Console.WriteLine("Junho - 30 dias");
                        break;

                    case 7:
                        Console.WriteLine("Julho - 31 dias");
                        break;

                    case 8:
                        Console.WriteLine("Agosto - 31 dias");
                        break;

                    case 9:
                        Console.WriteLine("Setembro - 30 dias");
                        break;

                    case 10:
                        Console.WriteLine("Outubro - 31 dias");
                        break;

                    case 11:
                        Console.WriteLine("Novembro - 30 dias");
                        break;

                    case 12:
                        Console.WriteLine("Dezembro - 31 dias");
                        break;

                    default:
                        Console.WriteLine("Mês inválido");
                        break;
                }

            }
        }

                 //exercício 4

                int num1, num2;
                char op;

                Console.Write("Digite o primeiro número: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                num2 = int.Parse(Console.ReadLine());

                Console.Write("Digite a operação (+, -, *, / ou ^): ");
                op = char.Parse(Console.ReadLine());

                switch (op)
                {
                    case '+':
                        Console.WriteLine($"Resultado: {num1 + num2}");
                        break;
                    case '-':
                        Console.WriteLine($"Resultado: {num1 - num2}");
                        break;
                    case '*':
                        Console.WriteLine($"Resultado: {num1 * num2}");
                        break;
                    case '/':
                        Console.WriteLine($"Resultado: {num1 / num2}");
                        break;
                    case '^':
                        Console.WriteLine($"Resultado: {Math.Pow(num1, num2)}");
                        break;
                    default:
                        Console.WriteLine("Operação inválida!");
                       break;
                
            }
                  //exercício 5
         static void Main(string[] args)
    {
        // Leitura do salário e do cargo do funcionário
        Console.Write("Digite o salário do funcionário: ");
        double salario = double.Parse(Console.ReadLine());

        Console.Write("Digite o código do cargo do funcionário: ");
        int cargo = int.Parse(Console.ReadLine());

        // Cálculo do novo salário de acordo com o cargo
        double novoSalario;

        switch (cargo)
        {
            case 1: // Professor
                novoSalario = salario * 1.075;
                break;
            case 2: // Secretário
                novoSalario = salario * 1.097;
                break;
            case 3: // Publicitário
                novoSalario = salario * 1.117;
                break;
            case 4: // Jornalista
                novoSalario = salario * 1.089;
                break;
            case 5 : // Mecânico
                novoSalario = salario * 1.1324;
                break;
            case 6 : // Estagiário
                novoSalario = salario * 1.104;
                break;
            case 7 : // Técnico de TI
                novoSalario = salario * 1.146;
                break;
            default: // Outro cargo
                novoSalario = salario * 1.435;
                break;
        }

        // Impressão dos resultados
        Console.WriteLine("Salário antigo: R$ " + salario);
        Console.WriteLine("Novo salário: R$ " + novoSalario);
        Console.WriteLine("Diferença: R$ " + (novoSalario - salario));
    }

    //exercício 6

    class Program
    {
        static void Main(string[] args)
        {
            double salario, imposto, salarioLiquido;

            Console.Write("Digite o salário mensal: R$ ");
            salario = double.Parse(Console.ReadLine());

            if (salario <= 1903.98)
            {
                imposto = 0;
            }
            else if (salario <= 2826.65)
            {
                imposto = salario * 0.075;
            }
            else if (salario <= 3751.05)
            {
                imposto = salario * 0.15;
            }
            else if (salario <= 4664.68)
            {
                imposto = salario * 0.225;
            }
            else
            {
                imposto = salario * 0.275;
            }

            salarioLiquido = salario - imposto;

            Console.WriteLine("Imposto de renda: R$ " + imposto);
            Console.WriteLine("Salário líquido: R$ " + salarioLiquido);
        }
    }


}




