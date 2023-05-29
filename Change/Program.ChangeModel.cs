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

                int temp10 = Amount / COIN10;
                for (int i = temp10; i > 0; i--)
                {
                    int remean = i * COIN10;
                    if ((Amount - remean) % 3 == 0)
                    {
                        return (Amount - remean) / COIN3;
                    }
                }

                int amountUsed = Amount - RemeaningAmount;
                return amountUsed / COIN3;
            }
        }

        public int TotalCoin10 => Amount / COIN10;
        public int TotalCoin10_2
        {
            get
            {

                int temp10 = Amount / COIN10;
                for (int i = temp10; i >= 0; i--)
                {
                    int remean = i * COIN10;
                    if ((Amount - remean) % COIN3 == 0)
                    {
                        return i;
                    }
                }


                return Amount / COIN10;
            }
        }

        public int RemeaningAmount => TotalCoin10_2 * COIN10;
        public bool CanChangeOnlyCoin3 => Amount % COIN3 is 0;
        public bool CanChange
        {
            get
            {
                if (Amount <= 0) return false;

                return (TotalCoin3 * COIN3) + (TotalCoin10_2 * COIN10) == Amount;
            }
        }

        public string DisplayChangeResult => $"{TotalCoin10_2} {TotalCoin3}";
        public string DisplayCannotChangeResult => "Cannot Change";
        #endregion  Getter Propperty

    }
}