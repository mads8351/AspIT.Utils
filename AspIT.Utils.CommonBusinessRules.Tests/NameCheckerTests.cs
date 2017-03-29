using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspIT.Utils.CommonBusinessRules.Tests
{
    [TestClass]
    public class NameCheckerTests
    {
        [TestMethod]
        public void IsValidNamePass()
        {
            // Arrange: 
            string s = "Frederik";
            string s1 = "Termin-ator";
            string s2 = "Creenis";
            bool expected = true;
            bool actual;

            // Act: 
            actual = NameChecker.IsValidName(s) && NameChecker.IsValidName(s1) && NameChecker.IsValidName(s2);

            // Assert: 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsInvalidNamePass()
        {
            // Arrange:
            string s = "0123456789";
            string s1 = "!#%&/?|";
            string s2 = "Bongo-trommer.";
            bool expected = false;
            bool actual;

            // Act:
            actual = NameChecker.IsValidName(s) && NameChecker.IsValidName(s1) && NameChecker.IsValidName(s2);

            // Assert: 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsLowercaseValidNamePass()
        {
            // Arrange: 
            string s = "von";
            string s1 = "di";
            string s2 = "la";
            bool expected = true;
            bool actual;

            // Act: 
            actual = NameChecker.IsValidName(s) && NameChecker.IsValidName(s1) && NameChecker.IsValidName(s2);

            // Assert: 
            Assert.AreEqual(expected, actual);
        }
    }
}
