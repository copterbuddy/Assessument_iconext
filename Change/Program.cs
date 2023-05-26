namespace Change;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public static string Change(int amount)
    {
        int changeCoin3;
        int changCoin10;

        changCoin10 = amount / 10;
        int remeaningAmount = changCoin10 * 10;

        changeCoin3 = (amount - remeaningAmount) / 3;

        int use3coinonly = amount % 3;
        if (use3coinonly == 0)
        {
            changCoin10 = 0;
            changeCoin3 = amount / 3;
        }

        if ((changeCoin3 * 3) + (changCoin10 * 10) == amount)
        {
            return $"{changCoin10} {changeCoin3}";
            
        }

        return "Cannot Change";
    }
}