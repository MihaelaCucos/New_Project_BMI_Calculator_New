using BMICalculator;

namespace BMI.Tests;

[TestClass]
public sealed class BmiCategoryTests
{
    [TestMethod]
    public void BMIValueInNormalRange_ReturnsNormalCategory()
    {
        var bmi = new BMICalculator.BMI
        {
            WeightStones = 10,
            WeightPounds = 0,
            HeightFeet = 5,
            HeightInches = 10
        };

        Assert.AreEqual(BMICategory.Normal, bmi.BMICategory);
    }

    [TestMethod]
    public void BMIValueInOverweightRange_ReturnsOverweightCategory()
    {
        var bmi = new BMICalculator.BMI
        {
            WeightStones = 12,
            WeightPounds = 0,
            HeightFeet = 5,
            HeightInches = 8
        };

        Assert.AreEqual(BMICategory.Overweight, bmi.BMICategory);
    }
}
