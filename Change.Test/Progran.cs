namespace Change.Test;

public class Progran
{

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(5)]
    [InlineData(7)]
    [InlineData(8)]
    public void Want_CannotChange(int paid)
    {
        string want = Program.Change(paid);

        Assert.Equal("Cannot Change", want);
    }

    [Fact]
    public void Want_0_1_Give_3()
    {
        int paid = 3;

        string want = Program.Change(paid);

        Assert.Equal("0 1", want);
    }

    [Fact]
    public void Want_0_2_Give_6()
    {
        int paid = 6;

        string want = Program.Change(paid);

        Assert.Equal("0 2", want);
    }
}