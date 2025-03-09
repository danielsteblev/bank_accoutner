using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_accounter
{
    public partial class Form1 : Form
    {

        private BankAccount BankAccount; // наш счёт
        public Form1()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bankName.Text) || string.IsNullOrEmpty(INN.Text) || string.IsNullOrEmpty(BIK.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка, что ИНН состоит только из цифр
            if (!System.Text.RegularExpressions.Regex.IsMatch(INN.Text, @"^\d+$"))
            {
                MessageBox.Show("ИНН должен содержать только цифры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создание нового счёта
            BankAccount = new BankAccount(bankName.Text, INN.Text, BIK.Text, accountOwner.Text,
                Convert.ToDecimal(creditLimit.Text), Convert.ToDecimal(comissionRate.Text), Convert.ToDecimal (interestRate.Text));

            // Отображение диалогового окна об успешном создании счёта
            MessageBox.Show("Счёт успешно создан!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bankNameLabel.Text = BankAccount.BankName;
            INNLabel.Text = BankAccount.INN;
            BIKLabel.Text = BankAccount.BIK;
            balanceLabel.Text = Convert.ToString(BankAccount.Balance);
            accountOwnerLabel.Text = BankAccount.Owner;
            creditLimitLabel.Text = Convert.ToString(BankAccount.CreditLimit);
            comissionRateLabel.Text = Convert.ToString(BankAccount.ComissionRate);
            interestRateLabel.Text = Convert.ToString(BankAccount.InterestRate);
            creditUsedLabel.Text = Convert.ToString(BankAccount.CreditUsed);



        }

        private void putMoneyButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(putMoneyLabel.Text, out decimal amount) & amount > 0)
            {
                BankAccount.PutMoney(amount);
                balanceLabel.Text = Convert.ToString(BankAccount.Balance);
            }
            else
            {
                throw new ArgumentException("ВВЕДЕНО НЕВЕРНО ЗНАЧЕНИЕ ИЛИ ЗНАЧЕНИЕ < 0");
            }
           
        }

        private void getMoneyButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(getMoneyLabel.Text, out decimal amount) & amount > 0)
            {
                BankAccount.GetMoney(amount);
                balanceLabel.Text = Convert.ToString(BankAccount.Balance);
            }
            else
            {
                throw new ArgumentException("ВВЕДЕНО НЕВЕРНО ЗНАЧЕНИЕ ИЛИ ЗНАЧЕНИЕ < 0");
            }
        }

        private void takeCreditButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(TakeCreditLabel.Text, out decimal amount) & amount > 0)
            {

                BankAccount.TakeCredit(amount);
                balanceLabel.Text = Convert.ToString(BankAccount.Balance);
                creditUsedLabel.Text = Convert.ToString(BankAccount.CreditUsed);
            }
            else
            {
                throw new ArgumentException("ВВЕДЕНО НЕВЕРНО ЗНАЧЕНИЕ ИЛИ ЗНАЧЕНИЕ < 0");
            }
        }

        private void repayCreditButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(RepayCreditLabel.Text, out decimal amount) & amount > 0)
            {

                BankAccount.RepayCredit(amount);
                creditUsedLabel.Text = Convert.ToString(BankAccount.CreditUsed);
                balanceLabel.Text = Convert.ToString(BankAccount.Balance);
            }
            else
            {
                throw new ArgumentException("ВВЕДЕНО НЕВЕРНО ЗНАЧЕНИЕ ИЛИ ЗНАЧЕНИЕ < 0");
            }
        }

        private void creditInterestButton_Click(object sender, EventArgs e)
        {
            BankAccount.AccrueInterest();
            creditUsedLabel.Text = Convert.ToString(BankAccount.CreditUsed);
        }
    }
}
