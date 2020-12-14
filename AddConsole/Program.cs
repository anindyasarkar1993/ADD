using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddConsole
{
   public class Program
    {
        static void Main(string[] args)
        {
            var store = Add(2, 3);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
    
}
