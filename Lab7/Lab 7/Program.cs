namespace Lab_7;

class Program
{
    static void Main(string[] args)
    {
        /*1.  Include your name, course number and CRN as a comment in your code. */
            //TayeJa Pearson [IT1050 CRN 13078 ]

        /*2.  Include the instructions for each step as a comment in your code. */

        /*3. Use a while loop to output values from 14 to 84. Increment the values by 7. Output all of the values
        on one line with one space between them. Note: 14 and 84 are inclusive. [Your output would be printed on
        the same line as 14 21 ... 84 ]. Make sure that the output for this step does not print with the output 
        for step 4. */

            int i = 14;
            while (i <= 84)
            {
                Console.Write(i + " ");
                i += 7;
            }
            {
                Console.WriteLine(" ");
            }
        /*4.  Use a while loop to output values from 64 to 31. Decrement the values by 3. Output all of the values
        on one line with one space between them. Note: 64 and 31 are inclusive. [Your output would be printed on the
        same line as 64 61 ... 34 31]. Make sure that the output for this step does not print with the output for
        step 3 or step 5. */
            int j = 64;
            while (j >= 31) // executes while the values are greater than 31
                {
                    Console.Write(j + " ");
                    j-=3;
                }
                {
                    Console.WriteLine(" ");
                }
        /*5. Use a for loop to output values 37 to 21 on one line with one space between the values. Decrement by 2. 
        Note: 37 and 21 are inclusive. [Your output would be printed on the same line as 37 35 ... 23 21]. Make sure 
        that the output for this step does not print with the output for step 4. */

            for (int k = 37; k >= 21; k-=2) 
               {
                    Console.Write(k + " ");
               }
                {
                    Console.WriteLine(" ");
                }
         /*6. Use a for loop to loop from 1 to 50. Each time through the loop, output the loop control variable and 
         whether or not it is divisible by 4. Output on separate lines. Example: The output should be as follows (and so on):
                // 1 is not divisible by 4
                //2 is not divisible by 4
                // 3 is not divisible by 4
                //4 is divisible by 4
                // Here is code for checking to see if it's divisible by 4 or not:
                // The condition (divbyfour % 4 == 0) checks for divisibility by 4
                // You just need to wrap a for loop around this if statement
                    if (divbyfour % 4 == 0) { 
                        Console.WriteLine($"{divbyfour} is divisible by 4.");
                    }
                    else {
                        Console.WriteLine($"{divbyfour } is not divisible by 4.");
                    }*/

            for (int l = 1; l <= 50; l++) 
               {
                    Console.WriteLine (l);
               }
                if (divbyfour % 4 == 0) 
                    { 
                    Console.WriteLine($"{divbyfour} is divisible by 4.");
                    }
                else 
                    {
                    Console.WriteLine($"{divbyfour } is not divisible by 4.");
                    }
               

    }
}
