using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    // sealed: a classe SavingsAccount não pode ser herdada como Account
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalace()
        {
            Balance += Balance * InterestRate;
        }

        // sealed: Withdraw() não pode ser sobrescrita novamente se SavingsAccount fosse herdada em outra classe
        public sealed override void Withdraw(double amount)
        {
            // base: Acessa a implementanção da superclasse
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
