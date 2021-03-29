namespace Model
{
    using System;
    using System.Security.Cryptography;



    static class RandClass
    {
        //private static RandClass _instance;
        //private static Random _rand = new Random();

        [ThreadStatic]
        private static Random _rand;

        public static int Next(int lower, int upper)
        {
            if (_rand == null)
            {
                var bytes = new byte[4];
                new RNGCryptoServiceProvider().GetBytes(bytes);

                int seed = BitConverter.ToInt32(bytes, 0);

                _rand = new Random();
            }

            // upper bound of Random.Next is exclusive
            int exc = upper + 1;
            return _rand.Next(lower, exc);
        }

        //public static RandClass Instance()
        //{
        //    if (_instance == null)
        //    {
        //        lock (_rand)
        //        {
        //            //if (_instance == null)
        //            _instance = new RandClass();
        //        }
        //    }
        //    return _instance;
        //}
    }
}
