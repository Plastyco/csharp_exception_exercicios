using csharp_exception_exercicios.Entities.Exceptions;

namespace csharp_exception_exercicios.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
            Holder = "";
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public void Withdraw(double value)
        {
            if (value > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (value > Balance)
            {
                throw new DomainException("Not enough balance");
            }
            Balance -= value;
        }
    }
}