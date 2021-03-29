namespace Core
{
    
    public class BubbleSort
    {
        public static int[] BSort(int[] array)
        {
            return DoBubbleSort(array);
        }

        private static int[] DoBubbleSort(int[] array)
        {
            bool flag;

            do
            {
                flag = false;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (i > i + 1) 
                    {
                        flag = true;
                        Shake(array, i, i + 1);
                    }
                }
            } while (flag);

            return array;
        }

        private static void Shake(int[] array, int a, int b)
        {
            var tmp = array[a];
            array[a] = array[b];
            array[b] = tmp;
        }
    }
}
