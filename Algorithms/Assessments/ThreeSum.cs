using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Assessments
{
    public class ThreeSum
    {
        public IList<IList<int>> Execute(int[] nums)
        {
            Array.Sort(nums);
            List<IList<int>> result = new List<IList<int>>();
            Dictionary<(int, int, int), int> dictionary = new Dictionary<(int, int, int), int>();

            for(int i = 0; i < nums.Length; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;
                while(left < right)
                {
                    if(nums[i] + nums[left] + nums[right] == 0)
                    {
                        if(dictionary.ContainsKey((nums[i], nums[left], nums[right])))
                        {
                            left++;
                            right--;
                            continue;
                        }
                        else
                        {
                            result.Add(new List<int>() { nums[i], nums[left], nums[right] });
                            dictionary.Add((nums[i], nums[left], nums[right]), 1);
                            left++;
                            right--;
                        }
                    }
                    else if (nums[i] + nums[left] + nums[right] > 0)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }

            return result;
        }
    }
}
