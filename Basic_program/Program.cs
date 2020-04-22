using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 23;
            char a = 'A';
            char b='B';
            int c, d ,sum;
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            sum = c + d;
            //string new= "New document"
            Console.WriteLine(a);
            Console.WriteLine((int)a);
            Console.WriteLine(b);
            Console.WriteLine((int)b);
            Console.WriteLine(number);
            Console.ReadLine();
            Console.WriteLine("Enter the value for three numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadLine();

            //ArrayList testing = new ArrayList();
            //testing.Add(a);
            //testing.Add(b);
            //testing.Add(c);
            //Console.WriteLine("testing[0] = {0}", testing[0]);
            //Console.WriteLine("testing[1] = {0}", testing[1]);
            //Console.WriteLine("testing[2] = {0}", testing[2]);

            //testing[0] = testing[1];
            //Console.WriteLine("testing[0] = {0}", testing[0]);
            //Console.WriteLine("testing[1] = {0}", testing[1]);
            //testing[1] = testing[2];

            //Console.WriteLine("testing[0] = {0}", testing[0]);
            //Console.WriteLine("testing[1] = {0}", testing[1]);
            //Console.WriteLine("testing[2] = {0}", testing[2]);

            //Console.WriteLine(testing[0]);
            //Console.WriteLine(testing[1]);
            //Console.WriteLine(testing[2]);

            //Console.ReadLine();

        }
    }
}
