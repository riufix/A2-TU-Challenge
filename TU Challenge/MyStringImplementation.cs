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
            throw new NotImplementedException();
        }

        internal static string Voyelles(string a)
        {
            throw new NotImplementedException();
        }

        internal static string BazardString(string input)
        {
            throw new NotImplementedException();
        }

        internal static string UnBazardString(string input)
        {
            throw new NotImplementedException();
        }

        internal static string ToCesarCode(string input, int offset)
        {
            throw new NotImplementedException();
        }
    }
}
