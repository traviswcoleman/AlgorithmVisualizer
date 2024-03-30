using AlgorithmVisualizer.Business.Common;
namespace ExtensionTests;

public class MathExtensionTests
{
    [Theory]
    [InlineData(0,0,100,0,200,0)]
    [InlineData(50,0,100,0,200,100)]
    [InlineData(200,0,100,0,200,400)]
    public void Map(float input, float inRangeLB, float inRangeUB, float outRangeLB, float outRangeUB, float expected)
    {
        Assert.Equal(MathExtensions.Map(input, inRangeLB, inRangeUB, outRangeLB, outRangeUB), expected);
    }
}