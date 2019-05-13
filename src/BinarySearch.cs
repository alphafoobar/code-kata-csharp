namespace src
{
    public class BinarySearch
    {
        public static int Chop(int key, int[] array)
        {
            var offset = 0;
            var length = array.Length;
            while (offset < length)
            {
                var remaining = length - offset;
                var point = offset + remaining / 2;
                if (array[point] == key)
                {
                    return point;
                }

                if (array[point] > key)
                {
                    length = point;
                }
                else
                {
                    offset = point + 1;
                }
            }

            return -1;
        }
    }
}