using System;

namespace dotnetcs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            static_method();  // Only static method can run inside the static main

            Program p = new Program();
            p.non_static_method(); // nonstatic method can be called through an instance of the class

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void static_method()
        {
            Console.WriteLine("This is static method!");
        }

        public void non_static_method(){
            Console.WriteLine("This is non-static method!");
        }

    }
}
