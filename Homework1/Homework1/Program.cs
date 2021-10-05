using System;

namespace Homework1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("\t\t\t TASK 1 \n");

            //Task 1.1
            Console.WriteLine("  TASK 1.1 \n");
            Console.WriteLine("Enter a:");
            int a = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);

            //Task 1.2
            Console.WriteLine("\n  TASK 1.2 \n");
            Console.WriteLine("How are you?");
            string answer = Console.ReadLine();
            Console.WriteLine("You are {0}", answer);
           
            //Task 1.3
             Console.WriteLine("\n  TASK 1.3 \n");
            Console.WriteLine("Press any key: ");
            char s = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Press ane key: ");
            char p = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Press any key: ");
            char w = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("You enter {0}, {1}, {2}", s, p, w);

            //Task 1.4
            Console.WriteLine("\n  TASK 1.4 \n");
            Console.WriteLine("Enter the first variable: ");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second variable: ");
            int var2 = Convert.ToInt32(Console.ReadLine());
          
            if(var1 >= 0 && var2 >= 0)
            {
                Console.WriteLine("Variable are both positive");
            }
            else
            {
                Console.WriteLine("Variable are not both positive");
            }

            //Homework. Task 1
            Console.WriteLine("\n\t\t\t HOMEWORK \n");
            Console.WriteLine("\n Homework. Task 1 \n");
            Console.WriteLine("Enter length of a side: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int area = a1 * a1;
            int perimeter = 4 * a1;
            Console.WriteLine("Length of a side is: {0}, the area is: {1}, the perimeter is: {2}", a1, area, perimeter);

            //Homework. Task 2
            Console.WriteLine("\n Homework. Task 2 \n");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you {0}?", name);
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is {0} and you are {1} years old", name, age);

            //Homework. Task 3
            Console.WriteLine("\n Homework. Task 3 \n");
            Console.WriteLine("Enter the radius of a circle: ");
            double r = Convert.ToInt32(Console.ReadLine());
            double lenght = 2 * Math.PI * r;
            double area1 = Math.PI * r * r;
            double volume = 4 / 3 * Math.PI * r * r * r;
            Console.WriteLine("The lenght = {0}, area = {1}, volume = {2}", lenght, area1, volume);

        }

    }
}


