using System;
using System.Collections.Generic;

namespace BankingKata
{
    public class AccountLog : IAccountLog
    {
        private List<Money> log = new List<Money>();

        public void RecordDeposit(Money amount)
        {
            log.Add(amount);
        }

        public void RecordWithdrawal(Money money)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(IAccountLog other)
        {
            foreach(var money in log)
            {
                other.RecordDeposit(money);
            }
        }
    }
}