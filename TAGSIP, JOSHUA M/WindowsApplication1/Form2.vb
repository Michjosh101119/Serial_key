Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub REGISTER_Click(sender As Object, e As EventArgs) Handles REGISTER.Click
        '08032000
        If My.Settings.SerialKey = TextBox1.Text Then
            My.Settings.AppStat = "Full Version"
            My.Settings.Save()
            Close()
        Else
            MsgBox("Invalid Serial Key")

        End If

    End Sub
End Class