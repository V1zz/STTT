namespace Model.Rand
{
    using System;

    public class RandMy
    {
        private static Random _rand = null;

        private static readonly int _min = 0;
        private static readonly int _max = 99;

        private RandMy() { }

        private static int Instance
        {
            get
            {
                if (_rand == null) _rand = new Random();
                return _rand.Next(_min, _max);
            }
        }

        //private static Random GetInstance()
        //{
        //    return _rand ?? new Random();
        //}

        public static int[] GetRandomArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = Instance;
            return arr;
        }
    }
}
