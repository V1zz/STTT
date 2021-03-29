namespace Model.Rand
{
    using System;


    class RandProvider1
    {
        private static Random _rand = new Random();
        private static object _sync = new Object();

        public static int Next()
        {
            lock (_sync) return _rand.Next();
        }
        public static int Next(int max)
        {
            lock (_sync) return _rand.Next(max);
        }
        public static int Next(int min, int max)
        {
            lock (_sync) return _rand.Next(min, max);
        }
    }
}
