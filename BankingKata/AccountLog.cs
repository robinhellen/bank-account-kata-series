using System.Collections.Generic;

namespace BankingKata
{
    public class AccountLog : IAccountLog
    {
        private readonly List<ILogItem> log = new List<ILogItem>();

        public void RecordDeposit(Money amount)
        {
            log.Add(new DepositLogItem(amount));
        }

        public void RecordWithdrawal(Money amount)
        {
            log.Add(new WithdrawalLogItem(amount));
        }

        public void CopyTo(IAccountLog other)
        {
            foreach(var item in log)
            {
                item.RecordTo(other);
            }
        }

        private class WithdrawalLogItem : ILogItem
        {
            private readonly Money amount;

            public WithdrawalLogItem(Money amount)
            {
                this.amount = amount;
            }

            public void RecordTo(IAccountLog destination)
            {
                destination.RecordWithdrawal(amount);
            }
        }

        private class DepositLogItem : ILogItem
        {
            private readonly Money amount;

            public DepositLogItem(Money amount)
            {
                this.amount = amount;
            }

            public void RecordTo(IAccountLog destination)
            {
                destination.RecordDeposit(amount);
            }
        }

        private interface ILogItem {
            void RecordTo(IAccountLog destination);
        }
    }
}