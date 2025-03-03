namespace Lab_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        /* 1. Include your name, course number and CRN as a comment in your code.
                TayeJa Pearson [IT 1050 CRN 13078]*/
        
        /* 2. Include the instructions for each step as a comment in your code.*/

        /* 3. Given 2 integer variables temp1= 53 and temp2 = 25, use an if statement to output
                 “COLD WEATHER!” if temp2 is less than temp1.*/
                
                int temp1 = 53;
                int temp2 = 25;

                if (temp2 < temp1)
                    {Console.WriteLine ("COLD WEATHER!");}

        /* 4. Create a Boolean variable named checkAge, assign a value to it and use an if-else 
                statement to determine if a person is an adult or not. If checkAge is true, output 
                "The person is an adult." If checkAge is false, output "The person is not an adult." */
                
                 bool checkAge;
                 checkAge = true;
                        if (checkAge)
                         { Console.WriteLine("The person is an adult.");}
                        else
                         { Console.WriteLine("The person is not an adult.");}

        /* 5. Use a switch statement to output the following values for swimming course level description.
                Level 1 - Introduction to Water Skills
                Level 2 - Fundamental Aquatic Skills
                Level 3 - Stroke Development
                Level 4 – Stroke Improvement
                Level 5 – Stroke Refinement
                Level 6 - Swimming and Skill Proficiency*/

                

        /* 6. Convert the switch statement in step 5 to an if-else if-else statement.
                ***This code may be right ... DOUBLE CHECK!! */
                int carSpeed = 102;

            if (carSpeed >= 130 && carSpeed <= 200)
            {
                Console.WriteLine("Accident");
            }
            else if (carSpeed >= 110 && carSpeed <= 129)
            {
                Console.WriteLine("Police");
            }
            else if (carSpeed >= 100 && carSpeed <= 109)
            {
                Console.WriteLine("Casual Highway");
            }
            else if (carSpeed >= 50 && carSpeed <= 99)
            {
                Console.WriteLine("Just OK");
            }
            else if (carSpeed >= 0 && carSpeed <= 49)
            {
                Console.WriteLine("Slow Poke");
            }
            else
            {
                Console.WriteLine("Out of Range");
            }

    }
}
