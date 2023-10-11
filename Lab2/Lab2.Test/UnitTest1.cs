namespace Lab2.Test
{
    public class UnitTest1
    {
        [Fact]
        public void FormatUsdPrice_ProperFormat_ShouldReturnProperString()
        {
            var data = 0.05;
            var result = MyFormatter.FormatUsdPrice(data);
            Assert.StartsWith("$", result);
            Assert.Contains(".", result);
        }

        [Fact]
        public void IsExpected()
        {
            var data = 0.05;
            var expected = "$0.05";
            var result = MyFormatter.FormatUsdPrice(data);
            Assert.Equal(expected, result);
        }
    }
}