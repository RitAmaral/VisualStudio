using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ContaBancaria
    {
        //~~Definição de propriedades:
        public int NumConta { get; } //não tem set porque não se pode alterar o num de conta
        public string Nome { get; set; }
        public double Saldo { get; private set; } //para modificar(set) é privado

        //~~Construtores:
        public ContaBancaria(int numconta, string nome) //este construtor permite instanciar contas bancárias
                                                      //apenas com o nº de conta e o seu titular
        {
            NumConta = numconta;
            Nome = nome;
        }
        //Este 2ºconstrutor permite instanciar uma conta a partir do seu num de conta, nome e tb do seu saldo inicial:
        public ContaBancaria(int numconta, string nome, double saldo):this(numconta, nome) //this = reutilizar código
        {
            Saldo = saldo;
        }

        //~~Secção de Métodos:

        //Este é o método que permite depositar dinheiro na conta
        public void Deposito(double quantia) 
        { Saldo += quantia; }
        //Este é o método que permite fazer o levantamento do dinheiro
        public void Levantamento(double quantia) 
        { Saldo -= quantia + 5.00; }


        public override string ToString()
        {
            return "Conta Bancária número "
                + NumConta
                + ", nome do titular: " + Nome
                + ", saldo: " + Saldo.ToString("F2") + " euros.";
        }
        
    }
}
