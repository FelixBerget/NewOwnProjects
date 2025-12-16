using System;
using System.Collections.Generic;
using System.Text;

namespace FoodProject
{
    public class SortingAlgrorithms
    {
        string[] toBeSorted;

        public SortingAlgrorithms(string[] toBeSorted)
        {
            this.toBeSorted = toBeSorted;
        }

        public string[] sortStringList()
        {
            for (int i = 0; i < toBeSorted.Length; i++)
            {
                for (int j = 0; j < toBeSorted.Length; j++)
                {
                    if (toBeSorted[i].Length < toBeSorted[j].Length)
                    {
                        string temp = toBeSorted[i];
                        toBeSorted[i] = toBeSorted[j];
                        toBeSorted[j] = temp;
                    }
                }
            }
            return toBeSorted;

        }
    }
}
