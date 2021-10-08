//https://leetcode.com/problems/remove-duplicates-from-sorted-array/

namespace AlgoExpert
{
    public class RemoveDuplicatesSolution
    {
        public int RemoveDuplicates(int[] n)
        {
            if (n.Length == 0)
            {
                return 0;
            }
            int finalNo = 0;
            for (int i = 1; i < n.Length; i++)
            {
                if(n[i] != n[finalNo])
                {
                    ++finalNo;                    
                    n[finalNo] = n[i];
                }
            }
            return finalNo+1;
        }
    }
}