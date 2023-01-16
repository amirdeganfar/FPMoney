namespace FP.Money.Domain
{
    public abstract class Money
    {
        public abstract decimal Withdraw(Currency currency, decimal amount);
    }
}
