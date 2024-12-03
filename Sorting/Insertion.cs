namespace Sorting;

public class Insertion : ISorting
{
    public int[] SortByAscending(int[] array)
    {
        int key, i;
        for (int j = 1; j < array.Length; j++)
        {
            key = array[j];
            //Вставка array[j] в отсортированную последовательность array[1..j-1]
            i = j - 1;

            while (i >= 0 && array[i] > key)
            {
                array[i + 1] = array[i];
                i = i - 1;
            }
            array[i + 1] = key;
        }
        return array;
    }

    public int[] SortByDescending(int[] unsortedArray)
    {
        return unsortedArray;
    }
}
