using System.Diagnostics;

namespace Sorting;

public class SortingTests
{
    [Fact]
    public void Can_sort_an_array()
    {
        Assert.Equal(Array.Empty<int>(), Sort(Array.Empty<int>()));
        Assert.Equal(new[] {1}, Sort([1]));
    }

    private IEnumerable<int> Sort(int[] listToSort)
    {
        return listToSort;
    }
}