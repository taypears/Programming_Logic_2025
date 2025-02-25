namespace lab4new;

class Program
{
    static void Main(string[] args)
    {
        /* 1. Include your name, course number and CRN as a comment in your code.
            TayeJa Pearson [IT 1050 CRN 13078]
        */

    /* 2. Include the instructions for each step as a comment in your code.
        */

    /* 3. Create two string variables and assign different values to both. 
        Use the string concatenation operator (+) to combine them and output the result. 
        Display the length of each string. Display the concatenated string in uppercase letters.
        */
            string firstName = "TayeJa";
            string lastName = "Pearson";
            string name = firstName + " " + lastName;
            Console.WriteLine (name);
            Console.WriteLine ("The length of the first string is " + firstName.Length);
            Console.WriteLine ("The length of the second string is " + lastName.Length);
            Console.WriteLine ("The length of both strings combined, including the space between the two, are " + name.Length);
            Console.WriteLine (name.ToUpper());

    /* 4. Create two integer variables and assign values of your choosing to both integers. 
        Output the following- the sum of the two integers, the difference of the two integers, 
        the product of the two integers and the result of dividing one integer by the second integer.
        In your output, specify what each answer represents and output the two integers that you used.
    */
            int a = 5;
            int b = 16;
            Console.WriteLine ("For the following arithmetic problems, the variables used are \"a\" which equals " + a + " and \"b\" which equals " + b);
            Console.WriteLine("The sum of the two integers is " + (a + b));
            Console.WriteLine("The difference of the two integers is " + (a - b));
            Console.WriteLine("The product of the two integers is " + (a * b));
            Console.WriteLine("The quotient of b\\a is " + (b/a));


    /* 5. Display a prompt to a user for a number input. Take the user’s input and convert it to an integer.
            Evaluate and display the result of the expression - nine times the number entered, minus twice
             the number entered, plus the sum of the digits in your age.
        */
            Console.WriteLine ("Please enter a number:");
            int userInput = Convert.ToInt32 (Console.ReadLine ());
            int answer = (((userInput*9)-(userInput*2))+(2+8));
            Console.WriteLine(answer);


    /* 6. Using the newline escape character and the tab escape character, output a list of courses 
            that you are registered for in Spring 2025 semester or subsequent semesters. 
            Use one Console.WriteLine statement to output your course list. Your course list 
            must be on separate lines with course names on the left and their corresponding
             course titles to the right.
        */
        Console.WriteLine (
            "IT-2310 \t Web Programming\n IT-1025 \t Information Technology Concepts for Programmers\n IT-1050\t Programming Logic"
        );

    /* 7. Assign values to two string variables and use string interpolation ($) to combine 
        the two string variables and output the result of combining the two string variables.
         Use meaningful names for your variables.
        */
        string part1 = "apples";
        string part2 = "oranges";
        string sentence=$"You can't compare {part1} and {part2}. They are incomparable.";
        Console.WriteLine (sentence);
    }
}
