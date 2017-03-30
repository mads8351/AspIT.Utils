using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspIT.Utils.CommonBusinessTypes;

namespace AspIT.Utils.Tests
{
  [TestClass]
  public class UserCredentialsTests
  {
    [TestMethod]
    public void IsTwoUserCredentialsEqualTest()
    {
      // Arrange:
      UserCredentials u1 = new UserCredentials("Username", "Password");
      UserCredentials u2 = new UserCredentials("Username", "Password");
      bool actual;
      bool expected = true;

      // Act:
      actual = u1.Equals(u2);

      // Assert:
      Assert.AreEqual(expected, actual);
    }
  }
}
