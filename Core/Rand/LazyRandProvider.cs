namespace Model.Rand
{
    using System;
    using System.Threading;             //WHY?

    class LazyRandProvider
    {
        private static Random _rand = new Random();
        private static readonly LazyRandProvider _instance = new LazyRandProvider();

        private LazyRandProvider()
        {
            Console.WriteLine($"> lazy singleton instance ***");
        }

        public static LazyRandProvider Instance()
        {
            Console.WriteLine($"> get lazy instance {DateTime.Now.TimeOfDay}");
            Thread.Sleep(500);                      //WHY?
            return Neasted._instance;            
        }

        private class Neasted
        {
            static Neasted() { }
            internal static readonly LazyRandProvider _instance = new LazyRandProvider();
        }
    }
}
