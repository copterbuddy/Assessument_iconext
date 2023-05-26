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

        #region Getter Propperty
        public int TotalCoin3
        {
            get
            {
                if (CanChangeOnlyCoin3)
                {
                    return Amount / COIN3;
                }

                int amountUsed = Amount - RemeaningAmount;
                return amountUsed / COIN3;
            }
        }

        public int TotalCoin10 => CanChangeOnlyCoin3 ? 0 : Amount / COIN10;

        public int RemeaningAmount => TotalCoin10 * COIN10;
        public bool CanChangeOnlyCoin3 => Amount % COIN3 is 0;
        public bool CanNormalCoin => (TotalCoin3 * COIN3) + (TotalCoin10 * COIN10) == Amount;
        public bool CanChange
        {
            get
            {
                if (Amount <= 0) return false;

                return CanChangeOnlyCoin3 || CanNormalCoin;
            }
        }

        public string DisplayChangeResult => $"{TotalCoin10} {TotalCoin3}";
        public string DisplayCannotChangeResult => "Cannot Change";
        #endregion  Getter Propperty

    }
}