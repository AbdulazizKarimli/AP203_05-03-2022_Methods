using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ValueReferance
            //int a = 5;
            //int b = a;
            //b = 10;

            //Console.WriteLine($"a={a}");
            //Console.WriteLine($"b={b}");

            //int[] arr = {1, 2, 3};
            //int[] arr2 = arr;
            //arr2[0] = 10;
            //int[] arr3 = { 1, 2, 4 };
            //arr3 = arr;
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr2[0]);
            //Console.WriteLine(arr==arr3);
            #endregion

            #region Methods

            //int result = Sum(1, 2);
            //Console.WriteLine(result);

            //Print();

            #endregion

            #region DefaultValue Params

            //Compare("a");

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            //int[] arr2 = { 1, 2, 3, 4, 5, };
            //Console.WriteLine(SumArrElements(arr));
            //Console.WriteLine(SumArrElements(arr2));

            //Console.WriteLine(SumArrElements(1 ,"", 1, 2, 3, 4, 5));
            //Test(1,"");

            #endregion

            #region MethodOverloading

            //Console.WriteLine(Test(1,2,3));

            #endregion

            #region Practice

            //Console.WriteLine(Divide(1, 0));

            #endregion
        }

        #region Practice

        //static int Divide(int a, int b)
        //{
        //    if(b != 0)
        //        return a / b;

        //    return -1;
        //}

        #endregion

        #region MethodOverloading

        //static int Test(int a, int b = 5)
        //{
        //    return a + b;
        //}

        //static int Test(int a)
        //{
        //    return a;
        //}

        //static int Test(params int[] a)
        //{
        //    return 0;
        //}

        //Method signature: Method name, Method parametr count, Method parametr type
        //static int Test(int a)
        //{
        //    return a;
        //}

        //static int Test(int a, int b)
        //{
        //    return 0;
        //}

        //static double Test(int a, string b)
        //{
        //    return 1;
        //}

        //static int Test(int[] arr)
        //{
        //    return arr.Length;
        //}

        //static int Test(double[] arr)
        //{
        //    return (int)arr.Length;
        //}

        #endregion

        #region DefaultValue Params

        //static int SumArrElements(double b, string str, params int[] arr)
        //{
        //    int sum = 0;
        //    foreach (var item in arr)
        //    {
        //        if (item % 2 == 0)
        //            sum += item;
        //    }

        //    return sum;
        //}

        //static void Compare(string str = "a", int num1 =4 , int num2 = 2)
        //{
        //    if (num1 > num2)
        //    {
        //        Console.WriteLine("boyukdur");
        //        return;
        //    }

        //    Console.WriteLine("kicikdir");

        //}

        #endregion

        #region Methods

        //static int Sum(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        //static void Print()
        //{
        //    Console.WriteLine(Sum(1, 2));
        //}

        #endregion

    }
}
