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
}    
