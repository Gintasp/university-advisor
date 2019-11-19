using System.Web;
using Moq;
using Xunit;
using Advisor.Services.IO;

namespace Advisor.Tests
{
    public class FileManagerTests
    {
        [Fact]
        public void UploadFile_ValidSize()
        {
            //Arrange
            Mock<HttpPostedFileBase> fileMock = new Mock<HttpPostedFileBase>();
            FileManager fileManager = new FileManager();
            var expected = true;

            fileMock
                .Setup(f => f.ContentLength)
                .Returns(10);

            fileMock
                .Setup(f => f.FileName)
                .Returns("testimage.jpeg");

            //Act
            var actual = fileManager.UploadFile(fileMock.Object);
            
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UploadFile_InvalidSize()
        {
            //Arrange
            Mock<HttpPostedFileBase> fileMock = new Mock<HttpPostedFileBase>();
            FileManager fileManager = new FileManager();
            var expected = false;

            fileMock
                .Setup(f => f.ContentLength)
                .Returns(-1);

            fileMock
                .Setup(f => f.FileName)
                .Returns("testimage.jpeg");

            //Act
            var actual = fileManager.UploadFile(fileMock.Object);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UploadFile_NoName()
        {
            //Arrange
            Mock<HttpPostedFileBase> fileMock = new Mock<HttpPostedFileBase>();
            FileManager fileManager = new FileManager();
            var expected = true;

            fileMock
                .Setup(f => f.ContentLength)
                .Returns(50);

            fileMock
                .Setup(f => f.FileName)
                .Returns("");

            //Act
            var actual = fileManager.UploadFile(fileMock.Object);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
