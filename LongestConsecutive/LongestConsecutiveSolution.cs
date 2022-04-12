using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestConsecutive
{
    public class LongestConsecutiveSolution
    {
        public static int Execute(List<int> numbers)
        {
            int max = 0;
            List<int> sorted = numbers.Distinct().OrderBy(x => x).ToList();
            for (int i = 0; i < sorted.Count; i++)
            {
                int localMax = 0;
                bool broken = false;
                for (int j = i; j < sorted.Count - 1; j++)
                {
                    if(sorted[j+1] - sorted[j] == 1)
                    {
                        localMax++;
                    }
                    else
                    {
                        localMax++;
                        broken = true;
                        break;
                    }
                }
                if(!broken)
                    localMax++;
                if(localMax > max)
                    max = localMax;
            }
            return max;
        }
    }
}
