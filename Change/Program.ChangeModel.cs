namespace Change;

public partial class Program
{
    public class ChangeModel
    {
        public int Amount { get; set; }
        public int ChangeCoin3 { get; set; }
        public int ChangeCoin10 { get; set;}
        public ChangeModel(int amount, int totalCoin10, int totalCoin3)
        {
            Amount = amount;
            ChangeCoin10 = totalCoin10;
            ChangeCoin3 = totalCoin3;
        }
    }
}