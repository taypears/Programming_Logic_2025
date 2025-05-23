﻿namespace Lab14;


       /*1. Include your name, course number and CRN as a comment in your code.*/
         // TayeJa Pearson [IT 1050 CRN 13078]

        /*2. Include the instructions for each step as a comment in your code.*/

        /*3. Using the class that you created in lab 11 [Note - the class that you use in lab 14 must be the same as the class that you used in labs 11 and 12], add a void method (with a descriptive name) to your class that prints out a specific detail about your class. This method is different from the void method from lab 11 and lab 12. You can refer to lab 13 as a guide in completing this step. [Refer to example at https://www.w3schools.com/cs/cs_polymorphism.php ]*/

        class Dog //base class called Dog added
            {
                public virtual void DogSize() //virtual method is unique to the base class and can be overridden in the derived class
                {
                    Console.WriteLine("Dogs come in different sizes"); //Outputing dog breed 
                }
            }
        /*4. Create a derived class (child class) of your class and add the same void method from step 3 to the derived class and the message that the method prints is different from the base class (parent class) i.e. the void method of the base class and the derived class must all have different messages printed.*/
        
        class LargeDog : Dog //derived class called LargeDog added
            {
                public override void DogSize() //overrides dog size method from base class
                {
                    Console.WriteLine("Large dogs are usually 50-100 pounds"); //Outputing dog breed 
                }
            }
       /*5.Create an object of your derived class (child class) and call its method. Create an object of the base class (parent class) and call its method.*/

            class Program
        {
            static void Main(string[] args)
            {
                Dog myDog = new LargeDog(); //object called myDog created from Dog class
                myDog.DogSize(); //calling method to get dog breed
            }
        }
