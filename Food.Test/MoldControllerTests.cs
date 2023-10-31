using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using Xunit;

namespace Food.Test
{
    public class CommitControllerTests
    {
        private readonly Mock<ICommitRepository> _repository;
        private readonly CommitController _controller;

        public CommitControllerTests()
        {
            _repository = new Mock<ICommitRepository>();
            _controller = new CommitController(_repository.Object);
        }

        [Fact]
        public async Task GetAllCommits_ReturnsOkResultWithCommits()
        {
            // Arrange
            var commitDtos = new List<CommitDto>(); // Replace with your test data
            _repository.Setup(repo => repo.GetCommitsAsync()).ReturnsAsync(commitDtos);

            // Act
            var result = await _controller.GetAllCommits();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var model = Assert.IsType<List<CommitDto>>(okResult.Value);
            Assert.Equal(commitDtos, model);
        }

        [Fact]
        public async Task CreateCommit_WithValidDto_ReturnsOkResultWithNewCommit()
        {
            // Arrange
            var commitDto = new CommitDto(); // Replace with your test data
            var createdCommitDto = new CommitDto() { Id = Guid.NewGuid() }; // Replace with your expected result
            _repository.Setup(repo => repo.CreateCommit(commitDto)).ReturnsAsync(createdCommitDto);

            // Act
            var result = await _controller.CreateCommit(commitDto);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var model = Assert.IsType<CommitDto>(okResult.Value);
            Assert.Equal(createdCommitDto, model);
        }

        // Write similar tests for other controller actions and possible error cases.
    }
}