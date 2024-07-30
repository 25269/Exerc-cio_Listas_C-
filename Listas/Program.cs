using System;
using System.Globalization;

namespace Listas
{
    public class Listas
    {
        static void Main(string[] args)
        {
            int idFuncionario;
            string nomeFuncionario;
            double salario;
            var exists = 0;

            Funcionario cadastraFuncionario = new Funcionario();

            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.Write("Quantos funcionários deseja registrar? ");
            int registros = int.Parse(Console.ReadLine());

            for (int i = 0; i < registros; i++)
            {
                Console.Write("Código do funcionário: ");
                idFuncionario = int.Parse(Console.ReadLine());

                Console.Write("Nome do funcionário: ");
                nomeFuncionario = Console.ReadLine();

                Console.Write("Salário do funcionário: ");
                salario = double.Parse(Console.ReadLine());

                if (salario != 0.00)
                {
                    cadastraFuncionario = new Funcionario(idFuncionario, nomeFuncionario, salario);
                    funcionarios.Insert(i, cadastraFuncionario);
                }
                else
                {
                    cadastraFuncionario = new Funcionario(idFuncionario, nomeFuncionario);
                    funcionarios.Insert(i, cadastraFuncionario);
                }

                Console.WriteLine("");

            }

            Console.WriteLine("");
            Console.Write("Digite o código do funcionário que irá receber o aumento: ");
            idFuncionario = int.Parse(Console.ReadLine());

            if(funcionarios.FirstOrDefault(x => x.id == idFuncionario) != null)
            {
                Console.Write("Digite o percentual de aumento: ");
                double percentualAumento = double.Parse(Console.ReadLine());
                cadastraFuncionario.AumentaSalario(percentualAumento);
            }
            else
            {
                Console.WriteLine("Funcionário não existe");
            }

            Console.WriteLine("");
            Console.WriteLine("Lista de funcionários e seus salários: ");
            foreach (var laçoFuncionario in funcionarios)
            {
                Console.WriteLine(laçoFuncionario.id + ", " + laçoFuncionario.nome + ", " + laçoFuncionario.salario.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}