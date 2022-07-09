public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int max = nums.Length;                  //the length of the array
        
        for(int i = 0;i<max;i++)                //find from the first element
        {

            //the difference of the array element with the target number
            int diff = target - nums[i];        
            for(int j = i+1;j<max;j++)          //can't use the same index,so need to plus 1   
            {
                if(nums[j] == diff)             //when nums[j] equals the diff, return the indices 
                {
                    return new int[2]{i,j};
                }
            }        
        }
        return  new int[2]{0,0};                //useless code, add for complete the return
    }
}