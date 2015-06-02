namespace BankingKata
{
    public class Money
    {
        public override int GetHashCode()
        {
            return amount;
        }

        private readonly int amount;

        public Money(int amount)
        {
            this.amount = amount;
        }

        public override bool Equals(object obj)
        {
            return obj is Money && amount == ((Money) obj).amount;
        }
    }
}