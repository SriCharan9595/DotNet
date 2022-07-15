using System;

namespace MyApplication
{
    class Dog
    {
        public void name()
        {
            Console.WriteLine("Sam");
        }
        private void color()
        {
            Console.WriteLine("White");
        }
        protected void age()
        {
            Console.WriteLine("5 Years");
        }
    }

    class Animal
    {
        static void Main(string[] args)
        {
            Dog labrador = new Dog();

            labrador.name();
            labrador.color();
            labrador.age();
        }
    }
}