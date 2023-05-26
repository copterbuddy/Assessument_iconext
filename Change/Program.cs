namespace Change;

public class Program
{
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
            changeCoin3 = amount / 3;
            return $"{changeCoin10} {changeCoin3}";
        }

        changeCoin10 = amount / 10;
        int remeaningAmount = changeCoin10 * 10;

        changeCoin3 = (amount - remeaningAmount) / 3;

        if (CheckCanChange(amount, changeCoin3, changeCoin10))
        {
            return $"{changeCoin10} {changeCoin3}";

        }

        return "Cannot Change";
    }

    private static bool CheckCanChange(int amount, int changeCoin3, int changeCoin10)
    {
        return (changeCoin3 * 3) + (changeCoin10 * 10) == amount;
    }

    private static bool CheckCanChangeOnlyCoin3(int amount)
    {
        return amount % 3 == 0;
    }
}