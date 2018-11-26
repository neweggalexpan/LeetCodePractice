
using System.Collections.Generic;

public class HW_1127_Sort
{
    public void BubbleSort(List<int> intList)
    {
        var length = intList.Count;

        for (int i = 0; i < length; i++)
        {
            for (int j = i + 1; j < length; j++)
            {
                if(intList[j] < intList[i])
                {
                    var temp = intList[i];
                    intList[i] = intList[j];
                    intList[j] = temp;
                }
            }
        }
    }
}