namespace playground.UnitTest;

public class MinimumCostTest2662
{
    [Theory]
    [InlineData(new int[] { 1, 1 }, new int[] { 4, 5 }, "[[1,2,3,3,2],[3,4,4,5,1]]", 5)]
    [InlineData(new int[] { 1, 1 }, new int[] { 5, 10 }, "[[3,4,5,2,5],[4,5,3,8,3],[3,2,5,3,1]]", 11)]
    [InlineData(new int[] { 3, 2 }, new int[] { 5, 7 }, "[[3,2,3,4,4],[3,3,5,5,5],[3,4,5,6,6]]", 7)]
    [InlineData(new int[] { 24556, 19664 }, new int[] { 40028, 63600 }, "[[38828,26972,29584,37928,4402],[33756,22055,31073,37149,47007],[37749,34652,26833,20802,16294],[25540,44250,38439,37835,11416],[24982,43479,32467,49092,96130],[34952,40456,27981,21219,6056],[37700,26055,27828,44677,12218],[29190,27558,34831,55589,4044],[38035,61065,27064,46277,17357],[35003,21018,38616,45047,24302],[36291,21994,27413,34819,20881],[33310,57695,25317,28231,36464],[34495,36373,26111,48401,30999],[29162,23071,24858,37392,5702],[39259,44797,35961,53350,3542],[32389,51626,31282,48459,2276],[28061,43280,36064,55592,1818],[26773,31980,30032,44782,3042],[28588,60936,31930,43114,5247],[28911,32065,27725,56500,22855],[29072,53047,27661,57133,5768],[29319,62708,27007,22096,26722],[27486,20519,34879,63540,17886],[34047,62415,27646,47999,3253],[33238,44640,39064,50543,3271],[35279,32438,34767,62042,11577],[33041,55960,33421,44427,51911],[27306,61515,32140,45072,12986],[36899,27352,31436,63574,17850],[36461,37435,36431,32931,670],[35161,28104,27223,42991,13224]]", 26880)]
    public void MinimumCost(int[] s, int[] t, string roads, int expected)
    {
        var actual = MinimumCost2662.MinimumCost(s, t, roads.To2dArr());
        Assert.Equal(expected, actual);
    }
}
