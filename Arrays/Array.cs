namespace DSA
{
    public class PrefixSum
    {
        #region prefixsum

        /// <summary>
        /// BRUTE FORCE APPROACH. TIME COMPLEXITY O(n2)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] ProductExceptSelfBF(int[] nums)
        {
            int[] result = new int[nums.Length];


            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = 1;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j != i)
                        result[i] = result[i] * nums[j];
                }
            }

            return result;
        }

        /// <summary>
        /// OPTIMIZED APPROACH. TIME COMPLEXITY O(n) & SPACE COMPLEXITY O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];

            int[] prefixResult = new int[nums.Length];
            prefixResult[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {

                prefixResult[i] = nums[i - 1] * prefixResult[i - 1];
            }

            int[] postfixResult = new int[nums.Length];
            postfixResult[nums.Length - 1] = 1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                postfixResult[i] = nums[i + 1] * postfixResult[i + 1];
            }

            for (int i = 0; i < nums.Length; i++)
                result[i] = prefixResult[i] * postfixResult[i];

            return result;
        }

        /// <summary>
        /// OPTIMIZED WITH SPACE COMPLEXITY
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] ProductExceptSelfSCO(int[] nums)
        {
            int[] result = new int[nums.Length];

            result[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = nums[i - 1] * result[i - 1];
            }

            int suffix = 1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                suffix = suffix * nums[i + 1];
                result[i] = result[i] * suffix;
            }


            return result;
        }
        /// <summary>
        /// Brute ForCE SOLUTION FOR LEETCODE 560
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int SubArraySumBF(int[] nums, int k)
        {
            int totalNumOfSubArray = 0;

            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum = sum + nums[j];
                    if (sum == k)
                        totalNumOfSubArray++;
                }
            }

            return totalNumOfSubArray;
        }
        
        /// <summary>
        /// OPTIMIZED VERSION
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int SubarraySum(int[] nums, int k)
        {
            int count = 0;
            int prefixSum = 0;
            Dictionary<int, int> prefixCount = new Dictionary<int, int>();
            prefixCount[0] = 1; // Important for cases where prefixSum == k
        
            foreach (int num in nums)
            {
                prefixSum += num;
                int target = prefixSum - k;
        
                if (prefixCount.ContainsKey(target))
                    count += prefixCount[target];
        
                prefixCount[prefixSum] = prefixCount.ContainsKey(prefixSum) ? prefixCount[prefixSum] + 1 : 1;
            }
        
            return count;
        }


        #endregion prefixsum

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
            if (prices.Length < 2)
                return 0;

            int maxProfit = 0;
            int lowestPrice = int.MaxValue;

            for (int i = 0; i < prices.Length; i++)
            {
                if ((prices[i] < lowestPrice))
                    lowestPrice = prices[i];

                int currProfit = prices[i] - lowestPrice;
                maxProfit = maxProfit > currProfit ? maxProfit : currProfit;

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

                    longestStreak = longestStreak > currentStreak ? longestStreak : currentStreak;
                }
            }

            return longestStreak;
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> ht = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int tmp = nums[i];
                if (ht.ContainsKey(target - nums[i]))
                {
                    // If found, return indices of both numbers
                    return new int[] { ht[target - nums[i]], i };
                }
                ht[nums[i]] = i;
            }

            return new int[] { -1, -1 };
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
}
