using TwoSumExercise.Solution;

namespace TwoSum
{
    class Program
    {
        static void Main()
        {
            Solution S = new Solution();
            int[] nums = {7,9,11,3,2,5,6 };
            int target = 14;
            int[] resultado = S.TwoSum(nums,target);
            Console.WriteLine($"Dict[complemento] = {resultado[0]} , indice de nums = {resultado[1]} pois {nums[resultado[0]]} + {nums[resultado[1]]} = {target}");




        }
    }
}