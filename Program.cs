namespace SearchingAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int arr1Result = LinearSearch(arr1, 4);
            int arr2Result = GetMax(unsortedArray);
            int arr3Result = GetMin(unsortedArray);
            Console.WriteLine(arr1Result);
            Console.WriteLine(arr2Result);
            Console.WriteLine(arr3Result);
        }

        public static int LinearSearch(int[] arrToSearch, int target)
        {
            // intitialize loop at 0
            // next we evaluate our expression
            // last we run the update logic
            // Big O - O(n)
            // Big Omega - O(1)
            for (int i = 0; i < arrToSearch.Length; i++)
            {
                if (arrToSearch[i] == target) return i;
            }

            return -1;
        }
        public static int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            return max;
        }
        public static int GetMin(int[] arr)
        {
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }

            return min;
        }

        public static int BinarySearch(int[] arrToSearch, int target)
        {
            // establish upper and lower bound
            int lower = 0;
            int upper = arrToSearch.Length - 1;
            while (upper >= lower)
            {
                int mid = (upper + lower) / 2;
                if (arrToSearch[mid] == target) return mid;
                else if (target < arrToSearch[mid])
                {
                    upper = mid - 1;
                }
                else
                {
                    lower = mid + 1;
                }

            }
            return -1;
        }