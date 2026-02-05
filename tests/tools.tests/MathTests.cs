using Xunit;
using WSE.Common;

namespace WSE.Tests;

public class MathTests
{
    [Fact]
    public void SolveLinear_ValidInput_ReturnsCorrectX()
    {
        // Arrange: 2x + 4 = 0
        double a = 2;
        double b = 4;
        
        // Act
        double result = MathUtilities.SolveLinear(a, b);
        
        // Assert
        Assert.Equal(-2, result);
    }
}
