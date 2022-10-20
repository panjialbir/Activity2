namespace QuickSort
{
    class program
    {
        //array of integers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; //number of comprassion
        private int mov_count = 0; //number of movements

        //number of elements in array
        private int n;

        void input()
        {
            while (true)
            {
                Console.Write("Enter The Number Of Elements In The Array:");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 elements \n");
            }

            Console.WriteLine("====================");
            Console.Writeline("Enter Array Elements");
            Console.WriteLine("====================");

        }
    }
}
