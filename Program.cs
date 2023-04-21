using System;

namespace IAGOO
{
 
    // --> Criação da Classe Agencia <-- \\
    class Agencia
    {
        private string numero;
        private string nome;
        private string endereco;

        // --> Constructor <-- \\

        public Agencia(string numero, string nome, string endereco)
        {
            this.numero = numero;
            this.nome = nome;
            this.endereco = endereco;
        }

        // --> Propriedades Getter&Setter <-- \\
        public string Numero
        {
            get { return numero; }
            set { if (value.Trim() != "" ) nome = ""; }
        }

        public string Nome
        {
            get { return nome; }
            set { if (value.Trim() != "" ) nome = ""; }
        }
        
        public string Endereco
        {
            get { return endereco; }
            set { if (value.Trim() != "") nome = ""; }
        }
    
    
    }

    // --> Criação da Classe Conta <-- \\
    class Conta
    {
        private string numero;
        private double saldo;
        private double limite;
        private Agencia agencia;

        // --> Constructor <-- \\
        public Conta(string numero, double saldo, double limite, Agencia agencia)
        {
            this.numero = numero;
            this.saldo = saldo;
            this.limite = limite;
            this.agencia = agencia;
        }

        // --> Criação dos Métodos <-- \\
        public void Sacar(double valor)
        {
            this.saldo -= valor;
        }
        public void Depositar (double valor)
        {
            this.saldo += valor;
        }

        public string verSaldo(double valor)
        {
            return(this.saldo.ToString());
        }


        public void mostrarDados()
        {
            Console.WriteLine("Dados do Cliente:\nNome: %s\nNumero: %f\nLimite %f", this.agencia, this.numero, this.limite);
        }



        // --> Programa Main <-- \\
        public class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Resultados... ");
                Agencia agencia = new Agencia("0045", "Centro", "Rua 1");
                Conta conta = new Conta("115-45", 10, 100, agencia);
                Console.WriteLine("Saldo:" + conta.verSaldo());
            }
        }

    }
}
