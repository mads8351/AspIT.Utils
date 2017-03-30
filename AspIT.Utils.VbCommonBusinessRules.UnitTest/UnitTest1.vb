Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports AspIT.Utils.Collections
Imports System.IO

<TestClass()> Public Class VBNameCheckerTests

  <TestMethod()> Public Sub ValidNamesPasses()
    Dim testValues As List(Of String) = New List(Of String)
    Dim reader As StreamReader = New StreamReader("C:\SourceCodes\Textfiles\Names.txt")
    Dim line As String = Nothing
    While ((line = reader.ReadLine))

    End While
    Dim TD As TestDictionary(Of String, Boolean) = New TestDictionary(Of String, Boolean)


  End Sub

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