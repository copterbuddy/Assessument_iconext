namespace Change.Test;

public class Progran
{

    [Theory]
    [InlineData(-10)]
    [InlineData(-3)]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(5)]
    [InlineData(7)]
    [InlineData(8)]
    [InlineData(11)]
    [InlineData(14)]
    [InlineData(17)]
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

    [Fact]
    public void Want_0_4_Give_12()
    {
        int paid = 12;

        string want = Program.Change(paid);

        Assert.Equal("0 4", want);
    }

    [Fact]
    public void Want_1_1_Give_13()
    {
        int paid = 13;

        string want = Program.Change(paid);

        Assert.Equal("1 1", want);
    }

    [Fact]
    public void Want_0_5_Give_15()
    {
        int paid = 15;

        string want = Program.Change(paid);

        Assert.Equal("0 5", want);
    }

    [Fact]
    public void Want_1_2_Give_16()
    {
        int paid = 16;

        string want = Program.Change(paid);

        Assert.Equal("1 2", want);
    }

    [Fact]
    public void Want_0_6_Give_18()
    {
        int paid = 18;

        string want = Program.Change(paid);

        Assert.Equal("0 6", want);
    }

    [Fact]
    public void Want_1_3_Give_19()
    {
        int paid = 19;

        string want = Program.Change(paid);

        Assert.Equal("1 3", want);
    }

    [Fact]
    public void Want_2_0_Give_20()
    {
        int paid = 20;

        string want = Program.Change(paid);

        Assert.Equal("2 0", want);
    }

    [Fact]
    public void Want_0_7_Give_21()
    {
        int paid = 21;

        string want = Program.Change(paid);

        Assert.Equal("0 7", want);
    }

    [Fact]
    public void Want_0_7_Give_22()
    {
        int paid = 22;

        string want = Program.Change(paid);

        Assert.Equal("1 4", want);
    }
}