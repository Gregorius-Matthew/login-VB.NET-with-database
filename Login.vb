Imports MySql.Data.MySqlClient

Public Class Login

    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader


    Sub koneksi()
        Try
            Dim strConn As String = "server=localhost;user id=root;password=;database=database_pbo"
            conn = New MySqlConnection(strConn)

            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Console.WriteLine("berhasil koneksi")
            End If

        Catch ex As Exception
            Console.WriteLine("koneksi gagal: " & ex.Message)
        End Try

    End Sub






    Private Sub btnproses_Click(sender As Object, e As EventArgs) Handles btnproses.Click
        'If txtpass.Text = "rahasia" Then
        '    MsgBox("password anda benar",
        '           MsgBoxStyle.Information,
        '           "info login")
        '    Main_Menu.Show()
        'Else
        '    MsgBox("password yang anda masukkan salah",
        '           16,
        '           "info login")
        '    Me.Close()
        'End If




        'validasi input-------------------------------------------------------
        If txtUsername.Text = "" Or txtpass.Text = "" Then
            MsgBox("Username atau Password kosong", MsgBoxStyle.Information, "Info Login")
            Exit Sub
        End If

        Try
            koneksi()

            'gunakan parameter untuk keamanan
            Dim query As String = "Select * from tbl_Login WHERE username=@user AND password=@pass"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user", txtUsername.Text)
            cmd.Parameters.AddWithValue("@pass", txtpass.Text)

            rd = cmd.ExecuteReader()

            If rd.HasRows Then
                MsgBox("Login Berhasil", MsgBoxStyle.Information, "Info Login")
                Me.Hide()
                Main_Menu.Show()

            Else
                MsgBox("Username atau password salah", MsgBoxStyle.Critical, "Info Login")
            End If

        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If conn IsNot Nothing Then conn.Close()

        End Try
    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub
End Class