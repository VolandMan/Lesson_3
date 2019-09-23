using System;

namespace NumSecret
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Num = new Random();
            int RandomNum = Num.Next(0, 100); 
            int UserNum; 
            int attempt = 1;     
                     
                     
                Console.WriteLine("I came up with a number from 0 to 100, guess it:");
                UserNum = Convert.ToInt32(Console.ReadLine());

                while (UserNum != RandomNum)
                {
                    Console.Write($"Attempt number № { attempt} = ");
                    attempt++;
                    if (attempt == 6) break;

                    Console.WriteLine( (RandomNum > UserNum) ? "My number is bigger " : "My number is less  ");
                    UserNum = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine((RandomNum == UserNum) ? "Congratulations! You are a winner" : "Sorry! You are a loser", attempt);

                     
        }
    }
}