using Sorting;

namespace Sorting.Tests;

public class InsertionTests : TestHelpers
{
    [SetUp]
    public void Setup()
    {
    }
    [Test]
    public void CheckAscendingArray()
    {
        ISorting sorting = new Insertion();
        var srcArray = new[] { 4, 1, 3, 6, 7, 8, 9, 2 };
        var expArray = new[] { 1, 2, 3, 4, 6, 7, 8, 9 };
        srcArray = sorting.SortByAscending(srcArray);

        AssertArrays(srcArray, expArray);
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

}