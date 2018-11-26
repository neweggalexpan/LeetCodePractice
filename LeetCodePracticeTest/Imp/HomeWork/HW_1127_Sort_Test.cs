using System.Collections.Generic;
using Xunit;

public class HW_1127_Sort_Test
{
    [Fact]
    public void BubbleSort_Success()
    {
        //Arrange
        var input = new List<int>() { 55, 33, 44, 22, 11 };
        var expected = new List<int>() { 11, 22, 33, 44, 55 };

        //Act
        var target = new HW_1127_Sort();
        target.BubbleSort(input);

        Assert.Equal(expected, input);
    }
}