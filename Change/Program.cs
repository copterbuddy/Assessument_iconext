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

        return changeModel.CanChange ? changeModel.DisplayChangeResult : changeModel.DisplayCannotChangeResult;
    }
}