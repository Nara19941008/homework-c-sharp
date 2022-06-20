//using System;
//// 3 ve 7 bolunub bolunmemesi
//namespace Homework
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = 21;
           
//            if (n % 3 == 0 && n % 7 == 0)
//            {
//                Console.WriteLine("Divided");
//            } 
//            else
//            {
//                Console.WriteLine("Not divided");
//            }
//        }
              

//    }
//}






//2.n ve m cutdurse cemini hesabla

//namespace Homework
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n, m;
//            Console.WriteLine("write the number");
//            n = int.Parse(Console.ReadLine());
//            Console.WriteLine("write the number");
//            m = int.Parse(Console.ReadLine());

//            if (n % 2 == 0 && m % 2 == 0)

//            {
//                Console.WriteLine(n + m);
//            }
//            else
//            {
//                Console.WriteLine("one of them is not even number");
//            }
//        }
//    }
//}






//3.tek ededdlerin cemini tapin n ve m arasinda

//            using System;

//namespace Homework
//    {
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                int n = 3;
//                int m = 15;
//                var sum = 0;

//                for (int i = n; i <= m; i++)
//                {
//                    if (i % 2 == 1)
//                    {
//                        sum += i;
//                    }


//                }


//                Console.WriteLine(sum);
//            }


//        }
//    }







//4.arrayin icinde tek ededlerin cemini tapin
//     using System;

//namespace Homework
//    {
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                int[] numbers = { 2, 3, 5, 7, 9, 11, 6 };
//                int sum = 0;

//                foreach (var item in numbers)
//                {
//                    if (item % 2 == 1)
//                    {
//                        sum += item;
//                    }
//                }
//                Console.WriteLine(sum);
//            }
//        }
//}












//5.arrayin icinde cut ededlerin sayini taapin


//using System;

//namespace Homework
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 1, 2, 3, 4, 5, 6 };
//            int even = 0;

//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (i % 2 == 0)
//                    even++;
//            }
//            Console.WriteLine("count of even nums in the array+=even");
//        }
//    }
//}


