// a=3, b=3. Write code that will swap the values of these two variables.

using System;

int[] nums = { 3, 3};

for (int a = 0; a < nums.Length - 1; a++)
{
    for (int b = a + 1; b < nums.Length; b++)
    {
      int tempNumber = nums[a];
      nums[a] = nums[b];
      nums[b] = tempNumber;
    }
}

Console.WriteLine("sorted numbers");
PrintArray(nums);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}