namespace Lab_5;

class Program
{
    static void Main(string[] args)
    {
        /* 1. Include your name, course number and CRN as a comment in your code.
                TayeJa Pearson [IT 1050 CRN 13078]*/
        
        /* 2. Include the instructions for each step as a comment in your code.*/

        /* 3. Given 2 integer variables temp1= 53 and temp2 = 25, use an if statement to output
                 “COLD WEATHER!” if temp2 is less than temp1.*/
                
              {  int temp1 = 53;
                int temp2 = 25;

                if (temp2 < temp1)
                    {Console.WriteLine ("COLD WEATHER!");}
              }
        /* 4. Create a Boolean variable named checkAge, assign a value to it and use an if-else 
                statement to determine if a person is an adult or not. If checkAge is true, output 
                "The person is an adult." If checkAge is false, output "The person is not an adult." */
                
                 {bool checkAge;
                 checkAge = true;
                        if (checkAge)
                         { Console.WriteLine("The person is an adult.");}
                        else
                         { Console.WriteLine("The person is not an adult.");}
                 }
        /* 5. Use a switch statement to output the following values for swimming course level description.
                Level 1 - Introduction to Water Skills
                Level 2 - Fundamental Aquatic Skills
                Level 3 - Stroke Development
                Level 4 – Stroke Improvement
                Level 5 – Stroke Refinement
                Level 6 - Swimming and Skill Proficiency*/
                {   int level = 4; // $ is an example value
                switch (level)
        {   case 1:
                Console.WriteLine(" Introduction to Water Skills");
                break;
            case 2:
               Console.WriteLine(" Fundamental Aquatic Skills");
               break;
            case 3:
                Console.WriteLine(" Stroke Development");
                break;
            case 4:
                Console.WriteLine(" Stroke Improvement");
                break;
            case 5:
                Console.WriteLine(" Stroke Refinement");
                break;
            case 6:
                Console.WriteLine(" Swimming and Skill Proficiency");
                break;
        }
                }
                

        /* 6. Convert the switch statement in step 5 to an if-else if-else statement.
                ***This code may be right ... DOUBLE CHECK!! */
        { int level = 4;

            if (level == 1)
                {
                Console.WriteLine(" Introduction to Water Skills");
                }
            else if (level == 2)
                {
                Console.WriteLine(" Fundamental Aquatic Skills");
                }
            else if (level == 3)
                {
                Console.WriteLine(" Stroke Development");
                }
            else if (level == 4)
                {
                Console.WriteLine(" Stroke Improvement");
                }
            else if (level == 5)
                {
                Console.WriteLine(" Stroke Refinement");
                }
            else if (level == 6)
                {
                Console.WriteLine(" Swimming and Skill Proficiency");
                }
             else
                {
                Console.WriteLine("Please enter a level between 1 and 6.");
                }
        }
        
    }
}
