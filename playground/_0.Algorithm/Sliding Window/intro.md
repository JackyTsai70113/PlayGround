# Sliding Window

- Sliding Window Technique is a method used to efficiently solve problems that involve defining a window or range in the input data (arrays or strings) and then moving that window across the data to perform some operation within the window

## template

### Maximum Window

1. Find Maximum Window

    ```csharp
    public static int MaximumWindow(int[] nums)
    {
        bool Valid()
        {
            return false;
        }
        int max = 0;
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            // update state by A[r]
            while (l <= r && !Valid())
            {
                // update state by A[l]
                l++;
            }
            if (Valid())
                max = Math.Max(max, r - l + 1);
        }
        return max;
    }
    ```

2. Find Minimum Window

    ```csharp
    public static int MaximumWindow(int[] nums)
    {
        bool Valid()
        {
            return false;
        }
        int min = int.MaxValue;
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            // update state by A[r]
            while (l <= r && Valid())
            {
                min = Math.Min(min, r - l + 1);
                // update state by A[l]
                l++;
            }
        }
        return min == int.MaxValue ? 0 : min;
    }
    ```

3. At Most to Equal

    ```csharp
    public static int NeedEqual(int[] nums, int k)
    {
        return AtMost(nums, k) - AtMost(nums, k - 1);
    }

    private static int AtMost(int[] nums, int k)
    {
        bool Valid()
        {
            return false;
        }
        int res = 0;
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            // update state by A[r]
            while (l <= r && !Valid())
            {
                // update state by A[l]
                l++;
            }
            res += r - l + 1;
        }
        return res;
    }
    ```

4. At Least to Equal

    ```csharp
    public static int NeedEqual(int[] nums, int k)
    {
        return AtLeast(nums, k) - AtLeast(nums, k + 1);
    }

    private static int AtLeast(int[] nums, int k)
    {
        bool Valid()
        {
            return false;
        }
        int res = 0;
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            // update state by A[r]
            while (l <= r && Valid())
            {
                res += nums.Length - r;
                // update state by A[l]
                l++;
            }
        }
        return res;
    }
    ```

5. Fixed-length Sliding Window

    ```csharp
    private static int FixedLength(int[] nums, int k)
    {
        bool Valid()
        {
            return false;
        }
        int res = 0;
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            // update state by A[r]
            if (r >= k - 1)
            {
                if(r>=k){
                    // update state by A[l]
                    l++;
                }
                if(Valid()){
                    res++;
                }
            }
        }
        return res;
    }
    ```

- ref: <https://liuzhenglaichn.gitbook.io/algorithm/array/sliding-window>
