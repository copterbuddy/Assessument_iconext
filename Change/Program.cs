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
        int changeCoin3 = 0;
        int changeCoin10 = 0;

        if (CheckCanChangeOnlyCoin3(amount))
        {
            changeCoin3 = amount / COIN3;
            return $"{changeCoin10} {changeCoin3}";
        }

        changeCoin10 = amount / COIN10;
        int remeaningAmount = changeCoin10 * COIN10;

        changeCoin3 = (amount - remeaningAmount) / COIN3;

        CheckCanChangeModel checkCanChangeModel = new CheckCanChangeModel()
        {
            Amount = amount,
            ChangeCoin3 = changeCoin3,
            ChangeCoin10 = changeCoin10,
        };

        if (CheckCanChange(checkCanChangeModel))
        {
            return $"{changeCoin10} {changeCoin3}";

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