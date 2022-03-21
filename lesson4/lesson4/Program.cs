using System;

namespace lesson4
{
    class Program
    {


        static void Main(string[] args)
        {
            var ex = new handler();


            ex.OnKeyPressed += print;
            ex.Run();

            void print(Object sender, char letter)
            {
                Console.WriteLine($"\nВаш символ:  {letter}");
            }
        }
    }
}
