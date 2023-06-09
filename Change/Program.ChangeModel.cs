﻿namespace Change;

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

                int coin10FromTotalAmount = GetCoin10FromTotalAmount;

                for (int i = coin10FromTotalAmount; i >= 0; i--)
                {
                    int remean = i * COIN10;
                    if (CanChangeByMaxCoin10(remean))
                    {
                        return (Amount - remean) / COIN3;
                    }
                }

                int amountUsed = Amount - RemeaningAmount;
                return amountUsed / COIN3;
            }
        }

        public int TotalCoin10
        {
            get
            {
                int coin10FromTotalAmount = GetCoin10FromTotalAmount;

                for (int i = coin10FromTotalAmount; i >= 0; i--)
                {
                    int remean = i * COIN10;
                    if (CanChangeByMaxCoin10(remean))
                    {
                        return i;
                    }
                }


                return Amount / COIN10;
            }
        }

        public int RemeaningAmount => TotalCoin10 * COIN10;
        public bool CanChange
        {
            get
            {
                if (Amount <= 0) return false;

                return (TotalCoin3 * COIN3) + (TotalCoin10 * COIN10) == Amount;
            }
        }

        public string DisplayChangeResult => $"{TotalCoin10} {TotalCoin3}";
        public string DisplayCannotChangeResult => "Cannot Change";
        public int GetCoin10FromTotalAmount => Amount / COIN10;
        #endregion  Getter Propperty

        #region method
        public bool CanChangeByMaxCoin10(int remean)
        {
            return (Amount - remean) % COIN3 == 0;
        }
        #endregion metohd
    }
}