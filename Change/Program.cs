namespace Change;

public partial class Program
{

    public const int COIN3 = 3;
    public const int COIN10 = 10;

    static void Main(string[] args)
    {
        for (int i = 1; i <= 200; i++)
        {
            Console.WriteLine($"Paid:{i} Change {Change(i)}");
        }
        
        Console.ReadKey();
    }
    public static string Change(int amount)
    {
        ChangeModel changeModel = new ChangeModel(amount: amount);

        return changeModel.CanChange ? changeModel.DisplayChangeResult : changeModel.DisplayCannotChangeResult;
    }
}