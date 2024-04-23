namespace playground.UnitTest;

public class DiffWaysToComputeTest0241
{
    [Theory]
    [InlineData("2+1-1", new int[] { 2, 2 })]
    [InlineData("2-1-1", new int[] { 0, 2 })]
    [InlineData("2*3-4*5", new int[] { -34, -14, -10, -10, 10 })]
    public void Deserialize(string expression, int[] expected)
    {
        var actual = DiffWaysToCompute0241.DiffWaysToCompute(expression);
        Assert.Equal(expected, actual.OrderBy(x => x));
    }
}
