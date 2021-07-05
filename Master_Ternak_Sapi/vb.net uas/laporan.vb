Imports MySql.Data.MySqlClient
Imports System.Data
Public Class laporan
    Sub tampil()
        Call Koneksi()
        myadpter = New MySqlDataAdapter(" SELECT id,tgl,jumlah,lama_ternak,harga_bensin,laba_bersih,Jenis_sapi from perhitungan where tgl >='" & Format(tgl_mulai.Value, "yyyy/MM/dd") & "' and tgl <= '" & Format(tgl_sampai.Value, "yyyy/MM/dd") & "'", conn)
        mydata = New DataTable
        myadpter.Fill(mydata)
        Dgtampil.DataSource = mydata
        Dgtampil.ReadOnly = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tampil()
    End Sub
End Class