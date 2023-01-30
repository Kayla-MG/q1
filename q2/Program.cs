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
            static void AverageMinMax()
            {//b) Write a method, AverageMinMax,
             //   to read in 5 integer values from the console and output their average,
             //   the smallest number entered and the largest number entered to the console.

                int[] numInput = new int[5];
                int low, high;
                double avg;


                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{"Please enter a number" + (i + 1) + ": ",-40}");
                    numInput[i] = int.Parse(Console.ReadLine());
                }


                //highest value method
                static int GetHigh(int[] numInput)
                {
                    int high = numInput.Max();
                    return high;

                }

                //lowest value method
                static int GetLow(int[] numInput)
                {
                    int low = numInput.Min();
                    return low;
                }

                static double GetAvg(int[] numInput)
                {
                    double avg = numInput.Average();
                    return avg;
                }
                //call all methods now
                avg = GetAvg(numInput);
                high = GetHigh(numInput);
                low = GetLow(numInput);

                //display results
                Console.WriteLine($"\n{"Results", -40}");
                Console.WriteLine($"\n{"Average - " +(avg), -40}");
                Console.WriteLine($"\n{"Highest - " +(high), -40}");
                Console.WriteLine($"\n{"Lowest - " + (low),-40}");



            }

            }

        }
    }
