namespace Change;

public partial class Program
{
    public static int COIN3 = 3;
    public static int COIN10 = 10;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public static string Change(int amount)
    {

        ChangeModel changeModel = new ChangeModel(amount: amount);

        if (CheckCanChangeOnlyCoin3(amount))
        {
            changeModel.TotalCoin3 = GetCoin3FromAmount(amount);
            return changeModel.DisplayResult;
        }

        changeModel.TotalCoin10 = GetCoin10FromAmount(amount);
        int remeaningAmount = GetRemeaningAmount(changeModel.TotalCoin10);

        changeModel.TotalCoin3 = GetCoin3FromRemeaningAmount(amount, remeaningAmount);

        if (CheckCanChange(changeModel))
        {
            return changeModel.DisplayResult;

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
        return (canChangeModel.TotalCoin3 * COIN3) + (canChangeModel.TotalCoin10 * COIN10) == canChangeModel.Amount;
    }

    private static bool CheckCanChangeOnlyCoin3(int amount)
    {
        return amount % COIN3 == 0;
    }
}