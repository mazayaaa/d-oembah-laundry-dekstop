Imports System.Data.Odbc

Public Class Login

    Public nameUser As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If username.Text = "" Or password.Text = "" Then
            MsgBox("Username dan Password Tidak Boleh Kosong!")
        Else
            Call Koneksi()
            Cmd = New OdbcCommand("Select * From tbl_owner where nama_owner='" & username.Text & "' and password_owner = '" & password.Text & "'", Conn)
            RD = Cmd.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                username.Text = RD!nama_owner
                password.Text = RD!password_owner
                nameUser = RD!nama_owner
                Dashboard.Show()
                Me.Hide()
            Else
                MsgBox("User atau Password Salah")
            End If
        End If
        username.Clear()
        password.Clear()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class