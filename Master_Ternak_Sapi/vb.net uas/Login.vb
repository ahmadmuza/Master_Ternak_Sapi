Public Class Login
    Private Sub blogin_Click(sender As Object, e As EventArgs) Handles blogin.Click
        If tbusername.Text = "muza" And tbPassword.Text = "12345" Then
            MsgBox("Berhasil", vbInformation + vbOKOnly, "Berhasil")
            Dim fmenu As New Menu
            fmenu.Show()
            Me.Hide()
        Else
            MsgBox("Gagal", vbCritical + vbOKOnly, "Gagal")
        End If

    End Sub

    Private Sub bkeluar_Click(sender As Object, e As EventArgs) Handles bkeluar.Click
        Dim keluar As Integer
        keluar = MsgBox("Benarkah Anda Akan Keluar ?", vbYesNo + vbQuestion, "exit")
        If keluar = vbYes Then
            End
        End If
    End Sub
End Class
