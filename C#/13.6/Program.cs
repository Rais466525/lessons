// Задание: реализовать поиск и сортировку массива
// 1. Сгенерировать массив из 100 случайных целых чисел.
// 2. Выполнить линейный (простый) поиск заданного элемента в несортированном массиве и подсчитать количество сравнений.
// 3. Отсортировать массив одним из методов (пузырьком, выбором или быстрая сортировка).
// 4. Выполнить бинарный (дихотомический) поиск того же элемента в отсортированном массиве и подсчитать количество шагов.
// 5. Вывести результаты обоих поисков и сделать выводы о количестве итераций.

using System;

class Program
{
    enum SortMethod { Bubble, Selection, Quick }

    static void Main()
    {
        const int size = 100;
        int[] data = GenerateRandomArray(size, 0, 999);
        int target = data[new Random().Next(size)]; // или можно задать вручную

        // Линейный поиск
        int linearCount;
        int linearIndex = LinearSearch(data, target, out linearCount);
        Console.WriteLine($"Линейный поиск: элемент {target} найден на позиции {linearIndex}, сравнений: {linearCount}");

        // Выбор метода сортировки
        SortMethod variant = SortMethod.Selection;
        int[] sorted = (int[])data.Clone();

        switch (variant)
        {
            case SortMethod.Bubble:
                BubbleSort(sorted);
                Console.WriteLine("Метод сортировки: пузырьковая сортировка");
                break;
            case SortMethod.Selection:
                SelectionSort(sorted);
                Console.WriteLine("Метод сортировки: сортировка выбором");
                break;
            case SortMethod.Quick:
                QuickSort(sorted, 0, sorted.Length - 1);
                Console.WriteLine("Метод сортировки: быстрая сортировка");
                break;
        }

        // Бинарный поиск
        int binaryCount;
        int binaryIndex = BinarySearch(sorted, target, out binaryCount);
        Console.WriteLine($"Бинарный поиск: элемент {target} найден на позиции {binaryIndex}, шагов: {binaryCount}");

        // Вывод сравнений
        Console.WriteLine($"Итерации: Линейный = {linearCount}, Бинарный = {binaryCount}");
    }

    static int[] GenerateRandomArray(int n, int min, int max)
    {
        var rand = new Random();
        int[] arr = new int[n];
        for (int i = 0; i < n; i++) arr[i] = rand.Next(min, max + 1);
        return arr;
    }

    static int LinearSearch(int[] arr, int key, out int count)
    {
        count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            count++;
            if (arr[i] == key) return i;
        }
        return -1;
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                    Swap(arr, j, j + 1);
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[minIdx]) minIdx = j;
            Swap(arr, i, minIdx);
        }
    }

    static void QuickSort(int[] arr, int left, int right)
    {
        if (left >= right) return;
        int pivot = arr[(left + right) / 2];
        int i = left, j = right;
        while (i <= j)
        {
            while (arr[i] < pivot) i++;
            while (arr[j] > pivot) j--;
            if (i <= j)
            {
                Swap(arr, i, j);
                i++; j--;
            }
        }
        if (left < j) QuickSort(arr, left, j);
        if (i < right) QuickSort(arr, i, right);
    }

    static int BinarySearch(int[] arr, int key, out int count)
    {
        int left = 0, right = arr.Length - 1;
        count = 0;
        while (left <= right)
        {
            count++;
            int mid = (left + right) / 2;
            if (arr[mid] == key) return mid;
            if (arr[mid] < key) left = mid + 1;
            else right = mid - 1;
        }
        return -1;
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
