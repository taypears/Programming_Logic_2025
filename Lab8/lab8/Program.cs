namespace lab8;

class Program
{
    static void Main(string[] args)
    {
        /*1. Include your name, course number and CRN as a comment in your code.*/ 
            //TayeJa Pearson [IT1050 CRN 13078] 

        /*2. Include the instructions for each step as a comment in your code.*/ 

        /*3. Use a while loop to print the first eight multiples of 5 all on one line with one space between them for readability. Make sure that the output for the next step does not combine with the output for step 3.*/ 

            int i = 5; 
            int counter = 1;
                while (counter <= 8) 
                    { 
                    Console.Write(i * counter + " "); 
                    counter ++;
                    }
                    {
                        Console.WriteLine (" ");
                    }

        /*4. Use a for loop to print 10 consecutive numbers that are multiples of 4.  Make sure that the output for the next step does not combine with the output for step 4. */ 

            for( int j=4; j <= 40; j +=4) 
                { 
                Console.Write(j + " "); 
                } 
                { 
                Console.WriteLine (" "); 
                } 

        /*5. Use a while loop to print 12 numbers starting from the number 99 with the difference between the numbers being 8 and the numbers are counting down. Print all 12 numbers on one line with a space between the values for readability. Make sure that the output for the next step does not combine with the output for step 5. */ 

            int k =	 99; 
            while (k > 3) 
                { 
                Console.Write(k + " "); 
                k -= 8; 
                } 
                { 
                Console.WriteLine (" "); 
                } 

        /*6. Use a for loop to print values from 20 to 1. The printed values must all be on one line with one space between the values. Make sure that the output for the next step does not combine with the output for step 7. */ 

            for (int l =20; l >= 1; l--) 
            { 
            Console.Write(l + " "); 
            } 
            { 
            Console.WriteLine (" "); 
            } 

    
        /*7. Use a while loop to accomplish the following task - use a 5-digit integer variable to store a password and assign a value to it. Then prompt a user to enter the password which must match the stored password. The user has only three tries to match the stored password. If the user correctly matches the stored password, print a message letting the user know they entered the correct password. You must also let the user know how many tries they have remaining. After three tries of incorrectly matching the stored password, print a message letting the user know that there are no more chances to try to match the password. */ 
            
                int Pwd1 = 51997; //sets password to 51997
                bool userInp = false;
                int counter = 3;
                    while (true)
                    {
                    Console.WriteLine("Please enter your password:");
                    int userInput1 = Convert.ToInt32 (Console.ReadLine ());
                
                    if(userInput1 == Pwd1) 
                        {
                            userInp = true; //sets userInp to true if user input matches password
                        Console.WriteLine("The password you entered is correct.");  
                        break; //breaks out of the loop if user input matches password
                        }
                    else 
                        {
                            if (counter > 1) 
                                {
                                counter--;
                                Console.WriteLine ("Invalid input. You have " + counter + " attempts remaining. **Hint, it is a 5 digit number**");
                                //break;
                                }
                            else
                                {
                                Console.WriteLine ("You have exceeded the maximum amount of attempts. your account is now locked. Please contact your administrator to reset password");
                                break;
                                }
                        }
                    }
    

    }
}
