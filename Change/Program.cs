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
        int changCoin10 = 0;

        if (CheckCanChangeOnlyCoin3(amount))
        {
            changCoin10 = 0;
            changeCoin3 = amount / 3;
            return $"{changCoin10} {changeCoin3}";
        }

        changCoin10 = amount / 10;
        int remeaningAmount = changCoin10 * 10;

        changeCoin3 = (amount - remeaningAmount) / 3;



        if ((changeCoin3 * 3) + (changCoin10 * 10) == amount)
        {
            return $"{changCoin10} {changeCoin3}";

        }

        return "Cannot Change";
    }

    private static bool CheckCanChangeOnlyCoin3(int amount)
    {
        return amount % 3 == 0;
    }
}