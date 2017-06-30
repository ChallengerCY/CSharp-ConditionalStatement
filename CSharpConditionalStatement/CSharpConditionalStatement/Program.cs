using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            //if条件语句（中为true就可以执行）
            if (true)
            {
                Console.WriteLine("true");
                //嵌套
                if (true)
                {
                    Console.WriteLine("true2");
                }
            }
            else if (false)
            { 
            
            }
            else
            {
                Console.WriteLine("false");
            }
            int ten = 101;
            int ifelse = ten < 100 ? ten : 99;
            Console.WriteLine(ifelse);

            int switchKey=101;
            switch (switchKey)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 100:
                    Console.WriteLine("100");
                  break;
                default:
                    Console.WriteLine("no");
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
