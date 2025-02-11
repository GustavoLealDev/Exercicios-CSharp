﻿namespace Course.Entities
{
     class Account
    {
        public int AccountId { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account() 
        { 
        }
        public Account(int accountId, string holder, double balance, double withDrawLimit)
        {
            AccountId = accountId;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }

        public void WithDraw(double amount)
        {
            Balance = Balance - amount;
        }
    }
}
