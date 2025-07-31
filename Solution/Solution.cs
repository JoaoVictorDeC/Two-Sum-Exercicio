using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumExercise.Solution
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> Dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {

                int complemento = target - nums[i];
                /*Verifica se dicionário contém, a chave com o valor do complemento, caso tenha, irá retornar o valor
                da chave do Dictionary , e o indice dentro do array nums.
                */
                if (Dict.ContainsKey(complemento))
                {
                    return new int[] { Dict[complemento], i };
                }
                if (!Dict.ContainsKey(nums[i]))
                {
                    Dict[nums[i]] = i;
                }
            }
            throw new Exception("Not found");
        }
    }
}
 

