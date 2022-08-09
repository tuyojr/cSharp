﻿using System;

namespace cSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Working with Strigs
            //string name = "\"Tuyo\"";
            //string phrase1 = "My name is Adedolapo ";
            //string phrase2 = " Olutuyo.";
            //string firstName = "John";
            //string lastName = "Doe";
            //string name1 = $"My full name is: {firstName} {lastName}";

            //Console.WriteLine(name1);

            //Console.WriteLine(phrase1 + name + phrase2);

            //Console.WriteLine(phrase2.ToUpper());
            //Console.WriteLine(name.ToLower());
            //Console.WriteLine(phrase1.Contains("name"));
            //Console.WriteLine(phrase1.Substring(11, 3));
            //Console.WriteLine(phrase1.Length);

            ////2. Working with numbers

            //int num = 4;
            //num++; //adds 1 to the num variable
            ////num-- subtracts 1 from the num variable

            //Console.WriteLine(num);
            //Console.WriteLine( 4 % 2 );
            //Console.WriteLine( (4 + 4) * 3 );
            //Console.WriteLine( 10 / 3 );
            //Console.WriteLine(10 / 3.0);
            //Console.WriteLine( Math.Abs(-300) ); //prints the absolute value to the screen
            //Console.WriteLine( Math.Pow(2, 3) ); //second number is the power which the first is raised to
            //Console.WriteLine( Math.Sqrt(64) ); //prints the square root of 64
            //Console.WriteLine( Math.Max( 10, 100 )); //prints out the greater number
            //Console.WriteLine( Math.Min( 10, 100 )); //prints out the lesser number
            //Console.WriteLine( Math.Round( 7.3 )); //rounds up the number to the nearest whole number. below .5 returns the number before the decimal point
            //Console.WriteLine( Math.Round( 7.5 )); //rounds up the number to the nearest whole number. .5 and above adds 1 to the number before the decimal point
            //Console.WriteLine(Convert.ToString(num));



            ////3. Getting User Input
            ////Console.WriteLine(); prints a line of text and then goes to a new line
            ////Console.ReaLine(); takes the line of text the user enters and saves it as a string


            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //string age = Console.ReadLine();
            //Console.WriteLine("Hello " + name + ", you are " + age + "years old.");



            //4. Building a calculator

            ////for inetgers
            //Console.Write("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            ////for decimals
            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter a second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("The sum is " + (num1 + num2));


            ////5. Building a Mad Libs Game

            //string verb_ed, verb, noun_body_part, noun, adjective,
            //    noun_beverage, noun_something_gross;

            //Console.Write("Enter a verb ending in -ed: ");
            //verb_ed = Console.ReadLine();

            //Console.Write("Enter a verb: ");
            //verb = Console.ReadLine();

            //Console.Write("Enter a noun(body part): ");
            //noun_body_part = Console.ReadLine();

            //Console.Write("Enter a noun: ");
            //noun = Console.ReadLine();

            //Console.Write("Enter an adjective: ");
            //adjective = Console.ReadLine();

            //Console.Write("Enter a noun(beverage): ");
            //noun_beverage = Console.ReadLine();

            //Console.Write("Enter a noun(something gross): ");
            //noun_something_gross = Console.ReadLine();

            //Console.WriteLine(

            //   "If zombies " + verb_ed + " a picnic, what would they "
            //   + verb + " to eat? Everybody knows zombies love to " +
            //   verb + " " + noun_body_part + ", but did you know they also enjoy "
            //   + noun_body_part + " and even " + noun_body_part + "? The best "
            //   + noun + " for a zombie picnic is when the moon is " + adjective +
            //   ". At least one zombie will bring " + noun_beverage + " to drink, and it is not a picnic without "
            //   + noun_body_part + " with extra " + noun_something_gross
            //   + " on top. After eating, zombies will " + verb + adjective
            //   + " games like kick the " + noun_body_part + " and "
            //   + noun_body_part + " toss."
            //);



            ////6. Arrays

            //int[] arr = { 2, 4, 6, 8, 10, 12, 14};
            ////update an element in the array
            //arr[0] = 16;

            //string[] topArtists = new string[10];
            //topArtists[0] = "J. Cole";
            //topArtists[1] = "Dave";
            //topArtists[2] = "Cordae";
            //topArtists[3] = "Juice Wrld";
            //topArtists[4] = "XXXTENTACION";
            //topArtists[5] = "2pac";
            //topArtists[6] = "The Notorious B.I.G.";
            //topArtists[7] = "Drake";
            //topArtists[8] = "Masego";
            //topArtists[9] = "Aaron May";

            //Console.WriteLine(arr[0]);
            //Console.WriteLine(topArtists[5]);

            ////7. Methods
            ////Call the method created outside Main

            //SayHi("Jermaine", 37);
            //SayHi("Pac", 51);
            //SayHi("Cordae", 24);

            ////8. Return statement 

            //int cubed = Cube(16);

            //Console.WriteLine(Cube(8));
            //Console.WriteLine(cubed);


            ////9. If Statements

            //bool genderM = true;
            ////if it is false, nothing is printed.
            ////else statement is used to print something when the condition is false.

            //bool heightTall = true;

            ////&& - both conditions have to be true.
            ////|| - one of the condition has to be true.

            //if (genderM && heightTall)
            ////M=true, Tall=true
            ////male and tall
            //{
            //    Console.WriteLine("This person is a tall Male.");
            //}
            //else if (genderM && !heightTall)
            ////M=true, Tall=false
            ////male and not tall.
            ////if heigthTall was true, the ! would make it false and vice versa
            //{
            //    Console.WriteLine("This person is a Male that's not tall.");
            //}
            //else if (!genderM && heightTall)
            ////M=false, Tall=true
            ////not male, but tall.
            //{
            //    Console.WriteLine("This person is not a male, but tall.");
            //}
            //else
            ////M=false, Tall=false
            ////neither male nor tall.
            //{
            //    Console.WriteLine("This person is either not tall or not a Male or both.");
            //}


            ////10. Comparisons in if statements

            //Console.WriteLine(MaxNum(3, 17, 11));


            ////11. Buliding a better calculator

            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter an operator: ");
            //string oprtr = Console.ReadLine();

            //Console.Write("Enter another number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //if (oprtr == "+")
            //{
            //    Console.WriteLine(num1 + num2);
            //} else if (oprtr == "-")
            //{
            //    Console.WriteLine(num1 - num2);
            //} else if (oprtr == "*")
            //{
            //    Console.WriteLine(num1 * num2);
            //} else if (oprtr == "/")
            //{
            //    Console.WriteLine(num1 / num2);
            //} else if (oprtr == "%")
            //{
            //    Console.WriteLine(num1 % num2);
            //} else
            //{
            //    Console.WriteLine("Please enter a valid operator.");
            //}


            //12. Switch Statements

            Console.WriteLine(DayOfWeek(0));
            Console.WriteLine(DayOfWeek(1));
            Console.WriteLine(DayOfWeek(2));
            Console.WriteLine(DayOfWeek(3));
            Console.WriteLine(DayOfWeek(4));
            Console.WriteLine(DayOfWeek(5));
            Console.WriteLine(DayOfWeek(6));
            Console.WriteLine(DayOfWeek(16));









            Console.ReadLine();
        }

        ////7. Methods

        //static void SayHi(string name, int age)
        //{
        //    Console.WriteLine("Hello " + name + "! Whoa! you're " + age + "years old? Cool!");
        //}

        ////8. Return statement

        //static int Cube(int x)
        //    //you can also return "string" "double" "double[]" etc.
        //{
        //    int result = x * x * x;
        //    return result;
        //}

        //10. Comparisons in if statements

        //static int MaxNum(int num1, int num2, int num3)
        //{
        //    int result;
        //    //if (num1 > num2)
        //    //// > comparison resolves down to a true or false
        //    //{
        //    //    result = num1;
        //    //} else
        //    //{
        //    //    result = num2;
        //    //}

        //    if (num1 >= num2 && num1 >= num3)
        //    {
        //        result = num1;
        //    } else if (num2 >= num1 && num2 >= num3)
        //    {
        //        return num2;
        //    } else
        //    {
        //        result = num3;
        //    }

        //    return result;
        //}


        //12. Switch Statements

        static string DayOfWeek (int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                //in the case that dayNum is 0 (...to the last case 6), do dayNum = "Sunday".
                //the break statement helps us get out of the structure we're in.
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day of the week number.";
                    break;
            }


            return dayName;
        }

    }
}
