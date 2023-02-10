using ByteBank.Contas;
using ByteBank.Funcionarios;
using ByteBank.Parceria;
using ByteBank.SistemaInterno;
using ByteBank.Titular;
using ByteBank.Utilitario;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args) =>
        #region
            //ContaCorrente contaDoAndre = new ContaCorrente();
            //contaDoAndre.titular = "André Silva";
            //contaDoAndre.numeroAgencia = 15;
            //contaDoAndre.conta = "1010-X";
            //contaDoAndre.saldo = 100;
            //ContaCorrente contaDoAndre2 = new ContaCorrente();
            //contaDoAndre2.titular = "André Silva";
            //contaDoAndre2.numeroAgencia = 15;
            //contaDoAndre2.conta = "1010-X";
            //contaDoAndre2.saldo = 100;

            //contaDoAndre = contaDoAndre2;

            //Console.WriteLine(contaDoAndre==contaDoAndre2);


            // Console.WriteLine("Saldo Atual da conta do André = R$ " + contaDoAndre.saldo);

            /*contaDoAndre.Depositar(100);
            
            Console.WriteLine("Saldo do André Pós Depósito = R$ " + contaDoAndre.saldo);

            if(contaDoAndre.Sacar(300)== true)
            {
                Console.WriteLine("Saldo do André Pós Saque = R$ " + contaDoAndre.saldo);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque");
            }*/
        #endregion
        #region
            //ContaCorrente contaDaMaria = new ContaCorrente();
            //contaDaMaria.titular = "Maria Souza";
            //contaDaMaria.numeroAgencia = 17;
            //contaDaMaria.conta = "1010-5";
            //contaDaMaria.saldo = 350;

            //Console.WriteLine("Saldo Atual da conta da Maria = R$ " + contaDaMaria.saldo);

            //contaDoAndre.Transferir(50, contaDaMaria);
            //Console.WriteLine("Saldo Atual do André = " + contaDoAndre.saldo);
            //Console.WriteLine("Saldo Atual da Maria = " + contaDaMaria.saldo);

            //ContaCorrente contaDoPedro = new ContaCorrente();
            //contaDoPedro.titular = "Pedro Marcio";
            //Console.WriteLine(contaDoPedro.titular);
            //Console.WriteLine(contaDoPedro.saldo);
            //Console.WriteLine(contaDoPedro.numeroAgencia);
            //Console.WriteLine(contaDoPedro.conta);

            //Cliente cliente = new Cliente();
            //cliente.nome = "André Silva";
            //cliente.cpf = "123456879";
            //cliente.profissao = "Analista";

            //ContaCorrente conta = new ContaCorrente();
            //conta.titular = cliente;
            //conta.numeroAgencia = 15;
            //conta.conta = "1010-X";
            //conta.saldo = 100;

            //Console.WriteLine("Titular = " + conta.titular.nome);
            //Console.WriteLine("CPF = " + conta.titular.cpf);
            //Console.WriteLine("Profissão = " + conta.titular.profissao);
            //Console.WriteLine("Nº Conta = " + conta.conta);
            //Console.WriteLine("Nº Agência = " + conta.numeroAgencia);
            //Console.WriteLine("Saldo = " + conta.saldo);

            //ContaCorrente conta2 = new ContaCorrente();
            //conta2.titular = new Cliente();
            //conta2.titular.nome = "José Souza";
            //conta2.titular.profissao = "Tester";
            //conta2.titular.cpf = "6416843222";
            //conta2.conta = "9999-X";
            //conta2.numeroAgencia = 18;
            //conta2.saldo = 500;
            //Console.WriteLine(conta2.titular.nome);

            //ContaCorrente conta3 = new ContaCorrente();
            //conta3.NumeroAgencia = 18;
            //conta3.Conta = "1011-H";
            //conta3.SetSaldo(200);
            //Console.WriteLine(conta3.GetSaldo());
            //Console.WriteLine(conta3.NumeroAgencia);
            //Console.WriteLine(conta3.Conta);

            //ContaCorrente conta4 = new ContaCorrente(18,"1010-X");
            //conta4.SetSaldo(500);
            //conta4.Titular = new Cliente();
            //Console.WriteLine(conta4.GetSaldo());
            //Console.WriteLine(conta4.NumeroAgencia);

            /*ContaCorrente conta5 = new ContaCorrente(283, "1235-H");
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            ContaCorrente conta6 = new ContaCorrente(284, "6832-X");
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            ContaCorrente conta7 = new ContaCorrente(285, "8621-I");
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);*/
        #endregion
        #region
            //Funcionario pedro = new Funcionario("941234568",2000);
            //pedro.Nome = "Pedro Malazar";
            //Console.WriteLine(pedro.Nome);
            //Console.WriteLine(pedro.GetBonificacao());

            //Diretor roberta = new Diretor("456321852");
            //roberta.Nome = "Roberta Daneil";
            //Console.WriteLine(roberta.Nome);
            //Console.WriteLine(roberta.GetBonificacao());

            //GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
            //gerenciador.Registrar(pedro);
            //gerenciador.Registrar(roberta);

            //Console.WriteLine("Total de Bonificações: " + gerenciador.TotalDeBonicacao);
            //Console.WriteLine("Total de Funcionários: " + Funcionario.TotalFuncionarios);

            //pedro.AumentarSalario();
            //roberta.AumentarSalario();

            //Console.WriteLine("Novo Salario do Pedro: R$ " + pedro.Salario);
            //Console.WriteLine("Novo Salario do Roberta: R$ " + roberta.Salario);
        #endregion

            //CalcularBonificacao();

            UsarSistema();
        static void CalcularBonificacao()
        {
            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
            
            Designer ulisses = new Designer("2543668852");
            ulisses.Nome = "Ulisses Souza";

            Diretor paula = new Diretor("098756625");
            paula.Nome = "Paula Pires";

            Auxiliar igor = new Auxiliar("356984523");
            igor.Nome = "Igor Dias";

            GerenteDeContas camila = new GerenteDeContas("986547235");
            camila.Nome = "Camila Oliveira";

            gerenciador.Registrar(camila);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(paula);
            gerenciador.Registrar(ulisses);

            Console.WriteLine("Total de Bonificacao " + gerenciador.TotalDeBonicacao);

        }
        static void UsarSistema()
        {
            Sistema_Interno sistema = new Sistema_Interno();
            Diretor ingrid = new Diretor("545335");
            ingrid.Nome = "Ingrid Solimões";
            ingrid.Senha = "123";

            GerenteDeContas ursula = new GerenteDeContas("165456352");
            ursula.Nome = "Ursula Alcande";
            ursula.Senha = "321";

            ParceiroComercial caio = new ParceiroComercial();
            caio.Senha = "999";

            sistema.Logar(ingrid, "123");
            sistema.Logar(ursula, "963");
            sistema.Logar(caio, "999");

        }
    }
    
}
