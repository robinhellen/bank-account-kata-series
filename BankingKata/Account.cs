namespace BankingKata
{
    public class Account {
        private readonly IAccountLog log;

        public Account(IAccountLog log)
        {
            this.log = log;
        }

        public void Deposit(Money money)
        {
            log.RecordDeposit(money);
        }
    }
}