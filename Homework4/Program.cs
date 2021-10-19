using System;

namespace Homework4
{
    class Person
    {
        private string name;
        private DateTime birthYear = new DateTime();
        System.DateTime now = new System.DateTime(2021);
        string Name {
            get => name;
        }
        DateTime BirthYear
        {
            get => birthYear;
        }
        public Person() { }
        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }
        public void Age()
        {
            int year = now.Year;
            int birth = Convert.ToInt32(birthYear);
            Console.WriteLine($"The age of a person:{year - birth}");
        }
        public void Input()
        {
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your birth year: ");
            name = Console.ReadLine();
        }
        public void ChangeName()
        {
            Console.WriteLine("Enter your new name: ");
            name = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"The name of a person is: {name}, birth year: {birthYear}";
        }
        public void Output()
        {
            Console.WriteLine($"{this}");
        }
    }



    class MainClass
    {
        public static void Main(string[] args)
        {
            Person Boba = new Person();
            Boba.Output();

        }
    }
}
