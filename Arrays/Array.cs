public static class Array
{

/// <summary>
/// SORT COLORS
/// 3 POINTERS APPROACH
/// </summary>
/// <param name="arr"></param>
public static void SortColor(int[] arr)
    {
        int leftPtr = 0, middlePtr = 0, rightPtr = arr.Length - 1;

        while (middlePtr < rightPtr)
        {
            if (arr[middlePtr] == 0)
            {
                int temp = arr[middlePtr];
                arr[middlePtr] = arr[leftPtr];
                arr[leftPtr] = temp;
                leftPtr++;
                middlePtr++;
            }

            else if (arr[middlePtr] == 1)
                middlePtr++;

            else if (arr[middlePtr] == 2)
            {
                int temp = arr[middlePtr];
                arr[middlePtr] = arr[rightPtr];
                arr[rightPtr] = temp;
                rightPtr--;
            }

        }
    }

    /// <summary>
    /// TO MOVE ALL ZEROES TO END KEEPING THE RELATIVE ORDER
    /// </summary>
    /// <param name="arr"></param>
    public static void MoveZeroes(int[] arr)
    {
        int rightPtr = 0;
        int leftPtr = 0;

        while (rightPtr < arr.Length)
        {
            if (arr[rightPtr] != 0)
            {
                int temp = arr[leftPtr];
                arr[leftPtr] = arr[rightPtr];
                arr[rightPtr] = temp;

                leftPtr++;
            }

            rightPtr++;
        }
    }

    /// <summary>
    /// MAX PROFIT/ BEST TIME TO BUY AND SELL STOCK
    /// </summary>
    /// <param name="prices"></param>
    /// <returns></returns>
    public static int MaxProfit(int[] prices)
    {
        if(prices.Length < 2 )
            return 0;
            
        int maxProfit = 0;
        int lowestPrice = int.MaxValue;

        for (int i = 0; i<prices.Length; i++)
        {
            if ((prices[i] < lowestPrice)) 
                lowestPrice = prices[i];

            int currProfit = prices[i] - lowestPrice;
            maxProfit = maxProfit>currProfit ? maxProfit : currProfit;
            
        }
        
        return maxProfit;
    }

    public static int ContanairWithMostWater(int[] arr)
    {
        //brute force - o(n2)
        /*int ret = 0;

        for (int i = 0; i< arr.Length - 1; i++)
        {
            for (int j = i+1; j< arr.Length; j++)
            {
                int area = (j-i) * (arr[i] < arr[j] ? arr[i]: arr[j]);
                ret = ret > area ? ret : area;
            }
        }*/

        //linear time

        int ret = 0;

        int leftPtr = 0; int rightPtr = arr.Length - 1;
        while (leftPtr < rightPtr)
        {
            int area = (rightPtr - leftPtr) * (arr[leftPtr] < arr[rightPtr] ? arr[leftPtr] : arr[rightPtr]);
            ret = ret > area ? ret : area;

            if (arr[leftPtr] < arr[rightPtr])
                leftPtr++;
            else
                rightPtr--;
        }
        
        return ret;
    }

    public static int LongestConsecutiveSequence(int[] nums)
    {
        if (nums.Length == 0) return 0;
    
        var numSet = new HashSet<int>(nums);
        int longestStreak = 0;
    
        foreach (var num in numSet)
        {
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;
    
                while (numSet.Contains(currentNum + 1))
                {
                    currentNum += 1;
                    currentStreak += 1;
                }
    
                longestStreak = longestStreak > currentStreak? longestStreak : currentStreak;
            }
        }
    
        return longestStreak;
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> ht = new Dictionary<int, int>();
    
        for(int i = 0; i<nums.Length; i++)
        {
            int tmp = nums[i];
            if (ht.ContainsKey(target - nums[i]))
            {
                // If found, return indices of both numbers
                return new int[] { ht[target - nums[i]], i };
            }    
            ht[nums[i]] = i;
        }
    
        return new int[] { -1, -1};
    }

    /// <summary>
    /// DESC - TWO Pointer approach
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static int[] TwoSumSorted(int[] nums, int target)
    {
        int leftPtr = 0, rightPtr = nums.Length - 1;
        while (leftPtr < rightPtr)
        {
            if (nums[leftPtr] + nums[rightPtr] < target)
                leftPtr++;
            else if (nums[leftPtr] + nums[rightPtr] > target)
                rightPtr--;
            else
                return new int[] { leftPtr + 1, rightPtr + 1 };
        }
    
        return new int[] { -1, -1 };
    }
}    
