using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //            //5.terss
            //            int num = int.Parse(Console.ReadLine());
            //            //int num = 34568;
            //            int rev=0;
            //            for (int i = 0; num> 0; i++)
            //            {
            //                rev = rev * 10 + (num % 10);
            //                num = num / 10;
            //                //guncelnumber
            //                //temp = num / 10;

            //            }
            //            Console.WriteLine(rev);
            //        }
            //    }
            //}

            //6.iki array. 1de olub ikide olmuannari cap ele OUTPUT=5,6,3
            int[] arr = { 4, 5, 2, 6, 4, 3 };
            int[] arr1 = { 7, 4, 2, 76, 45, 65 };
            bool isExist = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr[i] == arr1[i])
                    {
                        isExist = true;
                    }
                    

                }

                {

                }
            }
        }
    }
}




//            //console a 1 eded daxil et dax olnan ededin tek ve ya cut oldugunu ekrana yazdir.


//            int num = int.Parse(Console.ReadLine());
//            if (num % 2 == 0)
//            {
//                Console.WriteLine("cutdur");
//            }
//            else
//                Console.WriteLine("tek");
//        }
//    }
//}



//            //console a 2 eded daxil et dax olnan 2 ededden hansi boyukdu ekrana yazdir.
//            //beraberdise ekrana beraberdi yazsin

//            int num1 = int.Parse(Console.ReadLine());
//            int num2 = int.Parse(Console.ReadLine());
//            if (num1 > num2)
//            {
//                Console.WriteLine($"boyuk eded {num1} -dir");
//            }
//            else if (num2 > num1)
//            {
//                Console.WriteLine($"boyuk eded {num2} -dir");
//            }
//            else

//            {
//                Console.WriteLine("beraberdir");
//            }
//        }
//    }
//}




//arraydeki cut elementlerin cemi ile tek elementlerin ceminin ferqi example:[32,15,23,4,5]
//            int[] arr = { 32, 15, 24, 4, 5 };
//            int sumeven = 0;
//            int sumodd = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] % 2 == 0)
//                {
//                    sumeven = sumeven + arr[i];
//                }
//                else
//                {
//                    sumodd += arr[i];
//                }
//            }
//            Console.WriteLine(sumeven-sumodd);

//        }



//    }





//}

//        {
//            //verilmis massivin ededi ortasini tapin.
//            int[] arr = { 4, 6, 7, 1 };
//            int sum = 0;


//            for (int i = 0; i < arr.Length; i++)
//            {
//                sum = sum + arr[i];
//            }

//            Console.WriteLine(sum);
//        }
//    }
//}




//        static void Main(string[] args)
//        {
//            int[] arr = { 10, 20, 30 };
//            int[] copyArr = new int[arr.Length];
//            for (int i = 0; i < arr.Length; i++)
//            {
//                copyArr[i]=arr[]

//            }

//            if ()
//        }
//    }

//}

//            bool isMissed = false;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] != i + 1)
//                {
//                    Console.WriteLine(i + 1);
//                    isMissed = true;

//                }

//                break;

//            }
//        }
//    }
//}