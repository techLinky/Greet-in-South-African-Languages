Public Class Form1
    Private Sub btnGreeting_Click(sender As Object, e As EventArgs) Handles btnGreeting.Click
        Dim strHomeLanguage As String
        strHomeLanguage = txtLanguage.Text.ToLower
        If strHomeLanguage = "Siswati" Then
            MsgBox("Sawubona")
        ElseIf strHomeLanguage = "IsiXhosa" Then
            MsgBox("Molo")
        ElseIf strHomeLanguage = "English" Then
            MsgBox("Hello")
        ElseIf strHomeLanguage = "Sepedi" Then
            MsgBox("Dumela")
        ElseIf strHomeLanguage = "Afrikaans" Then
            MsgBox("Hallo")
        End If



    End Sub
End Class
