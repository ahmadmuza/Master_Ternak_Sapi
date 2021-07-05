Imports MySql.Data.MySqlClient
Imports System.Data
Public Class transaksi
    Sub kondisiawal()
        tb_jumlah.Text = ""
        tb_tanggal.Text = Today
        tb_moal.Text = ""
        tb_hajul.Text = ""
        labal.Text = ""
        cb_bensin.Text = ""
        cb_pemilik.Text = ""
        cb_sapi.Text = ""
        labal.Text = ""
        untung.Text = ""
        tb_no.Text = ""
        cb_lama.Text = ""
        bens.Text = ""
        tb_harga.Text = ""
        tb_nama.Text = ""
        tb_jenis.Text = ""
    End Sub
    Sub Dg()
        Call Koneksi()
        myadpter = New MySqlDataAdapter("select * From perhitungan ", conn)
        mydata = New DataTable
        myadpter.Fill(mydata)
        Dgperhitung.DataSource = mydata
        Dgperhitung.ReadOnly = True
    End Sub
    Sub muncul_pemilik()
        Call Koneksi()
        MyCommand = New MySqlCommand("select* from tbl_pemilik", conn)
        RD = MyCommand.ExecuteReader
        Do While RD.Read
            cb_pemilik.Items.Add(RD.Item(0))
        Loop
    End Sub
    Sub muncul_sapi()
        Call Koneksi()
        MyCommand = New MySqlCommand("select* from jenis_sapi", conn)
        RD = MyCommand.ExecuteReader
        Do While RD.Read
            cb_sapi.Items.Add(RD.Item(0))
        Loop

    End Sub
    Private Sub transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
        Call muncul_pemilik()
        Call muncul_sapi()
        Call Dg()
    End Sub
    Private Sub cb_pemilik_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_pemilik.SelectedIndexChanged
        Call Koneksi()
        MyCommand = New MySqlCommand("select * from tbl_pemilik where id_pemilik='" & cb_pemilik.Text & "'", conn)
        RD = MyCommand.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            tb_nama.Text = RD!nama
            tb_moal.Text = RD!modal_awal
        End If
    End Sub

    Private Sub cb_sapi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_sapi.SelectedIndexChanged
        Call Koneksi()
        MyCommand = New MySqlCommand("select * from jenis_sapi where id_sapi='" & cb_sapi.Text & "'", conn)
        RD = MyCommand.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            tb_jenis.Text = RD!jenis_sapi
            tb_harga.Text = RD!harga
        End If
    End Sub
    Public utg As Integer
    Private Sub cb_lama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_lama.SelectedIndexChanged
        Select Case cb_lama.Text
            Case "1 Tahun"
                untung.Text = "Rp 14.000.000"
                utg = 14000000
            Case "2 Tahun"
                untung.Text = "Rp 28.000.000"
                utg = 28000000
            Case "3 Tahun"
                untung.Text = "Rp 42.000.000"
                utg = 42000000
            Case "4 Tahun"
                untung.Text = "Rp 56.000.000"
                utg = 56000000
            Case "5 Tahun"
                untung.Text = "Rp 70.000.000"
                utg = 70000000
            Case "6 Tahun"
                untung.Text = "Rp 84.000.000"
                utg = 84000000
            Case "7 Tahun"
                untung.Text = "Rp 98.000.000"
                utg = 98000000
            Case "8 Tahun"
                untung.Text = "Rp 112.000.000"
                utg = 112000000
            Case "9 Tahun"
                untung.Text = "Rp 126.000.000"
                utg = 126000000
            Case "10 Tahun"
                untung.Text = "Rp 140.000.000"
                utg = 140000000
        End Select
    End Sub
    Public bsn As Integer
    Private Sub cb_bensin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_bensin.SelectedIndexChanged
        Select Case cb_bensin.Text
            Case "1 Tahun"
                bens.Text = "Rp 1.020.000"
                bsn = 1020000
            Case "2 Tahun"
                bens.Text = "Rp 2.040.000"
                bsn = 2040000
            Case "3 Tahun"
                bens.Text = "Rp 3.060.000"
                bsn = 3060000
            Case "4 Tahun"
                bens.Text = "Rp 4.080.000"
                bsn = 4080000
            Case "5 Tahun"
                bens.Text = "Rp 5.100.000"
                bsn = 5100000
            Case "6 Tahun"
                bens.Text = "Rp 6.120.000"
                bsn = 6120000
            Case "7 Tahun"
                bens.Text = "Rp 7.140.000"
                bsn = 7140000
            Case "8 Tahun"
                bens.Text = "Rp 8.160.000"
                bsn = 8160000
            Case "9 Tahun"
                bens.Text = "Rp 9.180.000"
                bsn = 9180000
            Case "5 Th"
                bens.Text = "Rp 10.200.000"
                bsn = 10200000
        End Select
    End Sub
    Public total As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim jum, har, tung As Integer
        jum = tb_jumlah.Text
        har = tb_harga.Text
        tung = utg
        total = jum * har + tung
        tb_hajul.Text = total
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mol As Integer
        Dim laba As Integer
        mol = tb_moal.Text
        laba = total - mol - bsn
        labal.Text = "Rp." & laba.ToString
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call Koneksi()
        If tb_no.Text = "" Or tb_tanggal.Text = "" Or tb_jumlah.Text = "" Or cb_lama.Text = "" Or bens.Text = "" Or labal.Text = "" Then
            MsgBox("isi semua form")
        Else
            Dim simpan As String = "insert into perhitungan values ('" & tb_no.Text & "','" & Format(Now, "yyyy/MM/dd") & "','" & tb_jumlah.Text & "','" & cb_lama.Text & "','" & bsn &
            "','" & labal.Text & "','" & tb_jenis.Text & "')"
            MyCommand = New MySqlCommand(simpan, conn)
            MyCommand.ExecuteNonQuery()
            MsgBox("Perhitungan Tersimpan")
            Call Dg()
            Call kondisiawal()
            Call muncul_pemilik()
            Call muncul_sapi()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call kondisiawal()
        Call Dg()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If tb_no.Text = "" Then
            MsgBox("Silahkan Pilih Data yang akan di hapus dengan Masukan id_pemilik dan ENTER")
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call Koneksi()
                Dim hapus As String = "delete From perhitungan where id='" & tb_no.Text & "'"
                MyCommand = New MySqlCommand(hapus, conn)
                MyCommand.ExecuteNonQuery()
                Call Dg()
                Call kondisiawal()
                Call muncul_pemilik()
                Call muncul_sapi()
            End If
        End If
    End Sub
End Class