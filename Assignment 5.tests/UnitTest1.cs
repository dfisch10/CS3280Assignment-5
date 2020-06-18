using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Xunit;
using Assignment_5.Posts;
using Assignment_5.Comments;

using AutoFixture.Xunit2;
using Assignment_5.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Assignment_5.tests
{
    [ExcludeFromCodeCoverage]
    public class UnitTest1
    {
        [Fact]
        public void PostConstructor_CheckingIfNullWithNullValuesEntered_ReturnsValid()
        {
            string title = null;

            string description = null;

            string createdby = null;

            var sut = new Post(title, description, createdby);

            Assert.Null(sut.Title);
            Assert.Null(sut.Description);
            Assert.Null(sut.CreatedBy);
        }


        [Theory]
        [InlineAutoData]
        public void PostConstructor_CheckingIfValuesEnteredMatchesValueOutputs_ReturnsValid(string expectedResult)
        {
            var title = expectedResult;

            var description = expectedResult;

            var createdby = expectedResult;

            var sut = new Post(title, description, createdby);

            Assert.Equal(expectedResult, sut.Title);
            Assert.Equal(expectedResult, sut.Description);
            Assert.Equal(expectedResult, sut.CreatedBy);
        }

        [Theory]
        [InlineData(null, null, null, null)]
        public void CommentConstructor_CheckingIfNullWithNullValuesEntered_ReturnsValid(string title, string description, string createdby, Post post)
        {
            title = null;

            description = null;

            createdby = null;

            post = new Post(title, description, createdby);

            var sut = new Comment(title, description, createdby);

            Assert.Null(sut.Title);
            Assert.Null(sut.Description);
            Assert.Null(sut.CreatedBy);
            Assert.Null(sut.PostTitle);
        }

        [Theory]
        [InlineData("works as expected")]
        public void CommentConstructor_CheckingIfValuesEnteredMatchesValueOutputs_ReturnsValid(string expectedResult)
        {
            var title = expectedResult;

            var description = expectedResult;

            var createdby = expectedResult;

            var sut = new Comment(title, description, createdby);

            Assert.Equal(expectedResult, sut.Title);
            Assert.Equal(expectedResult, sut.Description);
            Assert.Equal(expectedResult, sut.CreatedBy);
        }

        [Theory]
        [MemberData(nameof(IncreaseUpAndDownVotesData))]
        public void IncreaseUpVotes_VariousInformationPassedIn_ReturnsValid(int expectedResult, int expectedResult2, string title, string description, string createdby)
        {
            var sut = new Post(title, description, createdby);

            var actual = sut.IncreaseUpVotes();

            Assert.Equal(expectedResult, actual);
            Assert.Equal(expectedResult2, sut.IncreaseUpVotes());
        }

        [Theory]
        [MemberData(nameof(IncreaseUpAndDownVotesData))]
        public void IncreaseDownVotes_VariousInformationPassedIn_ReturnsValid(int expectedResult, int expectedResult2, string title, string description, string createdby)
        {

            var sut = new Post(title, description, createdby);

            var actual = sut.IncreaseDownVotes();

            Assert.Equal(expectedResult, actual);
            Assert.Equal(expectedResult2, sut.IncreaseDownVotes());
        }

        public static IEnumerable<object[]> IncreaseUpAndDownVotesData => new List<object[]>
        {
            new object[] {1, 2, "title", "description", "creator"},
            new object[] {1, 2, null, null, null},
            new object[] {1, 2, "title", "description", null},
            new object[] {1, 2, null, "description", "creator"},
            new object[] {1, 2, "title", null, "creator"},
            new object[] {1, 2, "title", null, null },
            new object[] {1, 2, null, null, "creator" },
            new object[] {1, 2, null, "description", null }

        };


        [Theory]
        [MemberData(nameof(AddCommentData))]
        public void AddComment_VariousValuesPassedInAndAddedVariableTimes_ReturnsValidCount(int expectedResult, string title, string description, string createdby, int commentsAddedAmount)
        {
            var sut = new Post(title, description, createdby);

            var comment = new Comment(title, description, createdby);

            for (var index = 0; index < commentsAddedAmount; index++)
            {
                sut.AddComment(comment);
            }    

            var actual = sut.Comments.Count;

            Assert.Equal(expectedResult, actual);
        }

        public static IEnumerable<object[]> AddCommentData => new List<object[]>
        {
            new object[] {1, null, null, null, 1},
            new object[] {5, "title", "description", "creator", 5},
            new object[] {1, "title", "description", null, 1},
            new object[] {3, null, "description", "creator", 3},
            new object[] {2,"title", null, "creator", 2},
            new object[] {4,"title", null, null, 4 },
            new object[] {1, null, null, "creator", 1 },
            new object[] {1, null, "description", null, 1},
            new object[] {7, "", "", "", 7}

        };
    }
}
