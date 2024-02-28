using System.Diagnostics;

namespace Sorting;

public class SortingTests
{
    [Fact]
    public void Can_sort_an_array()
    {
        Assert.Equal(Array.Empty<int>(), Sort(Array.Empty<int>()));
        Assert.Equal(new[] {1}, Sort([1]));
        Assert.Equal(new[] {1, 2}, Sort([2, 1]));
    }

    private IEnumerable<int> Sort(int[] listToSort)
    {
        if (listToSort.Length > 1)
        {
            if (listToSort[0] > listToSort[1])
            {
                var firstIndex = listToSort[0];
                var secondIndex = listToSort[1];
                listToSort[0] = secondIndex;
                listToSort[1] = firstIndex;
            }
        }
        return listToSort;
    }
}