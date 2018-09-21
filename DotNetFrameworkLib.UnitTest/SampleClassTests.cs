using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DotNetFrameworkLib.UnitTest
{
    public class SampleClassTests
    {
        [Fact]
        public void DoStuff_returns_correct_result()
        {
            // Arrange
            var sut = new SampleClass();

            // Act
            var result = sut.DoStuff();

            // Assert
            Assert.Equal(42, result);
        }
    }
}
