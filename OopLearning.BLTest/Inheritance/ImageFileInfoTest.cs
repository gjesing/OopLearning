using OopLearning.BL.Inheritance;
using System;
using Xunit;

namespace OopLearning.BLTest.Inheritance
{
    public class ImageFileInfoTest
    {
        [Fact]
        public void IsSizeTooLarge_TooLargeSizeShouldReturnTrue()
        {
            ImageFileInfo image = new ImageFileInfo("Dokument", 50000000, DateTime.Now, 1000, 1000);
            Assert.True(image.IsSizeTooLarge(), $"Filesize: {image.FileSize}, width: {image.Width} and height: {image.Height} should be too large");
        }
        [Fact]
        public void IsSizeTooLarge_NotTooLargeSizeShouldReturnFalse()
        {
            ImageFileInfo image = new ImageFileInfo("Dokument", 50000, DateTime.Now, 200, 150);
            Assert.False(image.IsSizeTooLarge(), $"Filesize: {image.FileSize}, width: {image.Width} and height: {image.Height} should not be too large");
        }
    }
}