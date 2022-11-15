Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient


Public Class Form4
    Dim connection As New MySqlConnection("datasource=localhost;port=3307;username=root;password=;database=supply_office")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As New MySqlCommand("SELECT `username`, `password` FROM `admin` WHERE `username` = @username AND `password` = @password", connection)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Invalid Username Or Password")

        Else

            Dim adapter2 As New MySqlDataAdapter("SELECT `admin_id`, `admin_name`, `admin_rank`, `username`, `password` FROM admin WHERE username=" & username.Text, connection)
            Dim table2 As New DataTable()

            adapter2.Fill(table2)

            Dim newForm As New Form1()
            newForm.admin_id = table2(0)(0)
            newForm.Aname = table2(0)(1)
            newForm.password = table2(0)(4)
            newForm.username = username.Text
            newForm.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub

    Private Sub showhide_CheckedChanged(sender As Object, e As EventArgs) Handles showhide.CheckedChanged
        If password.UseSystemPasswordChar = True Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True

        End If
    End Sub
End Class