namespace q2
{//name - kayla mcgowan
 //student no. - s00233714
 //Question 2 from Worksheet 1

    /*
     * a) Write a method, CountOddNumbers, which reads in 5 integer values from the console, 
     * and returns the number of them which are odd. 

    b) Write a method, AverageMinMax, to read in 5 integer values from the console and output their average, 
    the smallest number entered and the largest number entered to the console.
     
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            //commenting out part(a) of question 2
            // Console.WriteLine($"Number of Odds is - {CountOddNumbers()}");

            //method being called for part (b) question 2
            AverageMinMax();
            //output of average num
            Console.WriteLine($"Average - {AvgScore()}");//calling function here

            /*
            static int CountOddNumbers()//method for part(a) question 2 
            {
                //a)
                //Write a method, CountOddNumbers,
                //which reads in 5 integer values from the console,
                //and returns the number of them which are odd. 

                int countOfOdds = 0;//count at 0 to be able to increment 
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Please enter a number      : ");
                    int num = int.Parse(Console.ReadLine());
                    if (num % 2 != 0)
                    {
                        countOfOdds++;//incrementing the number of odd numbers which is outside the loop
                    }
                }
                return countOfOdds;//returning the number of odds to where method is called 


            }
            */
            static int AverageMinMax()
            {//b) Write a method, AverageMinMax,
             //   to read in 5 integer values from the console and output their average,
             //   the smallest number entered and the largest number entered to the console.
                
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Please enter a number      : ");
                    int num = int.Parse(Console.ReadLine());

                    static double AvgScore()
                    {
                        double avg = num.Average();
                        return avg;
                    }
                }

            }

        }
    }
}