using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspIT.Utils.CommonBusinessRules.Tests
{
    [TestClass]
    public class ZipCodeCheckerTests
    {
        [TestMethod]
        public void IsValidZipCode()
        {
            // Arrange: 
            string s = "8660";
            bool expected = true;
            bool actual;

            // Act: 
            actual = ZipCodeChecker.IsDanishZipCodeValid(s);

            // Assert: 
            Assert.AreEqual(expected, actual);
        }
            
    }
}
