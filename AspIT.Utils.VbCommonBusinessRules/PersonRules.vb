Public Class PersonRules

  ' Lav en funktion der hedder IsValidName. Funktionen modtager ét argument som string og kaldes name. 
  ' Funktionen returnerer en bool, som indikerer om argumentet er et gyldigt navn i vestlig kultur. 
  ' Inden argumentet processeres kaldes Trim() metoden på name. Et navn starter altid med stort, må kun indeholder bogstaver og bindestreg(er).

  Function isValidName(name As String)
    Dim trimedString As String = name.Trim

    If System.Text.RegularExpressions.Regex.IsMatch(trimedString, "^[ÆØÅæøåA-Za-z]+$") Then
      Dim charArray As Char() = name
      Dim firstLetter As Char = charArray(0)

      If System.Text.RegularExpressions.Regex.IsMatch(firstLetter, "^[ÆØÅA-Z]+$") Then
        Return True
      Else
        Return False
      End If

    Else
      Return False
    End If

  End Function

End Class
