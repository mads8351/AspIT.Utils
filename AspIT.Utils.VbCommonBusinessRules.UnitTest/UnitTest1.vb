Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class VBNameCheckerTests

  <TestMethod()> Public Sub ValidNamePasses()
    Dim PR As PersonRules = New PersonRules

    Dim expected As Boolean = True
    Dim actual As Boolean
    Dim testString As String = "Åajbritt"

    actual = PR.isValidName(testString)

    Assert.AreEqual(expected, actual)
  End Sub

  <TestMethod()> Public Sub NotValidNamePasses()
    Dim PR As PersonRules = New PersonRules

    Dim expected As Boolean = False
    Dim actual As Boolean
    Dim testString As String = "majbritt"

    actual = PR.isValidName(testString)

    Assert.AreEqual(expected, actual)
  End Sub

End Class