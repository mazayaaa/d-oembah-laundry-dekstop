Imports System.Data.Odbc

Module Module1

    Public Conn As New OdbcConnection
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public RD As OdbcDataReader
    Public Cmd As OdbcCommand
    Public myDB As String

    Public Sub Koneksi()
        Conn = New OdbcConnection("Dsn=konek_laundry;Database=db_laundry;Uid=root;Pwd=")
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

End Module