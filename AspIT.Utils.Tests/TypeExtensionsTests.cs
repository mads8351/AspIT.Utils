using System;
using System.Numerics;
using AspIT.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspIT.Utils.Tests
{
    [TestClass]
    public class TypeExtensionsTests
    {
        [TestMethod]
        public void CLRNumericsAndSystemNumericsPasses()
        {
            // Arrange:
            byte b = default(byte);
            sbyte sb = default(sbyte);
            ushort us = default(ushort);
            short s = default(short);
            uint ui = default(uint);
            int i = default(int);
            ulong ul = default(ulong);
            long l = default(long);
            float f = default(float);
            double d = default(double);
            decimal m = default(decimal);
            BigInteger big = default(BigInteger);
            Complex c = default(Complex);
            bool expected = true;
            bool actual;

            // Act:
            actual = TypeExtensions.IsNumeric(b) &&
                    TypeExtensions.IsNumeric(sb) &&
                    TypeExtensions.IsNumeric(us) &&
                    TypeExtensions.IsNumeric(s) &&
                    TypeExtensions.IsNumeric(ui) &&
                    TypeExtensions.IsNumeric(i) &&
                    TypeExtensions.IsNumeric(ul) &&
                    TypeExtensions.IsNumeric(l) &&
                    TypeExtensions.IsNumeric(f) &&
                    TypeExtensions.IsNumeric(d) &&
                    TypeExtensions.IsNumeric(m) &&
                    TypeExtensions.IsNumeric(big) &&
                    TypeExtensions.IsNumeric(c);

            // Assert:
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CLRNonNumericsFails()
        {
            // Arrange:
            char c = default(char);
            bool b = default(bool);
            bool expected = false;
            bool actual;

            // Act:
            actual = TypeExtensions.IsNumeric(c) &&
                    TypeExtensions.IsNumeric(b);

            // Assert:
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DefinesNumericOperators()
        {
            // Arrange:
            BigInteger big = 0;
            bool expected = true;
            bool actual;

            // Act:
            actual = TypeExtensions.DefinesNumericOperators(big);

            // Assert:
            Assert.AreEqual(expected, actual);
        }
    }
}
