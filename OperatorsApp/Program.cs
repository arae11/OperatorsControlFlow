using System;

namespace OperatorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> nums = new List<int> { 10, 6, 22, -17, 3 };
            List<int> nums = new List<int> { -10, -6, -22, -17, -3 };
            Console.WriteLine("Highest foreach loop: " + LoopTypes.HighestForEachLoop(nums));
            Console.WriteLine("Highest for loop: " + LoopTypes.HighestForLoop(nums));
            Console.WriteLine("Highest while loop: " + LoopTypes.HighestWhileLoop(nums));
            Console.WriteLine("Highest do-while loop: " + LoopTypes.HighestDoWhileLoop(nums));

            //int a = 5 % 2;

            //var daysInAWeek = 7;
            //var totalDaysToBirthday = 23;
            //var weeksToBirthday = totalDaysToBirthday / daysInAWeek;
            //var days = totalDaysToBirthday % daysInAWeek;
            //var res = EvenOdd(23);

            //const int NUM_ROWS = 2;
            //const int NUM_COLS = 5;
            //bool running = true;
            //int row = 0;
            //int col = 0;
            //int spriteNo = -1;

            //while(running)
            //{
            //    spriteNo = ++spriteNo % (NUM_ROWS * NUM_COLS);
            //    row = spriteNo / NUM_COLS;
            //    col = spriteNo % NUM_COLS;
            //}

            //int x = <expression>
            //x <operator> = < expression >
            //x = x <operator> < expression >

            //x = x + 3;
            //x += 3;

            //spriteNo %= NUM_ROWS * NUM_COLS;

            //bool isWearingParachute = false;
            //if (isWearingParachute && JumpOutOfPlane())
            //{
            //    Console.WriteLine("Congratulations, you are flying!");
            //}

            //string greeting = "All right?";
            //if (greeting != null & greeting.ToLower().StartsWith('a'))
            //{
            //    Console.WriteLine(greeting + " starts with 'a'");
            //}

            //int mark = 35;
            //var grade = mark >= 65 ? "Pass" : "Fail";

            //int mark = 86;
            //var grade = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail"; // embedded

            //public static bool EvenOdd (int num)
            //{
            //    return num % 2 == 0;
            //}


        }
        //public static string Priority(int level)
        //{
        //    string priority = "Code ";
        //    switch (level)
        //    {
        //        case 3:
        //            priority = priority + "Red";
        //            break;
        //        case 2:
        //        case 1:
        //            priority = priority + "Yellow";
        //            break;
        //        case 0:
        //            priority = priority + "Green";
        //            break;
        //        default:
        //            priority = " Error";
        //            break;
        //    }
        //    return priority;
        //}

        
    }
}
