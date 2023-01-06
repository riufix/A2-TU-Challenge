using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        internal static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null) return true;
            foreach (var c in input)
            {
                if (c != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        internal static string MixString(string a, string b)
        {
            int destination = 0;

            if (IsNullEmptyOrWhiteSpace(a) || IsNullEmptyOrWhiteSpace(b))
            {
                throw new ArgumentException();
            }

            if (a.Length < b.Length)
            {
                destination = b.Length;
            }
            else
            {
                destination = a.Length;
            } 

            string mix = "";
            for(int i = 0; i < destination; i++)
            {
                if(a.Length < b.Length)
                {
                    
                }

                if(a.Length == b.Length)
                {
                    mix =  a[i] + b[i];
                    a++;
                    b++;
                }
            }
            return mix;
        }

        internal static string ToLowerCase(string a)
        {
            string resultStr = "";
            for (int i = 0; i < a.Length; i++)
            {
                resultStr += Char.ToLower(a[i]);
            }
            return resultStr;
        }

        internal static string Voyelles(string a)
        {
            string resultStr = "";
            for (int i = 0; i < a.Length; i++)
            {
                a = ToLowerCase(a);
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u' || a[i] == 'y')
                {
                    if (!resultStr.Contains(a[i]))
                    {
                        resultStr += a[i];
                    }
                }
            }
            return resultStr;
        }

        internal static string BazardString(string input)
        {
            string resultStr = "";

            for (int i = 0; i < input.Length; i += 2)
            {
                resultStr += input[i];
            }

            for (int i = 1; i < input.Length; i += 2)
            {
                resultStr += input[i];
            }
            return resultStr;
        }

        internal static string UnBazardString(string input)
        {
            string resultStr = "";
            string Param1 = "";
            string Param2 = "";

            for (int i = 0; i < input.Length / 2; i++)
            {
                Param1 += input[i];
            }

            for (int i = 0; i < input.Length / 2; i++)
            {
                Param2 += input[i];
            }
            resultStr = MixString(Param1, Param2);

            return resultStr;
        }

        internal static string ToCesarCode(string input, int offset)
        {
            throw new NotImplementedException();
        }
    }
}
