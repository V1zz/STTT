namespace Setup
{
    using Core;
    using System;


    public class ConsoleUIProvider
    {
        public void Show(int[] array)
        {
            Console.WriteLine("=============================");
            // Console.Write();
            for (var i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} - ");
                if (((i + 1) % 5) == 0 && i != 0)
                {
                    Console.WriteLine("\n");
                }
            }
            Console.WriteLine("===========================");
        }

        public void Start()
        {
            bool flag;
            var core = new CoreHelper();

            
            do
            {
                flag = true;
                Console.WriteLine("> init*");
                Show(core.ModelArr);
                Show(core.ModelInstance);
                Console.WriteLine("> run b-sorting");
                core.BubbleSortMethod();
                Console.WriteLine("-----------------------------:");
                Console.WriteLine("> result:");
                Show(core.ModelArr);
                Show(core.ModelInstance);
                Console.WriteLine(".........esc to esc..........");

                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                    flag = false;

            } while (flag);
        }
    }
}
