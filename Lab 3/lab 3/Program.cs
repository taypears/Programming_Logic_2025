namespace lab_3;

class Program
{
    static void Main(string[] args)
    {

    /* 1. Include your name, course number and course CRN as a comment in your code. 
            You can use either single line or multi line comments.*/

            /*TayeJa Pearson, (yes, the "J" is supposed to be capitalized in my name)
            [IT 1050 CRN 13078]*/

    /* 2. Include the instructions for each step as a comment in your code. 
            You can use either single line or multi line comments.
    */

    /* 3. Create 5 integer variables a, b, c, d, and e. 
    Assign different values to all 5 integer variables and output the sum.
    */
            int a = 5;
            int b = 3;
            int c = 16;
            int d = 2;
            int e = 6;
            int sum = a+b+c+d+e;
            Console.WriteLine ("The sum of the 5 integer variables is " + sum + ".");

    /*4. Create a string variable to store your favorite color and assign your favorite color to it.
            Create another variable to store your favorite food and assign your favorite food to it.
            Use either the concatenation operator or string interpolation to combine both variables 
            and output a complete sentence that states your favorite color and your favorite food.
    */
            string favColor = "Emerald Green";
            string favFood = "birria tacos";
            string mySentence = $"My favorite color is {favColor} and my favorite food is {favFood}.";
            Console.WriteLine (mySentence);

    /*5. Create three double variables x, y, and z and assign values to them.
            Evaluate the following expression: ((x * y) + (z * x) – (2 * y))/(3 * y) 
            and print the result of the expression.
    */
            double x = 3.14D;
            double y = 4.99D;
            double z = 1.997D;
            Console.WriteLine (((x*y)+(z*x)-(2*y))/(3*y)); 

    /*6. Prompt a user to enter an integer value, then double the value, subtract 10 and display the result.
    */
            Console.WriteLine("Please enter an integer:");
            int userInput = Convert.ToInt32 (Console.ReadLine ());
            int answer = ((userInput*2)-10);
            Console.WriteLine(answer);

    }
}
