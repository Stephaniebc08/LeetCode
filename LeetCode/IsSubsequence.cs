using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsSubsequence
    {
        public bool FindSubsequence(string s, string t)
        {
            int i = 0, j = 0;
            while (i < s.Length && j < t.Length)
            {
                if (s[i] == t[j])
                {
                    i++;
                }
                j++;
            }
            return i == s.Length;
        }
    }
}

