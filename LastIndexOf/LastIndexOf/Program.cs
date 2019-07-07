using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastIndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa sozu daxil edin:");
            string str = Console.ReadLine();      
            Console.WriteLine("Zehmet olmasa sozde olan herfi daxil edin ve indeksini elde edin:");
            char i = (char)Console.Read();
            Console.WriteLine(str.LastMyIndexOf(i));

        }
    }
    public static class LastIndex
    {
        public static int LastMyIndexOf(this string word,char h)
        {
          int count = -1;
            for (int i = 0; i < word.Length; i++)
                if (word[i] == h)
                    count = i;
            return count;  
        }
    }
}
