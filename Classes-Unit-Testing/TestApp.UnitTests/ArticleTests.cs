using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;
    [SetUp]
    public void SetUp()
    {
        this._article = new Article();
    }

    // TODO: finish test
    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] articleData =
            {
                "Article Content1 Author1",
                "Article2 Content2 Author2",
                "Article3 Content3 Author3"

            };
        // Act
        Article result = this._article.AddArticles(articleData);
        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        Article input = new Article()
        {
            ArticleList = new()
            {
                new Article()
                {
                    Author = "Az",
                    Content = "Phone",
                    Title = "Hard"
                },
                new Article()
                {
                    Author = "Ti",
                    Content = "Laptop",
                    Title = "Soft"
                }
            }
        };
        string expected = $"Hard - Phone: Az" +
            $"{Environment.NewLine}Soft - Laptop: Ti";
        // Act
        string actual = this._article.GetArticleList(input, "title");
        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        Article input = new Article()
        {
            ArticleList = new()
            {
                new Article()
                {
                    Author = "Az",
                    Content = "Phone",
                    Title = "Hard"
                },
                new Article()
                {
                    Author = "Ti",
                    Content = "Laptop",
                    Title = "Soft"
                }
            }
        };
        
        // Act
        string actual = this._article.GetArticleList(input, "tittttttle");
        // Assert
        Assert.AreEqual(string.Empty, actual);
    }
}
