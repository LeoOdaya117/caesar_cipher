Public Class Form1

    Dim shiftkey As Integer

    Private Sub encryptbtn_Click(sender As Object, e As EventArgs) Handles encryptbtn.Click
        shiftkey = Integer.Parse(shiftkeytxt.Text)
        outputtxt.Text = CaesarCipher(plaintexttxt.Text, shiftkey)
    End Sub

    Private Sub decryptbtn_Click(sender As Object, e As EventArgs) Handles decryptbtn.Click
        shiftkey = Integer.Parse(shiftkeytxt.Text)
        outputtxt.Text = CaesarCipher(outputtxt.Text, -shiftkey)
    End Sub

    Function CaesarCipher(ByVal text As String, ByVal shift As Integer)
        Dim result As String = ""

        For Each c As Char In text
            If Char.IsLetter(c) Then
                Dim base As Integer = If(Char.IsUpper(c), Asc("A"), Asc("a"))
                Dim offset As Integer = (Asc(c) - base + shift) Mod 26
                If offset < 0 Then
                    offset += 26
                End If
                Dim encryotedChar As Char = Chr(base + offset)
                result &= encryotedChar
            Else
                result &= c
            End If
        Next

        Return result
    End Function
End Class
