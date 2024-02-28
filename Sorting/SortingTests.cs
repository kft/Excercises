namespace Sorting;

public class SortingTests
{
    [Fact]
    public void Can_sort_an_array()
    {
        Assert.Equal(Array.Empty<int>(), Sort(Array.Empty<int>()));
    }

    private IEnumerable<int> Sort(int[] listToSort)
    {
        return new List<int>();
    }
}