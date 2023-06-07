namespace Newspaper.Tests
{
    public class ReporterTests
    {
        [Fact]
        public void ReporterHasCorrectProperties()
        {
            var testReporter = new Reporter { Name = "Matt Moore", Speciality = "Sports" };
            Assert.Equal("Matt Moore", testReporter.Name);
            Assert.Equal("Sports", testReporter.Speciality);
            Assert.Empty(testReporter.Articles);
            Assert.IsType<List<Article>>(testReporter.Articles);
        }
    }
}