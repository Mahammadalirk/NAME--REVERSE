using System;

namespace string__reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseName();
        }
       static void ReverseName()
        {  string name;
            Console.Write("ReverseName:");
            {
                name = Console.ReadLine();
                for (int i = 0; i < name.Length; i++)

                {
                    Console.Write(name [name.Length-i-1]);


                }
                Console.ReadKey();
            }
        }

    }
}
