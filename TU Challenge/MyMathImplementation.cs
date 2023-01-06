using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        internal static int Add(int a, int b)
        {
            return(a + b);
        }

        internal static bool IsMajeur(int age)
        {
            if (age < 18)
            {
                if (age < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                     return false;
                }
            }
            else if (age > 140)
            {
                throw new ArgumentException();
            }
            else
            {
                return true;
            }   
        }

        internal static bool IsEven(int a)
        {
            if(a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool IsDivisible(int a, int b)
        {


            if (b == 0)
            {
                return false;
            }
            else if (a % b == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal static bool IsPrimary(int a)
        {
            int p = 0;
            for(int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    p++;
                }
            }
            if(p == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static List<int> GetAllPrimary(int a)
        {
            List<int> nbr = new List<int>();
            while (a != 0)
            {
                if(IsPrimary(a))
                {
                    nbr.Add(a);
                }
                a--;
            }
            return nbr;
        }

        internal static int Power2(int a)
        {
            return Power(a, 2);
        }

        internal static int Power(int a, int b)
        {
            int expo = 1;
            for (int i=0; i < b; i++)
            {

                expo *= a;
                   
                    
            }
            return expo;
        }

        internal static int IsInOrder(int a, int b)
        {
            if(a < b)
            {
                return 1;
            }
            else if(a == b)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        internal static bool IsListInOrder(List<int> list)
        {
            for(int i = 0; i < list.Count - 1; i++)
            {
                if(list[i] > list[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        internal static List<int> Sort(List<int> toSort)
        {
            List<int> new_List = new List<int>();
            while(toSort != new_List)
            {
                int min = toSort[0];
                foreach(var x in toSort)
                {
                    if(x < min)
                    {
                        min = x;
                    }
                }
                new_List.Append(min);
                toSort.Remove(min);
            }
            return new_List;
        }

        internal static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            throw new NotImplementedException();
        }

        internal static int IsInOrderDesc(int arg1, int arg2)
        {
            throw new NotImplementedException();
        }
    }
}
