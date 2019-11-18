using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Advisor.Services.Validator;
using Moq;
using Xunit;

namespace Advisor.Tests
{
    public class FileValidatorTests
    {
        [Theory]
        [InlineData("image/jpeg")]
        [InlineData("image/png")]
        [InlineData("application/pdf")]
        [InlineData("text/plain")]
        [InlineData("application/vnd.openxmlformats-officedocument.wordprocessingml.document")]
        public void Validate_ValidType(string contentType)
        {
            //Arrange
            var expected = true;
            FileValidator fileValidator = new FileValidator();
            Mock<HttpPostedFileBase> fileMock = new Mock<HttpPostedFileBase>();
            fileMock
                .Setup(f => f.ContentType)
                .Returns(contentType);

            //Act
            var actual = fileValidator.Validate(fileMock.Object);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Validate_InvalidType()
        {
            //Arrange
            var expected = false;
            FileValidator fileValidator = new FileValidator();
            Mock<HttpPostedFileBase> fileMock = new Mock<HttpPostedFileBase>();
            fileMock
                .Setup(f => f.ContentType)
                .Returns("image/jpg");

            //Act
            var actual = fileValidator.Validate(fileMock.Object);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}