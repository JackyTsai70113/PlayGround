namespace playground;

public class CanAliceWin3232
{
    public static bool CanAliceWin(int[] nums)
    {
        int s = 0, d = 0;
        foreach (var num in nums)
        {
            if (num <= 9)
            {
                s += num;
            }
            else
            {
                d += num;
            }
        }
        return s != d;
    }
}
