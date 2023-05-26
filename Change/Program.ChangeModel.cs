namespace Change;

public partial class Program
{
    public class ChangeModel
    {
        public const int COIN3 = 3;
        public const int COIN10 = 10;

        public int Amount { get; set; } = 0;
        public int TotalCoin3 { get; set; } = 0;
        public int TotalCoin10 { get; set; } = 0;
        public int RemeaningAmount { get; set; } = 0;
        public ChangeModel(int amount)
        {
            Amount = amount;
        }

        public string DisplayChangeResult => $"{TotalCoin10} {TotalCoin3}";
        public string DisplayCannotChangeResult => "Cannot Change";

        public int GetCoin3FromAmount()
        {
            return Amount / COIN3;
        }

        public int GetCoin10FromAmount()
        {
            return Amount / COIN10;
        }

        public int GetRemeaningAmount()
        {
            return TotalCoin10 * COIN10;
        }

        public int GetCoin3FromRemeaningAmount()
        {
            return (Amount - RemeaningAmount) / COIN3;
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