namespace Change;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public static string Change(int got)
    {
        int change3coin, change10coin;
        change10coin = got / 10;

        change3coin = got / 3;

        if (change3coin > 0 || change10coin > 0)
        {
            return $"{change10coin} {change3coin}";
        }

        return "Cannot Change";
    }
}