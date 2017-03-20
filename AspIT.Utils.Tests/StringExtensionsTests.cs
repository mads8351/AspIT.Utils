using System;
using AspIT.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspIT.Utils.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void StartsWithUppercasePass()
        {
            // Arrange
            string value = "Mads";
            bool expected = true, actual;

            // Act:
            actual = value.StartsWithUppercase();

            // Assert:
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotStartsWithUppercasePass()
        {
            // Arrange:
            string value = "mads";
            bool expected = false, actual;

            // Act:
            actual = value.StartsWithUppercase();

            // Assert:
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoubleUShortParameterPasses()
        {
            // Arrange:
            uint expected = ushort.MaxValue * 2;
            uint actual;

            // Act:
            actual = 345345;

            // Assert:
            Assert.AreEqual(expected, actual);
        }
    }
}
