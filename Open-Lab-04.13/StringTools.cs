using System;
using System.Collections.Generic;

namespace Open_Lab_04._13
{
    public class StringTools
    {
        public string GetLongestCommonSequence(string str1, string str2)
        {
            string[] st = new string[100];
            List<char> f = new List<char>();
            int ctr = 0;
            char[] a = str1.ToCharArray();
            char[] b = str2.ToCharArray();
            int m = 0;
            int n = 0;
            while (m < str1.Length)
            {
                for (n = 0; n < str2.Length; n++)
                {
                    if (m < str1.Length)
                    {
                        if (str1[m] == str2[n])
                        {
                            if ((m > 1) && (n > 1) &&(str1[m - 1] == str2[n - 1]) && (str1[m - 2] == str2[n - 2]))
                            {
                                f.Add(str1[m]);
                                char[] ff = f.ToArray();
                                string aaa = new string(ff);
                                if (aaa.Length >= 3)
                                {
                                    st[ctr] = aaa + "()";
                                    ctr++;
                                }
                                m++;
                            }
                            else if ((n == 0) ||(n == 1))
                            {
                                f.Add(str1[m]);
                                m++;
                            }
                            else
                                f.Clear();
                        }
                        else if ((str1[m] != str2[n]) && (n == (str2.Length - 1)))
                        {
                           m++;
                        }
                        else if ((m > 1) && (n > 1) && (str1[m] != str2[n]) && (str1[m - 1] == str2[n - 1]) && (str1[m - 2] == str2[n - 2]) && (str1[m - 3] == str2[n - 3]))
                        {
                            char[] ff = f.ToArray();
                            string aaa = new string(ff);
                            if (aaa.Length >= 3)
                            {
                                st[ctr] = aaa + "()";
                                ctr++;
                                f.Clear();
                            }
                        }
                        else if (str1[m] != str2[n])
                            continue;
                    }
                }
            }
            return st;
        }
    }
}
