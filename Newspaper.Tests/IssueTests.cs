namespace Newspaper.Tests
{
    public class IssueTests
    {
        [Fact]
        public void IssueHasCorrectzProperties()
        {
            var testIssue = new Issue{Date = new DateTime(2023, 6, 7).ToUniversalTime()};
            Assert.Equal(new DateTime(2023, 6, 7).ToUniversalTime(), testIssue.Date);
            Assert.Empty(testIssue.Articles);
            Assert.IsType<List<Article>>(testIssue.Articles);
        }
    }
}