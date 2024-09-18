using System.Runtime.CompilerServices;

int[] array = { 5, 1, 4, 3, 2 };
int steps = 0;

int[] array2 = { 5, 1, 4, 3, 2 };
int steps1 = 0;


int temporary;


bool isRunning = true;


do
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("\n 0 = Bubble Sort, 1 = Selection Sort, 000 = End");

    string answer = Console.ReadLine();


    switch (answer)
    {
        case "0":

            BubbleSort(array);

            break;

        case "1":
            SelectionSort(array2);
            break;
        case "000":

            isRunning = false;
            break;
    }
}
while (isRunning);


//Bubble Sort


void BubbleSort(int[] arr)
{
    Console.WriteLine("\n\n\n------------------------------------Bubble Sort--------------------------------");
    steps = 0;
    for (int j = 0; j <= arr.Length - 2; j++)
    {

        for (int i = 0; i <= arr.Length - 2; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                temporary = arr[i + 1];
                arr[i + 1] = arr[i];
                arr[i] = temporary;
            }
            steps++;
            Console.Write("");
            Console.Write($" {arr[i]} ");

        }
    }
    Console.WriteLine("\nSteps taken: " + steps + "\n");
    Console.WriteLine("\n Sorted:");
    foreach (int p in arr)
    {
        Console.Write($"{p} ");
    }

    if (steps > steps1)
    {
        Console.WriteLine("\nEste tuvo menos pasos");
    }
    Console.WriteLine("\n\n\n----------------------------------------------------------------------------\n\n");


}


void SelectionSort(int[] arr)
{
    Console.WriteLine("\n\n\n------------------------------------Selection Sort--------------------------------");

    int n = arr.Length;
    steps1 = 0;

    for (int i = 0; i < n; i++)
    {

        int min_idx = i;
        for (int j = i + 1; j < n; j++)
        {
            if (arr[j] < arr[min_idx])
            {
                min_idx = j;
            }
            steps1++;
            Console.Write("");
            Console.Write($" {arr[j]} ");
        }

        int temp = arr[min_idx];
        arr[min_idx] = arr[i];
        arr[i] = temp;
    }

    Console.WriteLine("\nSteps taken: " + steps + "\n");
    Console.WriteLine("\n Sorted:");
    foreach (int p in arr)
    {
        Console.Write($"{p} ");
    }
    if (steps < steps1)
    {
        Console.WriteLine("Este tuvo menos pasos");
    }

    Console.WriteLine("\n\n\n----------------------------------------------------------------------------\n\n");

}