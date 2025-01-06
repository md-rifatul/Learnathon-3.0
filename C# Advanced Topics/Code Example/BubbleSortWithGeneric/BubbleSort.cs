using System.Numerics;

namespace BubbleSortWithGeneric
{
    public class BubbleSort<T> where T : INumber<T>
    {
        public T[] Sort(T[] arr)
        {
            var temp = default(T);

            for (int i = 0; i < arr.Length - 1; i++) 
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
