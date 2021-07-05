Imports MySql.Data.MySqlClient
Imports System.Data
Public Class sapi
    Sub Tampil()
        Call koneksi()
        myadpter = New MySqlDataAdapter("select * From jenis_sapi ", conn)
        mydata = New DataTable
        myadpter.Fill(mydata)
        dgv_sapi.DataSource = mydata
        dgv_sapi.ReadOnly = True
    End Sub

    Private Sub sapi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampil()
    End Sub
    Sub Kosongkan()
        tbid_sapi.Text = ""
        tbjenis_sapi.Text = ""
        tbharga.Text = ""
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If tbid_sapi.Text = "" Or tbjenis_sapi.Text = "" Then
            MsgBox("Silahkan Isi Semua Form")
        Else
            Call Koneksi()
            Dim simpan As String = "insert into jenis_sapi values ('" & tbid_sapi.Text & "','" & tbjenis_sapi.Text & "','" & tbharga.Text & "')"
            MyCommand = New MySqlCommand(simpan, conn)
            MyCommand.ExecuteNonQuery()
            MsgBox("Input data berhasil")
            Call Tampil()
            Call Kosongkan()
        End If
    End Sub
    Private Sub tbid_sapi_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbid_sapi.KeyPress
        tbid_sapi.MaxLength = 6
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            MyCommand = New MySqlCommand("Select * From jenis_sapi  where id_sapi='" & tbid_sapi.Text & "'", conn)
            RD = MyCommand.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                MsgBox("id_pemilik Tidak Ada, Silahkan coba lagi!")
                tbid_sapi.Focus()
            Else
                tbjenis_sapi.Text = RD.Item("jenis_sapi")
                tbharga.Text = RD.Item("harga")
                tbjenis_sapi.Focus()
            End If
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Call Koneksi()
        Dim edit As String = "update jenis_sapi set id_sapi='" & tbid_sapi.Text & "',jenis_sapi='" & tbjenis_sapi.Text & "',harga='" & tbharga.Text & "' where id_sapi='" & tbid_sapi.Text & "'"
        MyCommand = New MySqlCommand(edit, conn)
        MyCommand.ExecuteNonQuery()
        MsgBox("Data Berhasil diUpdate")
        Call Tampil()
        Call Kosongkan()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If tbid_sapi.Text = "" Then
            MsgBox("Silahkan Pilih Data yang akan di hapus dengan Masukan id_pemilik dan ENTER")
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call Koneksi()
                Dim hapus As String = "delete From jenis_sapi where id_sapi='" & tbid_sapi.Text & "'"
                MyCommand = New MySqlCommand(hapus, conn)
                MyCommand.ExecuteNonQuery()
                Call Tampil()
                Call Kosongkan()
            End If
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Close()
    End Sub
End Class