/* 

        Return the number (count) of vowels in the given string.
        We will consider a, e, i, o, and u as vowels for this Kata.

 */

using System;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0, i;

        for (i = 0; i < str.Length; i++)
        {
            if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
            {
                vowelCount++;
            }
        }

        return vowelCount;

    }
}
