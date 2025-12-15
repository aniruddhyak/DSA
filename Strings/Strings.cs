public class Strings
{

    /// <summary>
    /// Reverse a string with Memory in place.
    /// Time complexity O(N)
    /// Space complexity O(1) - as constant space is used in leftPtr/rightPtr/temp.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static string ReverseString(string s)
    {
        char[] chars = s.ToCharArray();
        int leftPtr = 0;
        int rightPtr = s.Length - 1;

        while (leftPtr < rightPtr)
        {
            char temp = chars[leftPtr];
            chars[leftPtr] = chars[rightPtr];
            chars[rightPtr] = temp;

            leftPtr++;
            rightPtr--;
        }

        return new string(chars);
    }

    /// <summary>
    /// FIND START INDICES OF ALL ANAGRAMS
    /// </summary>
    /// <param name="s"></param>
    /// <param name="p"></param>
    public static List<int> AllAnagrams(string s, string p)
    {
        //char count for string P
        int[] pCount = new int[26];
        foreach (char c in p)
        {
            pCount[c - 'a']++;
        }

        //Intial char count for S 
        int[] sCount = new int[26];
        for (int i = 0; i < p.Length; i++)
        {
            sCount[s[i] - 'a']++;
        }

        List<int> startIndices = new List<int>();
        for (int i = 0; i < s.Length - p.Length; i++)
        {
            if (IsArrayEqual(pCount, sCount))
            {
                startIndices.Add(i);
            }

            sCount[s[i] - 'a']--;
            sCount[s[i + p.Length] - 'a']++;

        }

        return startIndices;

    }

/// <summary>
/// TO GET MIN SUBSTRING WINDOW 
/// </summary>
/// <param name="s"></param>
/// <param name="p"></param>
/// <returns></returns>
    public static string MinWindowSubstring(string s, string p)
    {

        int[] charCount = new int[26];
        foreach (char c in p)
        {
            charCount[c - 'A']++;
        }

        int leftPtr = 0;
        int rightPtr = 0;

        int charMatch = p.Length;

        int minLength = int.MaxValue;
        int startIndices = 0;

        while (rightPtr < s.Length)
        {
            char c = s[rightPtr];
            if (charCount[s[rightPtr++] - 'A']-- > 0)
            {
                charMatch--;

            }

            while (charMatch == 0)
            {
                if (rightPtr - leftPtr + 1 < minLength)
                {
                    minLength = rightPtr - leftPtr + 1;
                    startIndices = leftPtr;
                }

                if (charCount[s[leftPtr++] - 'A']++ == 0)
                {
                    charMatch++;

                }

                //leftPtr++;

            }

            //rightPtr++;


        }

        return minLength == int.MaxValue ? "" : new string(s.ToCharArray(), startIndices, minLength);

    }

    private static bool IsArrayEqual(int[] array1, int[] array2)
    {
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
                return false;
        }


        return true;

    }

}To track STRING related solutions
