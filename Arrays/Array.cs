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
