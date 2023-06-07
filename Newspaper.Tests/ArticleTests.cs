namespace Newspaper.Tests
{
    public class ArticleTests
    {
        [Fact]
        public void ArticleHasCorrectProperties()
        {
            var reporter = new Reporter { Name = "Matt Moore", Speciality = "Sports" };
            var title = "How will Denver respond in game 3";
            var content = "jsaldjkfhsljfhlksdjahfljsdhljashdfljh";
            var issue = new Issue { Date = new DateTime(2023, 6, 7).ToUniversalTime() };
            var testArticle = new Article { Title = title , Content = content, Reporter = reporter, Issue = issue};

            Assert.Equal(reporter, testArticle.Reporter);
            Assert.Equal(title, testArticle.Title);
            Assert.Equal(content, testArticle.Content);
            Assert.Equal(issue, testArticle.Issue);

        }
    }
}