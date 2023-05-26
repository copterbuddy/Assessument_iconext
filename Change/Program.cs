namespace Change;

public class Program
{
    public static int COIN3 = 3;
    public static int COIN10 = 10;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public static string Change(int amount)
    {
        int totalCoin3 = 0;
        int totalCoin10 = 0;

        if (CheckCanChangeOnlyCoin3(amount))
        {
            totalCoin3 = GetCoin3FromAmount(amount);
            return $"{totalCoin10} {totalCoin3}";
        }

        totalCoin10 = GetCoin10FromAmount(amount);
        int remeaningAmount = GetRemeaningAmount(totalCoin10);

        totalCoin3 = GetCoin3FromRemeaningAmount(amount, remeaningAmount);

        ChangeModel checkCanChangeModel = new ChangeModel(amount: amount,
                                                                        totalCoin10: totalCoin10,
                                                                        totalCoin3: totalCoin3);

        if (CheckCanChange(checkCanChangeModel))
        {
            return $"{totalCoin10} {totalCoin3}";

        }

        return "Cannot Change";
    }

    private static int GetRemeaningAmount(int totalCoin10)
    {
        return totalCoin10 * COIN10;
    }

    private static int GetCoin3FromRemeaningAmount(int amount, int remeaningAmount)
    {
        return (amount - remeaningAmount) / COIN3;
    }

    private static int GetCoin10FromAmount(int amount)
    {
        return amount / COIN10;
    }

    private static int GetCoin3FromAmount(int amount)
    {
        return amount / COIN3;
    }

    private static bool CheckCanChange(ChangeModel canChangeModel)
    {
        return (canChangeModel.ChangeCoin3 * COIN3) + (canChangeModel.ChangeCoin10 * COIN10) == canChangeModel.Amount;
    }

    private static bool CheckCanChangeOnlyCoin3(int amount)
    {
        return amount % COIN3 == 0;
    }

    public class ChangeModel
    {
        public int Amount { get; set; }
        public int ChangeCoin3 { get; set; }
        public int ChangeCoin10 { get; set;}
        public ChangeModel(int amount, int totalCoin10, int totalCoin3)
        {
            Amount = amount;
            ChangeCoin10 = totalCoin10;
            ChangeCoin3 = totalCoin3;
        }
    }
}