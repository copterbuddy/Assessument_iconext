namespace Change;

public partial class Program
{
    public class ChangeModel
    {
        public ChangeModel(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; set; } = 0;
        public int TotalCoin3 { get; set; } = 0;
        public int TotalCoin10 { get; set; } = 0;
        public int RemeaningAmount => TotalCoin10 * COIN10;

        public string DisplayChangeResult => $"{TotalCoin10} {TotalCoin3}";
        public string DisplayCannotChangeResult => "Cannot Change";

        public int GetTotalCoinFromAmount(int coinType)
        {
            return Amount / coinType;
        }

        public int GetTotalCoinFromRemeaningAmount(int coinType)
        {
            return (Amount - RemeaningAmount) / coinType;
        }

        public bool CheckCanChangeOnlyCoin3()
        {
            return Amount % COIN3 == 0;
        }

        public bool CheckCanChange()
        {
            return (TotalCoin3 * COIN3) + (TotalCoin10 * COIN10) == Amount;
        }
    }
}