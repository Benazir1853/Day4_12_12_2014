using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
                    static void Main(string[] args)
        {
            //Array List Exp;loration
           // int numbers = new int[10];
            ArrayList myList = new ArrayList();
            myList.Add(100);
            myList.Add(200);
           
            myList.AddRange(myList);
            foreach (var value in myList)
            {
                Console.wrileLine(value);

            }
            Console.Read();
        }
    }
}
