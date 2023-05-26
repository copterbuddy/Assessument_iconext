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
    [InlineData(11)]
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

    [Fact]
    public void Want_0_3_Give_9()
    {
        int paid = 9;

        string want = Program.Change(paid);

        Assert.Equal("0 3", want);
    }

    [Fact]
    public void Want_1_0_Give_10()
    {
        int paid = 10;

        string want = Program.Change(paid);

        Assert.Equal("1 0", want);
    }
}