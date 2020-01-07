using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        public string Titular;
        public double Saldo { get; private set; }
        public int Numero { get; private set; }

        public Conta() { }
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public Conta(int numero, string titular, double saldo) : this(numero, titular){
            Saldo = saldo;
        }
        
        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo = (Saldo - saque) - 5;
        }


        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
