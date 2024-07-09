namespace SearchingAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int arr1Result = LinearSearch(arr1, 4);
            Console.WriteLine(arr1Result);
        }

        public static int LinearSearch(int[] arrToSearch, int target)
        {
            //int i = 0 - initializing our loop conditional - in tthis case to 0
            // next we evaluate if the value meets the condition
            // after each loop we run the update logic
            // Big O - O(n)
            // Big Omega - O(1)
            for (int i = 0; i < arrToSearch.Length; i++)
            {
                if (arrToSearch[i] == target) return i;
            }

            return -1;
        }
    }
}