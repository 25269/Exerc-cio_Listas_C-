using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Funcionario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public double salario { get; private set; }

        public Funcionario(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public Funcionario(int id, string nome, double salario) : this(id, nome)
        {
            this.salario = salario;
        }

        public Funcionario()
        {

        }

        public void AumentaSalario(double porcentagem)
        {
            this.salario += (porcentagem / 100) * salario;
        }

    }
}
