using System.Diagnostics;

namespace Sorting;

public class SortingTests
{
    [Fact]
    public void Can_sort_an_array()
    {
        Assert.Equal(Array.Empty<int>(), Sort(Array.Empty<int>()));
        Assert.Equal([1], Sort([1]));
        Assert.Equal([1, 2], Sort([2, 1]));
        Assert.Equal([1, 2, 3], Sort([2, 1, 3]));
        Assert.Equal([1, 2, 3], Sort([3, 2, 1]));
        Assert.Equal([1, 2, 3, 4, 5], Sort([1, 3, 2, 5, 4]));
    }

    private IEnumerable<int> Sort(int[] listToSort)
    {
        if (listToSort.Length > 1)
        {
            for (var limit = listToSort.Length - 1; limit > 0; limit--)
            {
                for (var firstIndex = 0; firstIndex < limit; firstIndex++)
                {
                    var secondIndex = firstIndex + 1;
                    if (listToSort[firstIndex] > listToSort[secondIndex])
                    {
                        var firstValue = listToSort[firstIndex];
                        var secondValue = listToSort[secondIndex];
                        listToSort[firstIndex] = secondValue;
                        listToSort[secondIndex] = firstValue;
                    }
                }
            }
        }
        return listToSort;
    }
}