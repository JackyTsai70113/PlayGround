namespace playground.UnitTest;

public class ResultArrayTest3072
{
    [Theory]
    [InlineData("[2,38,2]", "[2,38,2]")]
    [InlineData("[72,155,94,49]", "[72,155,94,49]")]
    [InlineData("[2,1,3,3]", "[2,3,1,3]")]
    [InlineData("[5,14,3,1,2]", "[5,3,1,2,14]")]
    [InlineData("[3,3,3,3]", "[3,3,3,3]")]
    [InlineData("[2,47,3,3,65,7,97,4]", "[2,65,7,97,4,47,3,3]")]
    public void ResultArray(string nums, string expected)
    {
        var actual = ResultArray3072.ResultArray(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
