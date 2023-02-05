Public Class admLogIn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If password.Text = "" Then
            MsgBox("Vendosni fjalekalimin e adminit!")
        ElseIf password.Text = "Admin" Then
            Dim obj = New PergjegjesLibrarie
            obj.Show()
            Me.Hide()
        Else
            MsgBox("Fjalekalim i gabuar!")
            password.Text = ""
        End If
    End Sub
End Class