using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> randic = new Dictionary<char, int>();

            foreach (char c in magazine)
            {
                if (randic.ContainsKey(c))
                {
                    randic[c]++;
                }
                else
                {
                    randic[c] = 1;
                }

            }
            foreach (char c in ransomNote)
            {
                if (randic.ContainsKey(c))
                {
                    randic[c]--;

                    if (randic[c] < 0)
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }

            }
            return true;
        }
    }
}

