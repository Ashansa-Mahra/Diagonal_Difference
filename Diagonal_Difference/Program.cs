class Result
{

    public static int DiagonalDifference(List<List<int>> arr)
    {
        int length = arr.Count;
        var leftToRightDiagonalSum = 0;
        var rightToLeftDiagonalSum = 0;

        for (int i = 0; i < length; i++)
        {
            leftToRightDiagonalSum += arr[i][i];
        }

        for (int i = 0; i < length; i++)
        {
            rightToLeftDiagonalSum += arr[i][length - 1 - i];
        }
        return Math.Abs(leftToRightDiagonalSum - rightToLeftDiagonalSum);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.DiagonalDifference(arr);

        Console.WriteLine(result);
    }
}
