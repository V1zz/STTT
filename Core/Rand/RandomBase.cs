using System;

namespace Model.Rand
{
    public abstract class RandomBase
    {
        private static Random _rand = null;

        private static readonly int _min = 0;
        private static readonly int _max = 99;

        private RandomBase() { }

        private static Random Instance
        {
            get
            {
                if (_rand == null) _rand = new Random();
                return _rand;
            }
        }

        public static void GetRandomArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = Instance.Next(_min, _max);
        }
    }
}
