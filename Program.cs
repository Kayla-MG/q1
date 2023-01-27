namespace q1
{//WORKSHEET1 Q1
 //name - kayla mcgowan
 //student no. - s00233714
 /*Question 1 from worksheet 1
    Each of these methods will take no parameters and will return void. 
 
    Call the method from your main method to test it.
a)  Write a method called PrintIntegersFor which uses a for loop to print all the integers between 40 and 60 in ascending order to the console.

b)	Write a second method called PrintIntegersWhile which does the same thing using a while loop.

c)	Write a third method, PrintIntegersDo, which does the same thing using a do..while loop.
    Explain to the person beside you how these constructs differ.

d)  Write a method, PrintExcludingFor, which uses a  for loop to print all integers between 40 and 60 excluding 46 and 48.

e)	Write a method, PrintDescendingFor, which uses a for loop to print all integers between 60 and 40 in descending order.
 */

    internal class Program
    {
        static void Main(string[] args)
        {
            PrintIntegersFor();
            Console.WriteLine("**********************************************");
            PrintIntegersWhile();
            Console.WriteLine("**********************************************");
            PrintIntegersDo();
            Console.WriteLine("**********************************************");
            PrintExcludingFor();
            Console.WriteLine("**********************************************");
            PrintDescendingFor();
        }
        static private void PrintIntegersFor()
        {
           // a)	Write a method called PrintIntegersFor which uses a for loop to print all the integers between 40 and 60 in ascending order to the console.
            for (int i = 41; i < 60; i++)
            {
                Console.WriteLine($"{i}");
            }
        }
        
        static private void PrintIntegersWhile ()
            //b)	Write a second method called PrintIntegersWhile which does the same thing using a while loop.
        {
            int i = 41;
            while (i < 60)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        static private void PrintIntegersDo()
        {
            //c)    Write a third method, PrintIntegersDo, which does the same thing using a do..while loop.
            int i = 41;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 60);
        }
        static private void PrintExcludingFor()
        {
            //d)	Write a method, PrintExcludingFor, which uses a for loop to print all integers between 40 and 60 excluding 46 and 48.
            for (int i = 41; i < 60; i++)
            {
                if (i!= 46 && i != 48)
                {
                   Console.WriteLine($"{i}");
                }
                
            }
        }
        static private void PrintDescendingFor()
        {
            //e)	Write a method, PrintDescendingFor, which uses a for loop to print all integers between 60 and 40 in descending order.
            for (int i = 59; i > 40; i--)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}