static void plusMinus(List<int> arr)
{
    List<int> values = new List<int>() { 0, 0, 0 };

    foreach (int num in arr)
    {
        if (num > 0)
            values[0]++;
        else if (num < 0)
            values[1]++;
        else
            values[2]++;
    }

    foreach (int num in values)
    {
        double resp = (double)num / arr.Count;
        Console.WriteLine(resp.ToString("F6"));
    }



}

List<int> arr = new List<int>() { -4, 3, -9, 0, 4, 1 };
plusMinus(arr);
