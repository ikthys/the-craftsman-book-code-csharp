namespace _01_OpeningDisaster;

public class GeneratePrimesTests
{
    [Fact]
    public void TestPrimes()
    {
        int[] nullArray = GeneratePrimes.Execute(0);
        Assert.Empty(nullArray);

        int[] minArray = GeneratePrimes.Execute(2);
        Assert.Single(minArray);
        Assert.Equal(2, minArray[0]);

        int[] threeArray = GeneratePrimes.Execute(3);
        Assert.Equal(2, threeArray.Length);
        Assert.Equal(2, threeArray[0]);
        Assert.Equal(3, threeArray[1]);

        int[] centArray = GeneratePrimes.Execute(100);
        Assert.Equal(25, centArray.Length);
        Assert.Equal(97, centArray[24]);
    }
}