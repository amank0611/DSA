namespace DSA
{
    internal class TargetSum
    {
        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //You can return the answer in any order.

        //Input: nums = [2, 7, 11, 15], target = 9
        //Output: [0,1]
        //Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].

        public static void GetTargetSumIndices()
        {
            //TC:O(n2) SC: O(1)
            //Time Complexity: O(n^2)
            //Space Complexity: O(n)
            //int[] arr = { 1, 2, 3, 4, 5 }; int target = 5;
            int[] indices = [];
            int[] arr = { 2, 7, 11, 15 }; int target = 9;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    int sum = arr[j] + arr[i];
                    if (sum == target)
                    {
                        indices = [j, i];
                        break;
                    }
                }
            }
            Console.WriteLine($"Target sum indices are: [{string.Join(",", indices)}]");

        }
    }
}
