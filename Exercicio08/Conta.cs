using System.Globalization;

namespace Exercicio08
{
     class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            //Quando iniciamos uma variavel double por padraão ela tem valor zero.
            Saldo = 0.0;
        }

        public Conta(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta " 
                + Numero
               + ", Titular: "
               + Titular
               + ", Saldo: $ "
              + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
