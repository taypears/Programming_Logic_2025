﻿namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //1.Include the instructions for each step as a comment in your code.

        /*2. Add a multi-line comment with your name, email address course number and CRN.
            TayeJa Pearson, S01322082@acad.tri-c.edu, 1050, 13078*/
                Console.WriteLine("TayeJa Pearson, S01322082@acad.tri-c.edu, 1050, 13078");

        /*3. Needs more: Create an integer variable to store a number that represents something significant to and assign it a number
                Create a variable of type double and assign a value of your choosing to it.
                Output the integer value onto the screen. Output the double variable onto the screen.
                */
                int myYear = 1997;
                double moYr = 5.16;
                Console.WriteLine(myYear); //not printing the chosen variable because quotes were present
                Console.WriteLine(moYr);
        //4. Create a string variable and assign a value of your choosing 
                string
        //5. Create a boolean variable ...

        /*6. In a multi-line comment state what happens in a C# program when C# syntax is incorrectly used. 
            In your response, state exactly what is wrong with each line. Use the following code (Make sure you run the code)  


            If there are syntax errors, it is possible that the code will not run at all. 
            Since C# is case-sensitive, if a single element is not capitalized it can cause a syntax error.
            Also shown below, if quotations and parenthesis aren't used appropriately or if the ending semicolon is missing then it could also cause an error in the code as shown below.
            These errors could cause the code to be non-functional.
            
            console.WriteLine("Hello World!"); -> The "C" is not capitalizd in Console
            Console.Writeline("First C# code!"); -> The "L" is not capitalizd in WriteLine
            Console.WriteLine(Hello IT1050 Students!"); -> The beginning quote is missing in the parenthesis before the word "hello"
      */
            Console.WriteLine("Hello World!");
            Console.WriteLine("First C# code!");
            Console.WriteLine("Hello IT1050 Students!");
    }
}
