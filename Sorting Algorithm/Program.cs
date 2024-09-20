namespace SortingAlgoithms
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }

        public static void SelectionSort(int[] array)
        {
            // TODO: implement  Selection Sort

            for (int i = 0; i < array.Length; i++)
            {
                int minPlace = i;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[minPlace])
                    {
                        minPlace = j;
                    }
                }

                int temp = array[i];
                array[i] = array[minPlace];
                array[minPlace] = temp;
            }
        }
    }
}