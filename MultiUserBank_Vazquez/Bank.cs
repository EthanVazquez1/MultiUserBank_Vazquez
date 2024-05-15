using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiUserBank_Vazquez
{
    
    internal class Bank
    {
        int[] userBalance = { 1250, 2500, 3000, 1001 };
        const int startingBalance = 10000;
        private int balance = startingBalance;

        public int GetuserBalance(int userID)
        {
            return userBalance[userID];
        }

        public int GetBalance()
        {
            return balance;
        }

        public int add(int amount, int userID)
        {
            balance += amount;
            return userBalance[userID] += amount;
        }
        public int subtract(int amount, int userID)
        {
            if (userBalance[userID] < amount || amount >= balance)
            {
                return userBalance[userID];
            }
            if (amount > 500)
            {
                amount = 500;
            }
            if (userBalance[userID] - amount <= 0)
            {
                amount = balance;
            }
            userBalance[userID] -= amount;
            balance -= amount;
            return balance;
        }
    }
}
