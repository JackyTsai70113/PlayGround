namespace playground;

public class CountArrangement0526
{
    /// <summary>
    /// https://leetcode.com/problems/beautiful-arrangement
    /// </summary>
    public static int CountArrangement(int n)
    {
        var memo = new int[1 << n, n];
        for (int i = 0; i < 1 << n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                memo[i, j] = -1;
            }
        }
        return Dfs(n, (1 << n) - 1, 0, memo);
    }

    private static int Dfs(int n, int mask, int start, int[,] memo)
    {
        if (start == n) return 1;
        if (memo[mask, start] != -1)
            return memo[mask, start];
        memo[mask, start] = 0;
        for (int i = 0; i < n; i++)
        {
            if (((mask >> i) & 1) > 0 &&
                ((i + 1) % (start + 1) == 0 || (start + 1) % (i + 1) == 0))
            {
                memo[mask, start] += Dfs(n, mask ^ (1 << i), start + 1, memo);
            }
        }
        return memo[mask, start];
    }
}
