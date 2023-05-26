namespace Change;

public partial class Program
{

    public const int COIN3 = 3;
    public const int COIN10 = 10;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public static string Change(int amount)
    {
        ChangeModel changeModel = new ChangeModel(amount: amount);

        if (changeModel.CheckCanChangeOnlyCoin3())
        {
            changeModel.TotalCoin3 = changeModel.GetTotalCoinFromAmount(coinType: COIN3);
            return changeModel.DisplayChangeResult;
        }

        changeModel.TotalCoin10 = changeModel.GetTotalCoinFromAmount(coinType: COIN10);
        changeModel.TotalCoin3 = changeModel.GetTotalCoinFromRemeaningAmount(coinType: COIN3);

        if (changeModel.CheckCanChange())
        {
            return changeModel.DisplayChangeResult;

        }

        return changeModel.DisplayCannotChangeResult;
    }
}