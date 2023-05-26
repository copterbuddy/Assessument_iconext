namespace Change;

public partial class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public static string Change(int amount)
    {
        ChangeModel changeModel = new ChangeModel(amount: amount);

        if (changeModel.CheckCanChangeOnlyCoin3())
        {
            changeModel.TotalCoin3 = changeModel.GetCoin3FromAmount();
            return changeModel.DisplayChangeResult;
        }

        changeModel.TotalCoin10 = changeModel.GetCoin10FromAmount();
        changeModel.RemeaningAmount = changeModel.GetRemeaningAmount();

        changeModel.TotalCoin3 = changeModel.GetCoin3FromRemeaningAmount();

        if (changeModel.CheckCanChange())
        {
            return changeModel.DisplayChangeResult;

        }

        return changeModel.DisplayCannotChangeResult;
    }
}