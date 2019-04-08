using OopLearning.BL.Inheritance;
using System;
using Xunit;

namespace OopLearning.BLTest.Inheritance
{
    public class DocumentFileInfoTest
    {
        [Fact]
        public void IsSizeTooLarge_TooLargeSizeShouldReturnTrue()
        {
            DocumentFileInfo document = new DocumentFileInfo("Dokument", 50000000, DateTime.Now);
            Assert.True(document.IsSizeTooLarge(), $"{document.FileSize} should be too large");
        }
        [Fact]
        public void IsSizeTooLarge_NotTooLargeSizeShouldReturnFalse()
        {
            DocumentFileInfo document = new DocumentFileInfo("Dokument", 50000, DateTime.Now);
            Assert.False(document.IsSizeTooLarge(), $"{document.FileSize} should not be too large");
        }
    }
}
