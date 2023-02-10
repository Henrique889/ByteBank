using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalFuncionarios { get; private set; }

        public abstract double GetBonificacao();

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalFuncionarios++;
            //Console.WriteLine("Criando um Funcionário");
        }

        public abstract void AumentarSalario();

        public override string ToString()
        {
            return $"Nome : {this.Nome},\n" +
                   $"CPF : {this.Cpf},\n" +
                   $"Salário : {this.Salario}";
        }



    }
}
