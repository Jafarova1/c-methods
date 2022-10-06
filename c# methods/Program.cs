
using System;

namespace ConsoleApp13
{
    class Program
    {
        #region Task1
        public static void CheckNumber(int n)
        {

            if (n % 3 == 0 && n % 7 == 0)
            {
                Console.WriteLine("3e ve 7e bolunur");


            }
            else
            {
                Console.WriteLine("3e ve 7e bolunmur");


            }
            return;


        }
        #endregion
        #region Task2
        public static void SumOfNUmbers(int n, int m)
        {
            int sum;
            if (n < m)
            {

                if (n % 2 == 0 && m % 2 == 0)
                {
                    sum = n + m;
                }
                else
                {
                    Console.WriteLine("cut eded deyil");

                }
                return;
            }
               
                
            
              
        }
        #endregion
        #region Task3
        public static int CountOfNUmbers(int n, int m)
        {
            int count = 0;
            if (n < m)
            {
                for (int i = n; i < m; i++)
                {
                    if (i % 2 == 1)
                    {
                        count++;
                    }
                }

            }
            return count;

        }
        #endregion
        #region Task4
        public static int SumOfPrimeNumbers(int n, int m)
        {
            int sum = 0;
            if (n < m)
            {
                for (int i = n; i < m; i++)
                {
                    if (i % 2 == 1)
                    {
                        sum += i;
                    }
                }
            }
            return sum;
        }
        #endregion
        #region Task5
        public static int SumOfArr(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        #endregion
        #region Task6
        public static int CountOfEvenNumbers(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    count++;

            }
            return count;
        }
        #endregion
        #region Task7
        public static void CheckComplexAndPrimekNumbers(int n)
        {
            int count = 0;
            if (n > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                    }

                }
                if (count > 2)
                {
                    Console.WriteLine("n murekkebdir");

                }
                else
                {
                    Console.WriteLine("n sadedir");

                }

                
            }
            else
            {
                Console.WriteLine("duzgun reqem daxil edin");
            }

            return;

        }
        #endregion
        #region Task8
        public static void PowerOfNumber(int n)
        {
            int i = 2;
            if (n < 1)
            {
                Console.WriteLine("duzgun reqem daxil edin");
            }
            while (i < n)
                i = i * 2;
            if (i == n)
            {
                Console.WriteLine("2nin quvvvetidir");
            }
            else
            {
                Console.WriteLine("2nin quvveti deyil");
            }
            


            return i;
        }
        #endregion
        #region Task9
        public static int MUltiplyArr(int[] arr)
        {
            int mult = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (1 < arr[i] && arr[i] < 20)
                    mult = mult * arr[i];

            }
            return mult;
        }
        #endregion
        #region Task10
        public static int SumOfEvenNumbersOfArr (int [] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    sum += arr[i];
                
            }int result = sum * sum;
            return result;
            
        }
        #endregion
        static public void Main(String[] args)
        {
            int[] arr = { 2, 4, 6, 8, 10, 7, 9 };
            
            CheckNumber(8);
            SumOfNUmbers(6,10);
            Console.WriteLine(CountOfNUmbers(4,11));
            Console.WriteLine(SumOfPrimeNumbers(4,11));
            Console.WriteLine(SumOfArr(arr));
            Console.WriteLine(CountOfEvenNumbers(arr));
           CheckComplexAndPrimekNumbers(17);
            PowerOfNumber(16);
            Console.WriteLine(MUltiplyArr(arr));
            Console.WriteLine(SumOfEvenNumbersOfArr(arr));

        }

    }

}