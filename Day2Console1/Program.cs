using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array in C#
            //string[] strArr = new string[] { "Abcd1","Abcd2","Abcd3","Abcd4","Abcd5","Abcd6"};
            //foreach(string str in strArr) 
            //{ 
            //  Console.WriteLine(str);
            //}

            //System.Int32[] arr=new System.Int32[] {2,3,4,55,6,6,7};
            ////int[] inArr = new int[] { 13, 45, 55, 56, 77, 88, 99 };
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //2 Day Array
            int[,] inArr = new int[2, 3];
            inArr[0, 0] = 5;
            inArr[0, 1] = 10;
            inArr[0, 2] = 15;
            inArr[1, 0] = 20;
            inArr[1, 1] = 25;
            inArr[1, 2] = 30;

            for(int i=0; i<2; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.WriteLine("{0}",inArr[i,j]);
                }
                Console.WriteLine();
            }

        }
    }
}
