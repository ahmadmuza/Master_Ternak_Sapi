Imports MySql.Data.MySqlClient
Imports System.Data
Public Class pemilik
    Sub TampilGrid()
        Call Koneksi()
        myadpter = New MySqlDataAdapter("select * From tbl_pemilik ", conn)
        mydata = New DataTable
        myadpter.Fill(mydata)
        dgv_pemilik.DataSource = mydata
        dgv_pemilik.ReadOnly = True
    End Sub
    Private Sub pemilik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilGrid()
    End Sub
    Sub KosongkanData()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox5.Text = ""
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Silahkan Isi Semua Form")
        Else
            Call Koneksi()
            Dim simpan As String = "insert into tbl_pemilik values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "')"
            MyCommand = New MySqlCommand(simpan, conn)
            MyCommand.ExecuteNonQuery()
            MsgBox("Input data berhasil")
            Call TampilGrid()
            Call KosongkanData()
        End If
    End Sub
    Private Sub TextBox1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 6
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            MyCommand = New MySqlCommand("Select * From tbl_pemilik  where id_pemilik='" & TextBox1.Text & "'", conn)
            RD = MyCommand.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                MsgBox("id_pemilik Tidak Ada, Silahkan coba lagi!")
                TextBox1.Focus()
            Else
                TextBox2.Text = RD.Item("nama")
                TextBox3.Text = RD.Item("alamat")
                TextBox5.Text = RD.Item("modal_awal")
                TextBox2.Focus()
            End If
        End If
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Call Koneksi()
        Dim edit As String = "update tbl_pemilik set id_pemilik='" & TextBox1.Text & "',nama='" & TextBox2.Text & "',alamat='" & TextBox3.Text & "',modal_awal='" & TextBox5.Text & "' where id_pemilik='" & TextBox1.Text & "'"
        MyCommand = New MySqlCommand(edit, conn)
        MyCommand.ExecuteNonQuery()
        Call TampilGrid()
        Call KosongkanData()
        MsgBox("Data Berhasil diUpdate")
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If TextBox1.Text = "" Then
            MsgBox("Silahkan Pilih Data yang akan di hapus dengan Masukan id_pemilik dan ENTER")
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call Koneksi()
                Dim hapus As String = "delete From tbl_pemilik where id_pemilik='" & TextBox1.Text & "'"
                MyCommand = New MySqlCommand(hapus, conn)
                MyCommand.ExecuteNonQuery()
                Call TampilGrid()
                Call KosongkanData()
            End If
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Close()
    End Sub
End Class

