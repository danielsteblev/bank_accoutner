using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_accounter
{
    class BankAccount
    {

        // Свойства, доступные только для чтения
        public string BankName { get; }
        public string INN { get; }
        public string BIK { get; }
        public string Owner { get; }

        private decimal _balance; // Сумма на счету
        private decimal _creditLimit; // Доступные кредитные средства
        private decimal _creditUsed; // Использованные кредитные средства
        private decimal _commissionRate; // Комиссия за снятие кредита
        private decimal _interestRate; // Процент на кредит

        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Баланс не может быть отрицательным.");
                _balance = value;
            }
        }
        public decimal CreditLimit
        {
            get { return _creditLimit; }
       
        }
        public decimal ComissionRate
        {
            get { return _commissionRate; }
        }
        public decimal InterestRate
        {
            get { return _interestRate; }
 
        }

        public decimal CreditUsed
        {
            get { return _creditUsed; }

        }


        // Конструктор для инициализации свойств
        public BankAccount(string bankName, string inn, string bik, string owner, 
            decimal creditLimit, decimal commissionRate, decimal interestRate)
        {
            BankName = bankName;
            INN = inn;
            BIK = bik;
            Balance = 0;
            Owner=owner;
            _creditLimit = creditLimit;
            _commissionRate = commissionRate;
            _interestRate = interestRate;
            _creditUsed = 0;
        }

        public void TakeCredit(decimal amount)
        {
            if (amount < 0) throw new ArgumentException("ЗНАЧЕНИЕ ДОЛЖНО БЫТЬ > 0!");

            if (_creditUsed + amount > _creditLimit) throw new ArgumentException("Превышен лимит кредита!");

            _creditUsed += amount;

            Balance += amount;

            Balance -= (amount / 100 * _commissionRate); 
        }

        public void PutMoney(decimal amount)
        {
            if (amount <= 0) { throw new ArgumentException("Сумма должна быть > 0!"); }

            Balance += amount;
            Console.WriteLine("Средства успешно зачислены на счёт!");
        }

        public void GetMoney(decimal amount)
        {

            if (amount <= 0) 
            { 
                throw new ArgumentException("Сумма должна быть > 0!");
            }

            if (Balance - amount >= 0)
            {
                Balance  = Balance - amount;
                Console.WriteLine("Средства успешно сняты со счёта!");
            } 
            else
            {
                throw new InvalidOperationException("Недостаточно средств для снятия!");
            }
            
        }

        public void RepayCredit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма должна быть положительной.");

            if (amount > _creditUsed)
                throw new InvalidOperationException("Сумма погашения превышает задолженность.");

            _creditUsed -= amount;
            Balance -= amount;

        }

        // Метод для начисления процента на кредитные средства
        public void AccrueInterest()
        {
            decimal interest = (_creditUsed / 100 * _interestRate);
            _creditUsed += interest;
            Console.WriteLine($"Начислены проценты по кредиту: {interest}. Общий долг: {_creditUsed}");
        }


    }
}
