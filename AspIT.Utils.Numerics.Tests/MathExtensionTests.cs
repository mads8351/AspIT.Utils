using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspIT.Utils.Numerics;

namespace AspIT.Utils.Numerics.Tests
{
    [TestClass]
    public class MathExtensionTests
    {
        [TestMethod]
        public void DoubleByteParamterPasses()
        {
            // Arrange:
            uint expected = byte.MaxValue * 2;

            // Act:
            uint actual = MathExtension.Double(byte.MaxValue);

            // Assert: 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoubleUShortParamterPasses()
        {
            // Arrange:
            uint expected = ushort.MaxValue * 2;

            // Act:
            uint actual  = MathExtension.Double(ushort.MaxValue);

            // Assert: 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoubleShortParamterPasses()
        {
            // Arrange:
            int expected = short.MaxValue * 2;

            // Act:
            int actual = MathExtension.Double(short.MaxValue);

            // Assert: 
            Assert.AreEqual(expected, actual);
        }
    }
}
