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

        public void CopyTo(IAccountLog mock)
        {
            throw new NotImplementedException();
        }
    }
}