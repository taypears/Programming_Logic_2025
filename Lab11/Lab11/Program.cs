namespace Lab11;

class Program
{
        /*1. Include your name, course number and CRN as a comment in your code.*/
            // TayeJa Pearson [CRN 13078]

        /*2. Include the instructions for each step as a comment in your code.*/

        /*3.  Create a class from one of the following – Person, Employee, Course, Tree, Dog, Cat, Product, Movie. 
        Your class name should be appropriately named. Add two fields to your class and assign values to both fields.
        Use public access modifiers for both of your fields.*/

                class Dog //new class called Dog added
                {
                    public string name = "Tito";
                    public int age = 6;
                

        /*4. Add a method to your class that returns a string variable and will be called from the main method.*/

                    public string DogName() //method to get dog name
                        {
                            return name;
                        }

        /*5. Add a method to your class that returns an integer variable and will be called from the main method.*/

                    public int DogAge() // method to get dog age
                        {
                            return age;
                        }
                

        /*6. Add a method to your class that does not return any values and is used to display information about your class.*/

                    public void DisplayDogInfo() //doesn't return any value; no parameters necessary
                        {
                            Console.WriteLine($"Dog name: {name}"); //Outputing dog name 
                            Console.WriteLine($"Dog age: {age}"); //Outputing dog age 
                        }
                }

        /*7. Create an object of your class. In the main method output the return value from the methods in steps 4 and 5. 
        Call the method in step 6 to print out the information for your class.*/

                public static void Main() //main method created
                    {
                        Dog myDog = new Dog(); //object called myDog created from Dog class

                            Console.WriteLine(myDog.DogName()); //calling method to get dog name
                            Console.WriteLine(myDog.DogAge()); //calling method to get dog age
                            myDog.DisplayDogInfo(); //calling method to display dog info

                    }
}
