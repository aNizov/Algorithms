using System;

namespace Sorting.Tests;

public class TestHelpers
{
    protected void AssertArrays(int[] srcArray, int[] expArray)
    {
        for (int i = 0; i < srcArray.Length; i++)
        {
            Assert.That(srcArray[i], Is.EqualTo(expArray[i]));
        }
    }
}
