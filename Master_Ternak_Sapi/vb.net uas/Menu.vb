Public Class Menu
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub
    Sub buka_form(ByVal fr As Form)
        For Each f As Form In Me.MdiChildren
            If f.Name = fr.Name Then
                MsgBox("sudah terbuka")
                Exit Sub
            End If
        Next
        fr.MdiParent = Me
        fr.Show()
    End Sub
    Private Sub DataPemilikToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPemilikToolStripMenuItem.Click
        buka_form(pemilik)
    End Sub

    Private Sub JenisSapiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisSapiToolStripMenuItem.Click
        buka_form(sapi)
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click
        buka_form(transaksi)
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        buka_form(laporan)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim log As New Login
        log.Show()
        Me.Close()
    End Sub

End Class