using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digital_root
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalRoot("31337");
            DigitalRoot("45734");
            DigitalRoot("45879568475987698547");
            Console.ReadKey();
        }
        static void DigitalRoot(string rootThis)
        {
            int output = 0;
            string inputorg = rootThis;
            int one = 0;
            while (rootThis.Length > 1)
            {
                one = 0;
                for (int i = 0; i < rootThis.Length; i++)
                { 
                    //parse the value of each index and add them together
                     one += int.Parse(rootThis[i].ToString());      
                }
                rootThis = one.ToString();
            }
            Console.WriteLine("Input: " + inputorg);
            Console.WriteLine("Digital Root: " + rootThis);
           
        }
    }
}
