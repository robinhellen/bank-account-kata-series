namespace BankingKata
{
    public interface IAccountLog
    {
        void RecordDeposit(Money amount);
        void RecordWithdrawal(Money money);
    }
}