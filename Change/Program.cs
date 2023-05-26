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
            totalCoin3 = amount / COIN3;
            return $"{totalCoin10} {totalCoin3}";
        }

        totalCoin10 = amount / COIN10;
        int remeaningAmount = totalCoin10 * COIN10;

        totalCoin3 = (amount - remeaningAmount) / COIN3;

        CheckCanChangeModel checkCanChangeModel = new CheckCanChangeModel()
        {
            Amount = amount,
            ChangeCoin3 = totalCoin3,
            ChangeCoin10 = totalCoin10,
        };

        if (CheckCanChange(checkCanChangeModel))
        {
            return $"{totalCoin10} {totalCoin3}";

        }

        return "Cannot Change";
    }

    private static bool CheckCanChange(CheckCanChangeModel canChangeModel)
    {
        return (canChangeModel.ChangeCoin3 * COIN3) + (canChangeModel.ChangeCoin10 * COIN10) == canChangeModel.Amount;
    }

    private static bool CheckCanChangeOnlyCoin3(int amount)
    {
        return amount % COIN3 == 0;
    }

    public class CheckCanChangeModel
    {
        public int Amount { get; set; }
        public int ChangeCoin3 { get; set; }
        public int ChangeCoin10 { get; set;}
    }
}