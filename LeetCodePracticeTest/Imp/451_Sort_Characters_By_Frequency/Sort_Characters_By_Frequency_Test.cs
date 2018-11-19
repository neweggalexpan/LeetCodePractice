using Xunit;

public class Sort_Characters_By_Frequency_Test
{
    [Fact]
    public void FrequencySort_Success()
    {
        //Arrange
        var input = "tree";

        //Act
        var actual = new Sort_Characters_By_Frequency().FrequencySort(input);

        //Assert
        Assert.Equal("eetr", actual);
    }
}