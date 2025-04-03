namespace Lab9;

class Program
{
    static void Main(string[] args)
    {

       /*1. Include your name, course number and CRN as a comment in your code.*/ 
            //TayeJa Pearson [IT1050 CRN 13078] 

        /*2. Include the instructions for each step as a comment in your code.*/ 

        /* 3. Create an array to store six string values of courses that you are currently taking or planning to take for your degree. Give your array a descriptive name and print out the array values on separate lines either using a for loop or a foreach loop. */

            string [] courses = new string[6]; // Declared array with string size 6
            courses[0] = "IT1050"; //0 is the first element of the array
            courses[1] = "IT1050"; 
            courses[2] = "IT2310"; 
            courses[3] = "IT2320"; 
            courses[4] = "IT2351"; 
            courses[5] = "IT2650"; 
            
            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }

        /* 4. Create an array to store 8 integer values that represent the different ages of people in a community. Give your array a descriptive name and print out the array values on one line with a space between the values using either a for loop or a foreach loop to print out the values. Make sure that your output is readable. */

            int [] ages = new int[8]; // Declared array with integer size 8
            ages[0] = 5; 
            ages[1] = 12; 
            ages[2] = 27; 
            ages[3] = 29; 
            ages[4] = 34; 
            ages[5] = 49; 
            ages[6] = 50; 
            ages[7] = 76; 

            foreach (int age in ages)
            {
                Console.Write(age + " ");
            }

        /* 5. Create an array to store 7 different temperature values that represent winter temperatures in the Cleveland area. Give your array a descriptive name. Print the array values and the average of the 7 temperature values. */

            double [] temps = new double[7]; // Declared array with double size 7
            temps[0] = 16.5; 
            temps[1] = 20.0; 
            temps[2] = 21.6; 
            temps[3] = 23.6; 
            temps[4] = 26.8; 
            temps[5] = 27.4; 
            temps[6] = 29.5; 

           double tempSum = 0;
           double tempAvg = 0;
            foreach (double temp in temps)
            {
                Console.Write(temp + " ");
                tempSum = tempSum + temp; // Add each temperature to the sum
            }
            tempAvg = tempSum / temps.Count(); // Divide the sum by the number of temperatures to get the average

            Console.WriteLine("The average winter temperature in Cleveland is " + tempAvg + " degrees.");


        /* 6. Create parallel arrays for the following product names and prices. Use Products for the first array's name and Prices for the second array's name. Output the two together using a loop.
                    Products: Vinegar, Trash bags, Milk, Paper Towels, Bagels
                    Prices: 3.47, 6.97, 2.60, 2.58, 3.97

                    The output would be the following

                    Vinegar         3.47
                    Trash bags    6.97
                    Milk               2.60
                    Paper Towels 2.58
                    Bagels            3.97 */

            string [] products = new string[5]; // Declared array with string size 5
            products[0] = "Vinegar";
            products[1] = "Trash bags";
            products[2] = "Milk";
            products[3] = "Paper Towels";
            products[4] = "Bagels";
        
            double [] prices = new double [5]; // Declared array with double size 5
            prices[0] = 3.47;
            prices[1] = 6.97;
            prices[2] = 2.60;
            prices[3] = 2.58;
            prices[4] = 3.97;

            for (int i=0; i < products.Length; i++)
            {
                Console.WriteLine($"{products[i]} {prices[i]}"); 
            }

        /* 7. Given the following 2D array, int [ , ] StudentScores = { {75, 82, 90}, {88, 89, 92}, {65, 70, 74} }; print out the values of the array so that they display in a table format as shown below:  

            Test 1	Test 2	Test 3
            Student 1	75	82	90
            Student 2	88	89	92
            Student 3	65	70	74
            You may include the column and row headings in your printout. Make sure to put spaces between the values in your printout. */

            int [,] StudentScores = { {75, 82, 90}, {88, 89, 92}, {65, 70, 74} };
            Console.WriteLine ("Test 1 Test 2 Test 3"); // Column headings
            
            
    }
}
