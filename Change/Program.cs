namespace Change;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public static string Change(int got)
    {
        int change3coin, change10coin, used3coin, used10coin, use3coinonly;
        change10coin = got / 10;
        used10coin = change10coin * 10;

        change3coin = (got - used10coin) / 3;

        use3coinonly = got % 3;
        if (use3coinonly == 0)
        {
            change10coin = 0;
            change3coin = got / 3;
        }

        if ((change3coin * 3) + (change10coin * 10) == got)
        {
            return $"{change10coin} {change3coin}";
            
        }

        return "Cannot Change";
    }
}