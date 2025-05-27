(int, double) SumAndaverage(params int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    double avg = (double)sum / arr.Length;
    return (sum, avg);
}
int[]arrv= { 1, 2, 3, 4, 5 };
(int s, double v) = SumAndaverage(arrv);
Console.WriteLine($"Sum= { s}, Average = { v}");
Console.WriteLine(SumAndaverage(1, 2, 3, 4, 5));