namespace playground.UnitTest;

public class SumOfPowerTest2681
{
    [Theory]
    [InlineData(new int[] { 2, 1, 4 }, 141)]
    [InlineData(new int[] { 1, 1, 1 }, 7)]
    [InlineData(new int[] { 978963 }, 502250904)]
    [InlineData(new int[] { 978963, 798466, 169198, 45868, 664792, 703819, 182808, 799924, 283848, 523252, 2123, 365935, 427583, 655411, 781124, 215245, 135635, 149101, 684647, 72352, 957817, 879130, 919567, 33235, 799326, 522600, 60335, 95701, 160000, 45171, 10604, 812596, 623857, 739821, 209166, 152961, 412476, 80148, 446928, 48662, 508986, 739177, 820178, 936291, 672554, 134580, 964225, 293013, 231088, 80086, 479068, 639632, 920534, 819550, 624154, 392243, 878207, 872296, 759167, 799522, 825343, 227176, 867690, 431150, 550456, 773776, 430209, 19551, 95484, 505217, 911363, 392435, 957164, 413056, 633622, 290081, 532201, 702176, 605241, 361989, 513750, 620032, 745396, 97886, 434156, 899475, 543314, 126654, 607397, 793959, 732860, 171203, 876340, 983081, 22139, 945127, 664098, 783337, 77857, 467065, 209562, 144437, 958878, 247472, 321174, 223478, 502221, 168953, 370481, 882236, 58213, 514230, 427739, 742631, 314438, 459310 }, 672437301)]
    public void SumOfPower(int[] nums, int expected)
    {
        var actual = SumOfPower2681.SumOfPower(nums);
        Assert.Equal(expected, actual);
    }
}
