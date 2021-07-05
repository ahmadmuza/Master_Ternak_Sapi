Imports MySql.Data.MySqlClient
Imports System.Data
Module konekan
    Public conn As MySqlConnection
    Public MyCommand As MySqlCommand
    Public myadpter As MySqlDataAdapter
    Public RD As MySqlDataReader
    Public mydata As New DataTable
    Public SQL As String
    Sub Koneksi()
        SQL = "server=localhost;user id=root;password=user;database=db_master;convert zero datetime=true"
        conn = New MySqlConnection(SQL)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
