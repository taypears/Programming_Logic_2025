namespace Lab11;

class Program
{
        /*1. Include your name, course number and CRN as a comment in your code.*/
            // TayeJa Pearson [CRN 13078]

        /*2. Include the instructions for each step as a comment in your code.*/

        /*3.  Create a class from one of the following – Person, Employee, Course, Tree, Dog, Cat, Product, Movie. 
        Your class name should be appropriately named. Add two fields to your class and assign values to both fields.
        Use public access modifiers for both of your fields.*/

                class Dog
                {
                    public string name = "Tito";
                    public int age = 6;
                

        /*4. Add a method to your class that returns a string variable and will be called from the main method.*/

                    public string DogName()
                        {
                            return name;
                        }

        /*5. Add a method to your class that returns an integer variable and will be called from the main method.*/

                    public int DogAge()
                        {
                            return age;
                        }
                

        /*6. Add a method to your class that does not return any values and is used to display information about your class.*/

                    public void DisplayDogInfo()
                        {
                            Console.WriteLine($"The dogs name is {name}.");
                            Console.WriteLine($"The dog is {age} years old.");
                        }
                }

        /*7. Create an object of your class. In the main method output the return value from the methods in steps 4 and 5. 
        Call the method in step 6 to print out the information for your class.*/

                static void Main(string[] args)
                    {
                        Dog myDog = new Dog();

                            Console.WriteLine(myDog.DogName());
                            Console.WriteLine(myDog.DogAge());
                            myDog.DisplayDogInfo();

                    }
}
