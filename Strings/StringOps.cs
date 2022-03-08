using System;
using System.Linq;

namespace DesignPattern.Strings
{
    public class StringOps
    {
         public static void RepeatedString()
        {
            string[] a = new string[]{"cat", "dog", "cat", "cat", "horse", "duck", "Duck", };
            string[]b = a;
            int count = 0;
            int i=0;

            for(i = 0; i <a.Length; i++)
            {
                for ( int j =0; j<a.Length; j++)
                {
                    if(a[i].ToLower()==a[j].ToLower())
                    {
                        count++;
                        
                    }

                }
                Console.WriteLine( "{0} Repeated {1} Times", a[i], count);
                a=a.Where(w => w.ToLower() != a[i].ToLower()).ToArray();
                --i;
                count=0;

            }

        }
    }
}