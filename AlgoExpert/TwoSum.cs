//https://leetcode.com/problems/two-sum/

using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoExpert
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            IList<int> indices = new List<int>();
            IDictionary<int, Tuple<int, int>> lookupTable = new Dictionary<int, Tuple<int, int>>();
            for(int i=0; i<nums.Length; i++)
            {
                if(lookupTable.ContainsKey(nums[i]))
                {                    
                    indices.Add(lookupTable[nums[i]].Item2);
                    indices.Add(i);
                    break;
                }
                lookupTable[target - nums[i]] = new Tuple<int, int>(nums[i], i);
            }

            return indices.ToArray();
        }
    }
}
