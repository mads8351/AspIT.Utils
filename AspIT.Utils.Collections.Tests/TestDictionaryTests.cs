using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspIT.Utils.Collections.Tests
{
    [TestClass]
    public class TestDictionaryTests
    {
        [TestMethod]
        public void InitializatonPasses()
        {
            // Arrange:
            List<string> strings = new List<string>() { "Mads", "Mikkel", "Rasmussen" };

            List<bool> results = new List<bool>();
            foreach (string testValue in strings)
            {
                results.Add(default(bool));
            }


            bool expected = true;   // for all.
            bool actual;

            // Act:
            TestDictionary<string, bool> testdic = 
                new TestDictionary<string, bool>(strings, results);
            for (int i = 0; i < testdic.Count; i++)
            {
                testdic.ReplaceTestResultAt(i, AspIT.Utils.CommonBusinessRules.NameChecker.IsValidName(
                    testdic.GetTestValueAt(i)));
            }

            // Assert:
            actual = testdic.AllTestResultsAreSame(expected);
            Assert.AreEqual(expected, actual);
        }
    }
}
