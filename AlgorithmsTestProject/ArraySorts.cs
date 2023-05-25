namespace AlgorithmsTestProject
{
    public static class ArraySortProblems
    {
        public static void MySort1(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        ArrayProblems.Swap(array, i, j);
                    }
                }
            }
        }

        public static void MySort2(int[] array)
        {
            var current = array.ToList();
            var result = new List<int>();
            while (current.Count > 0)
            {
                var x = current.Min();
                result.Add(x);
                current.Remove(x);
            }
            result.CopyTo(array);
        }

        public static void MergeSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void HeapSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void BubbleSort(int[] array)
        {
            // int n = array.Length;
            // bool swapped;

            // for (int i = 0; i < n - 1; i++)
            // {
            //     swapped = false;

            //     for (int j = 0; j < n - i - 1; j++)
            //     {
            //         if (array[j] > array[j + 1])
            //         {
            //             int temp = array[j];
            //             array[j] = array[j + 1];
            //             array[j + 1] = temp;
            //             swapped = true;
            //         }
            //     }
            //     if (!swapped)
            //         break;
            // }

            
            bool swapped;
            var n = array.Length;
            do
            {
                swapped = false;

                for (var i = 1; i < n; ++i)
                {
                    if (array[i - 1] > array[i])
                    {
                        ArrayProblems.Swap(array, i-1, i);
                        swapped = true;
                    }
                }

                --n;
            } 
            while (swapped && n > 0);
        }


        public static void ShuffleSort(int[] array)
        {
            Random random = new Random();

            while (!IsSorted(array))
            {
                Shuffle(array, random);
            }
        }

        private static void Shuffle(int[] array, Random random)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Swap(array, i, j);
            }
        }

        public static void IntroSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void CocktailSort(int[] array)
        {
            bool swapped;
            do
            {
                swapped = false;

                // Perform a bubble sort from left to right
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;

                swapped = false;

                // Perform a bubble sort from right to left
                for (int i = array.Length - 2; i >= 0; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);
                QuickSort(array, low, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);
            return i + 1;
        }


        public static void BlockSort(int[] array)
        {
            int minValue = array.Min();
            int maxValue = array.Max();
            int range = maxValue - minValue + 1;
            int[] count = new int[range];
            int[] output = new int[array.Length];

            foreach (int num in array)
            {
                count[num - minValue]++;
            }

            for (int i = 1; i < range; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                output[count[array[i] - minValue] - 1] = array[i];
                count[array[i] - minValue]--;
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = output[i];
            }
        }


        public static void BogoSort(int[] array)
        {
            Random random = new Random();

            while (!IsSorted(array))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int j = random.Next(i, array.Length);
                    Swap(array, i, j);
                }
            }
        }

        private static bool IsSorted(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                    return false;
            }
            return true;
        }

        private static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }


        public static void DoNothingSort(int[] array)
        {
        }

        public static void EvilSort(int[] array)
        {
            Array.Fill(array, 0);
        }

        public static void GnomeSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void SelectionSort(int[] array)
        {
        }
    }
}
