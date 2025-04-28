namespace Lab12a;

class Program
{
    static void Main(string[] args)
    {
        /*1.   Include your name, course number and course CRN as a comment in your code.*/
                //TayeJa Pearson [IT 1050 CRN 13078]

        /*2.   Include the instructions for each step as a comment in your code.*/

        /*3.   Use the following given code to demonstrate exception handling. Run the code first to see the unhandled exception message and then add exception handling code to ensure that the line Console.WriteLine(Numbers[6]); does not crash the program. The Numbers array is a 6-integer array and defined as follows:
        int [ ] Numbers = { 23, 45, 76, 89, 12, 37};    //declare array 
        for (int i = 0; i < Numbers.Length; i++) {       //print out array values
                    Console.WriteLine(Numbers[i]);
                }
        Console.WriteLine(Numbers[6]);     //try to access invalid index of array [Note - To ensure that your code runs, put the given code and your exception handling code in the Main method of your C# program]*/
            
                    int [ ] Numbers = { 23, 45, 76, 89, 12, 37};    //declare array 
    
                    for (int i = 0; i < Numbers.Length; i++) 
                        {       
                        Console.WriteLine(Numbers[i]); //prints array values
                        }
                    try
                    {
                        Console.WriteLine(Numbers[6]);     //try to access invalid index of array 
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("Error: " + e.Message); //catch exception and print error message
                    }
    }
}
