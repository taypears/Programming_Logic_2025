namespace Lab_6;

class Program
{
    static void Main(string[] args)
    {
        /*1.  Include your name, course number and CRN as a comment in your code. */
            //TayeJa Pearson [IT1050 CRN 13078 ]

        /*2.  Include the instructions for each step as a comment in your code. */

        /*3.  Create two integer variables. Assign values to them. Use an if statement to compare
         the two integer variables. In the body of the if statement add the greater number to the 
         smaller number and display the result.  In addition, display the two integer values that 
         you are using.*/
            {
                int var1 = 10;
                int var2 = 20;
                if (var2>var1)
                    { 
                        Console.WriteLine("Variable 1 is less than variable 2."); 
                    }
                Console.WriteLine(var1+var2);
                Console.WriteLine ("The value of Variable 1 is "+ var1);
                Console.WriteLine ("The value of Variable 2 is "+ var2);

            }

        /*4. Using two integer variables with different values assigned to them, use an if-else 
        statement to determine how the first number relates to the second number and print a message 
        that specifies the relationship. Your message must include the numbers being used. For example,
        if the two numbers are 1 and 2, the message printed out would be 1 is less than 2. */
            {
                int input1 = 16;
                int input2 = 5;
                if (input1 >input2)
                    { 
                        Console.WriteLine("Input 1 is greater than Input 2."); 
                    }
                Console.WriteLine ("The value of Input 1 is " + input1);
                Console.WriteLine ("The value of Input 2 is " + input2);

            }

        /*5.  Use an if-else if-else statement to print a message that displays the educational level 
        of a student based on the student’s number of years of schooling as given below in the table: 
        Number of years of schooling - Educational Level
                0 - None
                1-5 - Elementary School
                6-8 - Middle School
                9-12 - High School
                More than 12 - College
        Print a message to indicate bad data as well. Prompt the user for an input. */
            {
                Console.WriteLine ("Enter the student's number of years in school: ");
                int years = Convert.ToInt32 (Console.ReadLine ()); //Takes a user input into the program
                if (years == 0) 
                    {
                        Console.WriteLine ("None");
                    }
                else if (years>= 1 && years<=5) 
                   {
                        Console.WriteLine ("Elementary School");
                    }
                else if (years>= 6 && years<=8) 
                   {
                        Console.WriteLine ("Middle School");
                    }
                else if (years>= 9 && years<=12) 
                   {
                        Console.WriteLine ("High School");
                    }
                else if (years>= 13) 
                   {
                        Console.WriteLine ("College");
                    }  
                else
                {
                        Console.WriteLine ("Please enter a valid number.");
                }
            }
        /*6.    Use a switch statement to output one of the following values for coding/programming skill levels 
                Level 1 – Unworkable code
                Level 2 – Workable Code
                Level 3 – Good performance and secured code
                Level 4 – Standard and reusable code
                Level 5 – Easy to understand and Scalable code*/

                {
                    Console.WriteLine ("Enter your coding/programming skill level: ");
                    int level = Convert.ToInt32 (Console.ReadLine ()); //Takes a user input into the program
                    switch (level)
                    {
                        case 1:
                            Console.WriteLine(" Unworkable code");
                            break;
                        case 2:
                            Console.WriteLine(" Workable Code");
                            break;
                        case 3:
                            Console.WriteLine(" Good performance and secured code");
                            break;
                        case 4:
                            Console.WriteLine(" Standard and reusable code");
                            break;
                        case 5:
                            Console.WriteLine(" Easy to understand and Scalable code");
                            break;
                    }
                    
                }
    }
}
