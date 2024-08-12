namespace Practice2.Task18
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] test = new int[] { 1, 2, -3, -4 , 5 };

      int[] testWithoutNegativeNums = DeleteNegativeNums(test, out int count);

      Console.WriteLine(count);

      foreach (int i in testWithoutNegativeNums)
      {
        Console.Write(i + " ");
      }
    }

    static int[] DeleteNegativeNums(int[] nums, out int count)
    {
      count = 0;

      foreach (int num in nums)
      {
        if (num < 0)
        {
          count += 1;
        }
      }

      int[] result = new int[nums.Length - count];
      int i = 0;
      int j = 0;

      while (j < result.Length)
      {
        if (nums[i] >= 0)
        {
          result[j] = nums[i];
          j += 1;
        }

        i += 1;
      }

      return result;
    }
  }
}
