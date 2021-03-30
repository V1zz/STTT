namespace Setup
{
    using Core;
    using System;


    public class ConsoleUIProvider
    {
        public void Show(int[] array)
        {
            Console.WriteLine("===========================================================================");
            for (var i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}");
                if (((i + 1) % 10) == 0)
                {
                    Console.WriteLine();
                    continue;
                }
                Console.Write("\t");
            }
            Console.WriteLine("===========================================================================");
        }

        public void Start()
        {
            bool flag;
            CoreHelper core;

            
            do
            {
                core = new CoreHelper();

                flag = true;
                Console.WriteLine("> init*");
                Show(core.ModelArr);
                Show(core.ModelArr1);
                Console.WriteLine("> run b-sorting");
                core.BubbleSortMethod();
                Console.WriteLine(":-------------------------------------------------------------------------:");
                Console.WriteLine("> result:");
                Show(core.ModelArr);
                Show(core.ModelArr1);
                Console.WriteLine(".........esc to esc..........");

                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                    flag = false;

            } while (flag);
        }
    }
}
