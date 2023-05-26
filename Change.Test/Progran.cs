namespace Change.Test;

public class Progran
{

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void Want_CannotChange(int paid)
    {
        string want = Program.Change(paid);

        Assert.Equal("Cannot Change", want);
    }
}