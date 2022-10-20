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
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("====================");

            //get array elements
            for(int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        //swap the elements at index x with the element at index y
        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;

        }

        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low > high)
                return;

            //partition the list into the parts:
            //one containing elements less that or equel to  pivot
            //outher containing elements greather than pivot

            i = low + 1;
            j = high;
            pivot = arr[low];

            while (i <= j)
            {
                //search for an elements greater than pivot
                while ((arr[j] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                        
                }
                cmp_count++;

                //search the element less than pivot
                while ((arr[j] > pivot) && (j >= low))
                {
                    j--;
                    cmp_count++;
                }
                cmp_count++;

                if (i < j) //if the greater element is on the left of the element
                {
                    //swap the element at index i with the element at index j
                    swap(i, j);
                    mov_count++;
                }
            }
            //now contains the index  of the last elemnet
            if(low < j)
            {
                //move the pivot
                swap(low, j);
                mov_count++;
            }
            //sort the list
            q_sort(low, j - 1);

            //qsort the list
            q_sort(j + 1, high);

        }
        void display()
        {
            Console.WriteLine("\n====================");
            Console.WriteLine("sorted array element");
            Console.WriteLine("====================");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);

            }
            Console.WriteLine("\nNumber of comparasion" + cmp_count);
            Console.WriteLine("\nNumber data of data movement" + mov_count);
        }
        int getSize()
        {
            return (n);

        }
        static void Main(string[]args)
        {
            program myList = new program();
            myList.input();
            myList.q_sort(0, myList.getSize() - 1);
            myList.display();
            Console.WriteLine("\n\nPress enter to exit");
            Console.Read();

        }
    }
}
