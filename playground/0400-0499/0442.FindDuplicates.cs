namespace playground;

public class FindDuplicates0442
{
    /// <summary>
    /// https://leetcode.com/problems/find-all-duplicates-in-an-array
    /// </summary>
    public static IList<int> FindDuplicates(int[] nums)
    {
        var res = new List<int>();
        foreach (var num in nums)
        {
            var index = Math.Abs(num) - 1;
            if (nums[index] < 0)
            {
                res.Add(index + 1);
            }
            else
            {
                nums[index] = -nums[index];
            }
        }
        return res;
    }
}
