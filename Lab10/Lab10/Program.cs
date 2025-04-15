namespace Lab10;

class Program
{
    // static void Main(string[] args)
    // { }
    
        /*1. Include your name, course number and CRN as a comment in your code.*/
               //TayeJa Pearson [IT1050 CRN 13078]

        /*2. Include the instructions for each step as a comment in your code.*/

        /*3. Create a class named Order. Add a field called name to the Order class, use the public access modifier for the name field. Assign your name to the name field. */
        class Order //Order class created
            {
                public string name = "TayeJa Pearson"; //name field created and assigned with my name

        /*4. Add a method called getOrder(). Have it return the title of your favorite book or textbook. Add a method called getOrderDesc(). Have it return a brief description of the favorite book/textbook that you used for getOrder() method. */
                public string getOrder() //getOrder method created
                {
                    return "Twilight by Stephenie Meyer"; //book title returned
                }

                public string getOrderDesc() //getOrderDesc method created
                {
                    return "A series about a teen who moves to Forks, Washington and falls in love with a vampire in her class."; //book description returned
                }

        /*5. Add a method called printOrderName. It should not return any values. In the body of the method, add the following line: Console.WriteLine(this.name); */
                public void printOrderName() //printOrderName method created
                {
                    //this.name = name field
                    //Console.WriteLine(this.name) = outputs the name field
                
                    Console.WriteLine(this.name);
                }
            }
                
        /*6. Create an object called order1. Output the value of the name field (order1.name) inside of a Console.WriteLine() statement. */
        static void Main(string[] args)
        {
            Order order1 = new Order(); //order1 object created

            Console.WriteLine(order1.name); //name field outputted
                    
        /*7. Output the return value from order1.getOrder(). Output the return value from order1.getOrderDesc(). Call printOrderName() to output name again. */
            Console.WriteLine(order1.getOrder());
            Console.WriteLine(order1.getOrderDesc());
            order1.printOrderName();
        }
                
    
}
