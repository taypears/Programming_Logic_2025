﻿namespace Lab13;

        /* 1.  Include your name, course number and course CRN as a comment in your code. */
            //TayeJa Pearson [IT 1050 CRN 13078]

        /*2.  Include the instructions for each step as a comment in your code. */

        /*3.  Given the following class Triangle as defined in the provided code Lab13.txt, create a derived (child) class called Equilateral. Add a method called displayTriangleInfo() that outputs the following statement “Equilateral triangles have 3 equal sides.”*/
            class Triangle //base class
            {
                public int side1;
		        public int side2;
		        public int side3;
		    public void displayTriangleInfo()
                {
                    Console.WriteLine("Triangles have 3 sides.");	
                }
                
                }
            

            class Equilateral : Triangle //derived class
            {    
                public void displayTriangleInfo()
                {
                    Console.WriteLine("Equilateral triangles have 3 equal sides.");
                }

            }
        

        /*4. Create a derived (child) class called Isosceles. Add a method called displayTriangleInfo() that outputs the following statement “Isosceles triangles have 2 equal sides.” */

            class Isosceles : Triangle //derived class
            {
                public void displayTriangleInfo()
                {
                    Console.WriteLine("Isosceles triangles have 2 equal sides.");
                }
            }

        /*5.  Create a derived (child) class called Scalene. Add a method called displayTriangleInfo() that outputs the following statement “Scalene triangles have no equal sides.” */

            class Scalene : Triangle //derived class
            {
                public void displayTriangleInfo()
                {
                    Console.WriteLine("Scalene triangles have no equal sides.");
                }
            }


        /* 6.  Create an object of type Equilateral. Call its displayTriangleInfo() method. */
            class Program
            {
                static void Main(string[] args)
            {


            Triangle triangle = new Triangle(); //base class object
            Equilateral equilateralTriangle = new Equilateral();
            equilateralTriangle.displayTriangleInfo();
            

        /*7.  Create an object of type Isosceles. Call its displayTriangleInfo() method. */

            Isosceles isoscelesTriangle = new Isosceles();
            isoscelesTriangle.displayTriangleInfo();

        /*8.  Create an object of type Scalene. Call its displayTriangleInfo() method.*/

            Scalene scaleneTriangle = new Scalene();
            scaleneTriangle.displayTriangleInfo();
            
            }
            }

