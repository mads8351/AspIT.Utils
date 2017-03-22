using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspIT.Utils.CommonBusinessTypes;

namespace AspIT.Utils.CommonBusinessTypes.Tests
{
  /// <summary>
  /// Summary description for PersonAndDerivedClassesTests
  /// </summary>
  [TestClass]
  public class PersonAndDerivedClassesTests
  {
    public PersonAndDerivedClassesTests()
    {

    }

    private TestContext testContextInstance;

    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext
    {
      get
      {
        return testContextInstance;
      }
      set
      {
        testContextInstance = value;
      }
    }

    #region Additional test attributes
    //
    // You can use the following additional attributes as you write your tests:
    //
    // Use ClassInitialize to run code before running the first test in the class
    // [ClassInitialize()]
    // public static void MyClassInitialize(TestContext testContext) { }
    //
    // Use ClassCleanup to run code after all tests in a class have run
    // [ClassCleanup()]
    // public static void MyClassCleanup() { }
    //
    // Use TestInitialize to run code before running each test 
    // [TestInitialize()]
    // public void MyTestInitialize() { }
    //
    // Use TestCleanup to run code after each test has run
    // [TestCleanup()]
    // public void MyTestCleanup() { }
    //
    #endregion

    [TestMethod]
    public void ToStringTest()
    {
      // Arrange:
      Student student1 = new Student("Math", "Mads", "Randeris");
      Student student2 = new Student("English", "Mads", "Bob");
      Student student3 = new Student("Programming", "Mads", "Sam");
      Student student4 = new Student("Dansk", "Mads", "Lol");
      string expectedToString1 = "Navn: Mads Randeris Fag: Math";
      string expectedToString2 = "Navn: Mads Bob Fag: English";
      string expectedToString3 = "Navn: Mads Sam Fag: Programming";
      string expectedToString4 = "Navn: Mads Lol Fag: Dansk";

      // Act:
      string actualToString1 = student1.ToString();
      string actualToString2 = student2.ToString();
      string actualToString3 = student3.ToString();
      string actualToString4 = student4.ToString();

      // Assert:
      Assert.AreEqual(expectedToString1, actualToString1);
      Assert.AreEqual(expectedToString2, actualToString2);
      Assert.AreEqual(expectedToString3, actualToString3);
      Assert.AreEqual(expectedToString4, actualToString4);
    }
  }
}
