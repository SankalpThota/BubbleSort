

//Program: Bubble Sort 
//Date:  02/08/24
//Created By: Sai Sankalp Thota
internal class Program
{
    private static void Main(string[] args)
    {

        int[] bubble_sort = { 5, 72, 3, 14, 7, 1 };
        Console.WriteLine("Original Array For Bubble Sort ");
        for (int i = 0; i < bubble_sort.Length; i++)
        {
            Console.Write("  " + bubble_sort[i]);
        }

        Console.WriteLine("");
        Console.WriteLine("Array after Execution ");
        Bubble_Sort(bubble_sort);
        for (int i = 0; i < bubble_sort.Length; i++)
        {
            Console.Write("  " + bubble_sort[i]);
        }
        Console.WriteLine("");
        Console.WriteLine("Press Anything to exit");
        Console.ReadKey(true);

        static void Bubble_Sort(int[] bs_arr)
        {

            for (int i = 0; i < bs_arr.Length - 1; i++)
            {
                for (int x = 0; x < bs_arr.Length - i - 1; x++)
                {

                    if (bs_arr[x] > bs_arr[x + 1])
                    {
                        int temp = bs_arr[x];
                        bs_arr[x] = bs_arr[x + 1];
                        bs_arr[x + 1] = temp;
                    }
                }
            }
        }

    }

}


