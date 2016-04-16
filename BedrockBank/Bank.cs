using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
public static class Bank
    {
        /// <summary>
        /// Create a new Account
        /// </summary>
        /// <param name="accountName">Name for your account</param>
        /// <param name="ssn">your social security number</param>
        /// <param name="typeOfAccount">The type of account</param>
        /// <returns>A new account</returns>
        public static Account CreateAccount(string accountName, int ssn, AccountType typeOfAccount)
        {
            var account = new Account { AccountName = accountName,
                SSN = ssn,
                TypeOfAccount = typeOfAccount
            };

            return account;
            
        } 
    }
}
