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
                    finally
                    {
                       // Console.WriteLine("This is the finally block. The program will continue to run."); //finally block to ensure program continues to run
                    }
    }

         /*4. A) Using the class that you created in Lab 11, add two more fields to your class and use the private access modifier for these new fields. 
         B) Add a default constructor that does not accept any parameters and sets the value of all four fields with default (initial) values. Modify the void method in your class that prints the class details so that it will print all four fields.*/

                    class Dog //new class called Dog added
                        {
                        public string name = "Tito"; //name field added
                        public int age = 6; //age field added
                        private string breed = "Boxer Terrier"; //private access modifier breed added
                        private string color = "Brown"; //private access modifier color added

                        public Dog() //default constructor added
                            { //values set
                                name = "Tito"; 
                                age = 6; 
                                breed = "Boxer Terrier"; 
                                color = "Brown"; 
                            }
                            public void displayDogInfo()
                            {
                                Console.WriteLine("Dog Name: " + name); 
                                Console.WriteLine("Dog Age: " + age); 
                                Console.WriteLine("Dog Breed: " + breed); 
                                Console.WriteLine("Dog Color: " + color); 
                               
                            }
                        


    }
}
