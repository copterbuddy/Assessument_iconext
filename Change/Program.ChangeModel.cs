namespace Change;

public partial class Program
{
    public class ChangeModel
    {
        public int Amount { get; set; } = 0;
        public int TotalCoin3 { get; set; } = 0;
        public int TotalCoin10 { get; set; } = 0;
        public ChangeModel(int amount)
        {
            Amount = amount;
        }

        public string DisplayResult => $"{TotalCoin10} {TotalCoin3}";
    }
}