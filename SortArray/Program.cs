void swap(ref int a, ref int b)
{
    int tmp = a;
    a = b;
    b = tmp;
}
//void sort_array(int[] arr)
//{
//    for (int i = 0; i < arr.Length - 1; i++)
//    {
//        for (int j = i + 1; j < arr.Length; j++)
//        {
//            if (arr[i] > arr[j])
//            {
//                swap(ref arr[i], ref arr[j]);
//            }
//        }
//    }
//}
     Console.OutputEncoding = System.Text.Encoding.UTF8;
void create_array(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(1, 100);
    }
}
void print_array(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void sort_array(int[] arr)
{
    bool swapped;
    do
    {
        swapped = false;
        int i = 0;
        do
        {
            if (i < arr.Length - 1 && arr[i] > arr[i + 1])
            {
                swap(ref arr[i], ref arr[i + 1]);
                swapped = true;
            }
            i++;
        } while (i < arr.Length - 1);
    } while (swapped);
}
void array(int[] arr)
{
    bool swapped;

    do
    { 
        int i = 0;
        swapped = false;
        do
        {
            if (i < arr.Length - 1 && arr[i] > arr[i + 1])
            {
                swap(ref arr[i], ref arr[i + 1]);
                swapped = true;
            }
        } while (i < arr.Length - 1);
    } while (swapped);
}

int[] arr = new int[10];
create_array(arr);
Console.WriteLine("Mảng trước khi sắp xếp:");
print_array(arr);
sort_array(arr);
Console.WriteLine("\nMảng sau khi sắp xếp:");
print_array(arr);
Console.WriteLine();
Console.WriteLine("Nhấn phím bất kỳ để thoát...");
Console.ReadKey();

