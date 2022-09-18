using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Sample101
{
    class Program
    {
        /*
         *  HelloWorld
         */
        static void Main(string[] args)
        {
            // Console.WriteLine("{0} + {1} = {2}", 5, 2, 5 + 2);  //  足し算
            // Console.WriteLine("{0}", 5 + 2);  //  足し算
            // Console.WriteLine("{0} - {1} = {2}", 5, 2, 5 - 2);  //  引き算
            // Console.WriteLine("{0} * {1} = {2}", 5, 2, 5 * 2);  //  掛け算
            // Console.WriteLine("{0} * {1} = {2} 余り {3}", 5, 2, 5 / 2, 5 % 2);//  割り算と剰余

            int a = 3;
            int b = 3;
            Console.WriteLine("{0}", a + b);  //  足し算

            String ok = Console.ReadLine();  //  １つ目の文字列を入力
        

            Console.WriteLine("入力文字" + ok);



        }
    }
}